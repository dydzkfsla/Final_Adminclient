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
    public class TeamGroupConnDAC : IDisposable
    {
        SqlConnection conn;
        LoggingUtility Logging;

        public TeamGroupConnDAC()
        {
            conn = new SqlConnection();
            conn.ConnectionString = Connstring.conn;
            conn.Open();
            Logging = new LoggingUtility("TeamGroupConnDACInFo", "TeamGroupConnDACError", Level.All, 30);
            Logging.InfoFolder = "C:\\FP\\Log\\TeamGroupConnDAC\\Info";
            Logging.ErrorFolder = "C:\\FP\\Log\\TeamGroupConnDAC\\Error";
        }

        #region select
        /// <summary>
        /// 모든 정보 조회
        /// </summary>
        /// <returns></returns>
        public List<TeamGroupConnVO> GetAllTeamGroupConnVO()
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "select Team_Code, Grp_No from Team_Group_Conn"
                };
                using (SqlDataReader reader = sql.ExecuteReader())
                {
                    return Helper.DataReaderMapToList<TeamGroupConnVO>(reader);
                }
            }
            catch (Exception err)
            {
                Logging.WriteError($"실행자:{Global.employees.Emp_Name} 팀 conn 그룹 정보 Select중 오류" + err.Message, err);
                return null;
            }
        }
        #endregion

        #region insert
        public bool InsertTeamGroupConn(string Team_Code, int Grp_No)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "insert into Team_Group_Conn(Team_Code, Grp_No, Fst_Writer) values(@Team_Code, @Grp_No, @Fst_Writer)"
                };

                sql.Parameters.AddWithValue("@Team_Code", Team_Code);
                sql.Parameters.AddWithValue("@Grp_No", Grp_No);
                sql.Parameters.AddWithValue("@Fst_Writer", Global.employees.Emp_Code);

                bool Execut = sql.ExecuteNonQuery() > 0 ? true : false;

                if (Execut)
                {
                    Logging.WriteInfo($"실행자:{Global.employees.Emp_Name}  팀 conn 그룹 입력중 수정 | {Team_Code} | {Grp_No}");
                }
                return Execut;
            }
            catch (Exception err)
            {
                Logging.WriteError($"실행자:{Global.employees.Emp_Name} 팀 conn 그룹 입력중 오류" + err.Message, err);
                return false;
            }
        }
        #endregion

        #region delete
        #region Team_Code, Grp_No delete
        public bool DeleteTeamGroupConn(string Team_Code, int Grp_No)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "Delete From Team_Group_Conn where Team_Code = @Team_Code and Grp_No = @Grp_No"
                };

                sql.Parameters.AddWithValue("@Team_Code", Team_Code);
                sql.Parameters.AddWithValue("@Grp_No", Grp_No);

                bool Execut = sql.ExecuteNonQuery() > 0 ? true : false;

                if (Execut)
                {
                    Logging.WriteInfo($"실행자:{Global.employees.Emp_Name} 팀 conn 그룹 삭제 | {Team_Code} | {Grp_No}");
                }
                return Execut;
            }
            catch (Exception err)
            {
                Logging.WriteError($"실행자:{Global.employees.Emp_Name} 팀 conn 그룹 삭제중 오류" + err.Message, err);
                return false;
            }
        }
        #endregion

        #region Team_Code delete
        public bool DeleteFromTeamConn(string Team_Code)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "Delete From Team_Group_Conn where Team_Code = @Team_Code"
                };
                sql.Parameters.AddWithValue("@Team_Code", Team_Code);

                bool Execut = sql.ExecuteNonQuery() > 0 ? true : false;

                if (Execut)
                {
                    Logging.WriteInfo($"실행자:{Global.employees.Emp_Name} 팀 conn 삭제 | {Team_Code}");
                }
                return Execut;
            }
            catch (Exception err)
            {
                Logging.WriteError($"실행자:{Global.employees.Emp_Name} 팀 conn 삭제중 오류" + err.Message, err);
                return false;
            }
        }
        #endregion


        #endregion

        public void Dispose()
        {
            Logging.CloseRoller();
            conn.Dispose();
        }
    }
}
