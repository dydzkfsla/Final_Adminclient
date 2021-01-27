using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminClientVO;
using log4net.Core;

namespace AdminClientDAC
{
    public class EmployeesDAC : IDisposable
    {
        SqlConnection conn = null;
        LoggingUtility Info;

        public EmployeesDAC()
        {
            conn = new SqlConnection(Connstring.conn);
            conn.Open();
            Info = new LoggingUtility("EmployeesDACInFo", "EmployeesDACError", Level.All, 30);
            Info.InfoFolder = "C:\\FP\\Log\\EmployeesDAC\\Info";
            Info.ErrorFolder = "C:\\FP\\Log\\EmployeesDAC\\Error";
        }



        #region 스토어드 프로시저
        #region 선택 셀렉트
        /// <summary>
        /// 값에 따른 값을전달하여 해당한 값을 전달 null인 것은 제외
        /// </summary>
        /// <param name="LimitCount"></param>
        /// <param name="Team_Code"></param>
        /// <param name="HireDateFrom"></param>
        /// <param name="HireDateTo"></param>
        /// <param name="RetireDateFrom"></param>
        /// <param name="RetireDateTo"></param>
        /// <returns></returns>
        public List<EmployeesTeamVO> SerchSelectEmployees(int LimitCount, string Team_Code
                                                            , string HireDateFrom, string HireDateTo
                                                            , string RetireDateFrom, string RetireDateTo)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "SP_SelectEmployees",
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                sql.Parameters.AddWithValue("@LimitCount", LimitCount);
                sql.Parameters.AddWithValue("@Team_Code", Team_Code == null ? DBNull.Value : (object)Team_Code);
                sql.Parameters.AddWithValue("@HireDateFrom", HireDateFrom == null ? DBNull.Value : (object)HireDateFrom);
                sql.Parameters.AddWithValue("@HireDateTo", HireDateTo == null ? DBNull.Value : (object)HireDateTo);
                sql.Parameters.AddWithValue("@RetireDateFrom", RetireDateFrom == null ? DBNull.Value : (object)RetireDateFrom);
                sql.Parameters.AddWithValue("@RetireDateTo", RetireDateTo == null ? DBNull.Value : (object)RetireDateTo);

                using (SqlDataReader reader = sql.ExecuteReader())
                {
                    return Helper.DataReaderMapToList<EmployeesTeamVO>(reader);
                }
            }catch(Exception err)
            {
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 직원 정보 검색 오류 : | SP_SelectEmployees " + err.Message, err);
                return null;
            }

        }

        #endregion

        #endregion


        public void Dispose()
        {
            Info.CloseRoller();
            conn.Close();
        }

    }
}
