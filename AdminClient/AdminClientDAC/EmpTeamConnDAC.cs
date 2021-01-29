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
    public class EmpTeamConnDAC : IDisposable
    {

        SqlConnection conn;
        LoggingUtility Logging;

        public EmpTeamConnDAC()
        {
            conn = new SqlConnection();
            conn.ConnectionString = Connstring.conn;
            conn.Open();
            Logging = new LoggingUtility("EmpTeamConnDACInFo", "EmpTeamConnDACError", Level.All, 30);
            Logging.InfoFolder = "C:\\FP\\Log\\EmpTeamConnDAC\\Info";
            Logging.ErrorFolder = "C:\\FP\\Log\\EmpTeamConnDAC\\Error";
        }

        #region select
        #region 전부검색
        /// <summary>
        /// 모든 정보 조회
        /// </summary>
        /// <returns></returns>
        public List<EmpTeamConnVO> GetAllEmpTeamConnVO()
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "select Emp_Code, Team_Code from Emp_Team_Conn"
                };
                using (SqlDataReader reader = sql.ExecuteReader())
                {
                    return Helper.DataReaderMapToList<EmpTeamConnVO>(reader);
                }
            }
            catch (Exception err)
            {
                Logging.WriteError($"실행자:{Global.employees.Emp_Name} 직원 팀 conn 정보 Select중 오류" + err.Message, err);
                return null;
            }
        }
        #endregion

        #region 직원 세부검색
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<EmpTeamConnVO> GetEmpTeamConnVO(string Emp_Code)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "select Emp_Code, Team_Code from Emp_Team_Conn where Emp_Code = @Emp_Code"
                };

                sql.Parameters.AddWithValue("@Emp_Code", Emp_Code);
                using (SqlDataReader reader = sql.ExecuteReader())
                {
                    return Helper.DataReaderMapToList<EmpTeamConnVO>(reader);
                }
            }
            catch (Exception err)
            {
                Logging.WriteError($"실행자:{Global.employees.Emp_Name} 직원 팀 conn 그룹 정보 Select중 오류" + err.Message, err);
                return null;
            }
        }
        #endregion

        #endregion

        #region inset
        public bool InsetEmpTeamConn(string Emp_Code, string Team_Code)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "insert into Emp_Team_Conn(Emp_Code, Team_Code, Fst_Writer) values(@Emp_Code, @Team_Code, @Fst_Writer)"
                };

                sql.Parameters.AddWithValue("@Emp_Code", Emp_Code);
                sql.Parameters.AddWithValue("@Team_Code", Team_Code);
                sql.Parameters.AddWithValue("@Fst_Writer", Global.employees.Emp_Name);

                bool Execut = sql.ExecuteNonQuery() > 0 ? true : false;

                if (Execut)
                {
                    Logging.WriteInfo($"실행자:{Global.employees.Emp_Name} 직원 팀 conn 그룹 입력중 수정 | {Team_Code} | {Team_Code}");
                }
                return Execut;
            }
            catch (Exception err)
            {
                Logging.WriteError($"실행자:{Global.employees.Emp_Name} 직원 팀 conn 그룹 입력중 오류" + err.Message, err);
                return false;
            }
        }

        #endregion

        #region delete
        #region Emp_Code, Team_Code delete
        public bool DeleteEmpTeamConn(string Emp_Code, string Team_Code)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "Delete From Emp_Team_Conn where Emp_Code = @Emp_Code and Team_Code = @Team_Code"
                };

                sql.Parameters.AddWithValue("@Emp_Code", Emp_Code);
                sql.Parameters.AddWithValue("@Team_Code", Team_Code);

                bool Execut = sql.ExecuteNonQuery() > 0 ? true : false;

                if (Execut)
                {
                    Logging.WriteInfo($"실행자:{Global.employees.Emp_Name} 직원 팀 conn 삭제 | {Emp_Code} | {Team_Code}");
                }
                return Execut;
            }
            catch (Exception err)
            {
                Logging.WriteError($"실행자:{Global.employees.Emp_Name} 직원 팀 conn 삭제중 오류" + err.Message, err);
                return false;
            }
        }
        #endregion

        #region Team_Code delete
        public bool DeleteEmpTeamConn(string Emp_Code)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "Delete From Emp_Team_Conn where Emp_Code = @Emp_Code"
                };
                sql.Parameters.AddWithValue("@Emp_Code", Emp_Code);

                bool Execut = sql.ExecuteNonQuery() > 0 ? true : false;

                if (Execut)
                {
                    Logging.WriteInfo($"실행자:{Global.employees.Emp_Name} 직원 팀 conn 삭제 | {Emp_Code}");
                }
                return Execut;
            }
            catch (Exception err)
            {
                Logging.WriteError($"실행자:{Global.employees.Emp_Name} 직원 팀 conn 삭제중 오류" + err.Message, err);
                return false;
            }
        }
        #endregion
        #endregion

        public void Dispose()
        {
            conn.Close();
            Logging.CloseRoller();
        }
    }
}
