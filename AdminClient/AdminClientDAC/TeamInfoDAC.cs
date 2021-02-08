using AdminClientVO;
using log4net.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientDAC
{
    public class TeamInfoDAC : IDisposable
    {

        SqlConnection conn;
        LoggingUtility Logging;

        public TeamInfoDAC()
        {
            conn = new SqlConnection();
            conn.ConnectionString = Connstring.conn;
            conn.Open();
            Logging = new LoggingUtility("TeamInfoDACInFo", "TeamInfoDACError", Level.All, 30);
            Logging.InfoFolder = "C:\\FP\\Log\\TeamInfoDAC\\Info";
            Logging.ErrorFolder = "C:\\FP\\Log\\TeamInfoDAC\\Error";
        }

        #region select
        /// <summary>
        /// 모든 vo가져옴
        /// </summary>
        /// <returns></returns>
        public List<TeamInfoVO> AllTeamInfoVO()
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "select Team_Code, Team_Name, Team_Chief, Team_Part from Team_Info"
                };
                using (SqlDataReader reader = sql.ExecuteReader())
                {
                    return Helper.DataReaderMapToList<TeamInfoVO>(reader);
                }
            }
            catch (Exception err)
            {
                Logging.WriteError($"실행자:{Global.employees.Emp_Name} 그룹 정보 Select중 오류" + err.Message, err);
                return null;
            }
        }
        #endregion

        #region insert
        public bool InserTeamInfo(string Team_Code, string Team_Name, string Team_Chief, string Team_Part)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "insert into Team_Info(Team_Code, Team_Name, Team_Chief, Team_Part, Fst_Writer) values (@Team_Code, @Team_Name, @Team_Chief, @Team_Part, @Fst_Writer)"
                };
                sql.Parameters.AddWithValue("@Team_Code", Team_Code);
                sql.Parameters.AddWithValue("@Team_Name", Team_Name);
                sql.Parameters.AddWithValue("@Team_Chief", string.IsNullOrEmpty(Team_Chief) ? DBNull.Value: (object)Team_Chief);
                sql.Parameters.AddWithValue("@Team_Part", string.IsNullOrEmpty(Team_Part) ? DBNull.Value : (object)Team_Part);
                sql.Parameters.AddWithValue("@Fst_Writer", Global.employees.Emp_Code);

                bool Execut = sql.ExecuteNonQuery() > 0 ? true : false;

                if (Execut)
                {
                    Logging.WriteInfo($"실행자:{Global.employees.Emp_Name} 팀 정보 입력 | {Team_Code} : {Team_Name} : {Team_Chief}  : {Team_Part}");
                }

                return Execut;
            }
            catch (Exception err)
            {
                Logging.WriteError($"실행자:{Global.employees.Emp_Name} 팀 입력중 오류" + err.Message, err);
                return false;
            }
        }
        #endregion

        #region delete
        public bool DeleteTeamInfo(string Team_Code)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "delete from Team_Info where Team_Code = @Team_Code"
                };
                sql.Parameters.AddWithValue("@Team_Code", Team_Code);

                bool Execut = sql.ExecuteNonQuery() > 0 ? true : false;

                if (Execut)
                {
                    Logging.WriteInfo($"실행자:{Global.employees.Emp_Code} 팀 삭제 | {Team_Code}");
                }

                return Execut;
            }
            catch (Exception err)
            {
                Logging.WriteError($"실행자:{Global.employees.Emp_Code} 팀 삭제중 오류" + err.Message, err);
                return false;
            }
        }
        #endregion

        #region Update
        public bool UpdateTeamInfo(string Team_Code, string Team_Name, string Team_Chief, string Team_Part)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = @"update Team_Info set 
                                    Team_Name = @Team_Name,
                                    Team_Chief = @Team_Chief,
                                    Team_Part = @Team_Part,
                                    Lst_Writer = @Lst_Writer,
                                    Lst_WriteDate = getdate()
                                    where Team_Code = @Team_Code"
                };
                sql.Parameters.AddWithValue("@Team_Code", Team_Code);
                sql.Parameters.AddWithValue("@Team_Name", Team_Name);
                sql.Parameters.AddWithValue("@Team_Chief", string.IsNullOrEmpty(Team_Chief) ? DBNull.Value : (object)Team_Chief);
                sql.Parameters.AddWithValue("@Team_Part", string.IsNullOrEmpty(Team_Part) ? DBNull.Value : (object)Team_Part);
                sql.Parameters.AddWithValue("@Lst_Writer", Global.employees.Emp_Code);

                bool Execut = sql.ExecuteNonQuery() > 0 ? true : false;

                if (Execut)
                {
                    Logging.WriteInfo($"실행자:{Global.employees.Emp_Name} 팀 수정 | {Team_Code} | {Team_Name} | {Team_Chief} | {Team_Part}");
                }


                return Execut;
            }
            catch (Exception err)
            {
                Logging.WriteError($"실행자:{Global.employees.Emp_Name} 팀 수정중 오류" + err.Message, err);
                return false;
            }
        }

        #endregion

        public void Dispose()
        {
            Logging.CloseRoller();
            conn.Dispose();
        }
    }
}
