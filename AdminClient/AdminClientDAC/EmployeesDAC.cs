using System;
using System.Collections.Generic;
using System.Data;
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


        #region delete
        public bool DeleteAllEmp(string EmpCode)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = @"delete from Emp_Team_Conn where Emp_Code = @Emp_Code
                                    delete from Employees where Emp_Code = @Emp_Code;"
                };
                sql.Parameters.AddWithValue("@Emp_Code", EmpCode);

                Info.WriteInfo($"실행자:{Global.employees.Emp_Name} 직원  삭제 : | {EmpCode} ");

                
                return sql.ExecuteNonQuery() > 0;
            }
            catch (Exception err)
            {
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 직원 삭제 오류 : | SP_SelectEmployees " + err.Message, err);
                return false;
            }
        }




        #endregion


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
            }
            catch (Exception err)
            {
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 직원 정보 검색 오류 : | SP_SelectEmployees " + err.Message, err);
                return null;
            }

        }

        #endregion

        #region 직원 및 권한 추가
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
        public bool SP_InsertEmployees(EmployeesVO employees, List<string> team)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "SP_InsertEmployees",
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                DataTable tvp = new DataTable();
                tvp.Columns.Add(new DataColumn("Code", typeof(string)));

                foreach (var code in team)
                    tvp.Rows.Add(code);
                SqlParameter sqlParameter = new SqlParameter();
                sqlParameter.Direction = ParameterDirection.ReturnValue;
                sql.Parameters.Add(sqlParameter);
                SqlParameter tvparam = sql.Parameters.AddWithValue("@List", tvp);
                tvparam.SqlDbType = SqlDbType.Structured;
                tvparam.TypeName = "CodeList";
                sql.Parameters.AddWithValue("@Code", employees.Emp_Code);
                sql.Parameters.AddWithValue("@Name", employees.Emp_Name);
                sql.Parameters.AddWithValue("@Email", employees.Emp_Email);
                sql.Parameters.AddWithValue("@PostCode", employees.Emp_PostCode);
                sql.Parameters.AddWithValue("@Addr", employees.Emp_Addr);
                sql.Parameters.AddWithValue("@AddrDetail", employees.Emp_AddrDetail);
                sql.Parameters.AddWithValue("@Pwd", employees.Emp_Pwd);
                sql.Parameters.AddWithValue("@Phone", employees.Emp_Phone == null ? DBNull.Value : (object)employees.Emp_Phone);
                sql.Parameters.AddWithValue("@HireDate", employees.Emp_HireDate.ToString("yyyy-MM-dd"));
                sql.Parameters.AddWithValue("@RetireDate", employees.Emp_RetireDate.Year == 1 ? DBNull.Value : (object)employees.Emp_RetireDate.ToString("yyyy-MM-dd"));
                sql.Parameters.AddWithValue("@Fst_Writer", Global.employees.Emp_Code);
                sql.Parameters.AddWithValue("@Emp_Addbutton", employees.Emp_Addbutton);
                sql.Parameters.AddWithValue("@Emp_Updatebutton", employees.Emp_Updatebutton);
                sql.Parameters.AddWithValue("@Emp_Deletebutton", employees.Emp_Deletebutton);

                sql.ExecuteNonQuery();

                return Convert.ToBoolean(sqlParameter.Value);
            }
            catch (Exception err)
            {
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 직원 정보 입력 오류 : | SP_InsertEmployees " + err.Message, err);
                return false;
            }

        }

        #endregion

        #region 직원 수정및 권한 변경
        public bool UpdateEmployees(EmployeesVO employees, List<string> team)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "UpdateEmployees",
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                DataTable tvp = new DataTable();
                tvp.Columns.Add(new DataColumn("Code", typeof(string)));

                foreach (var code in team)
                    tvp.Rows.Add(code);
                SqlParameter sqlParameter = new SqlParameter();
                sqlParameter.Direction = ParameterDirection.ReturnValue;
                sql.Parameters.Add(sqlParameter);
                SqlParameter tvparam = sql.Parameters.AddWithValue("@List", tvp);
                tvparam.SqlDbType = SqlDbType.Structured;
                tvparam.TypeName = "CodeList";
                sql.Parameters.AddWithValue("@Code", employees.Emp_Code);
                sql.Parameters.AddWithValue("@Name", employees.Emp_Name);
                sql.Parameters.AddWithValue("@Email", employees.Emp_Email);
                sql.Parameters.AddWithValue("@PostCode", employees.Emp_PostCode);
                sql.Parameters.AddWithValue("@Addr", employees.Emp_Addr);
                sql.Parameters.AddWithValue("@AddrDetail", employees.Emp_AddrDetail);
                sql.Parameters.AddWithValue("@Pwd", employees.Emp_Pwd);
                sql.Parameters.AddWithValue("@Phone", employees.Emp_Phone == null ? DBNull.Value : (object)employees.Emp_Phone);
                sql.Parameters.AddWithValue("@HireDate", employees.Emp_HireDate.ToString("yyyy-MM-dd"));
                sql.Parameters.AddWithValue("@RetireDate", employees.Emp_RetireDate.Year == 1 ? DBNull.Value : (object)employees.Emp_RetireDate.ToString("yyyy-MM-dd"));
                sql.Parameters.AddWithValue("@Fst_Writer", Global.employees.Emp_Code);
                sql.Parameters.AddWithValue("@Emp_Addbutton", employees.Emp_Addbutton);
                sql.Parameters.AddWithValue("@Emp_Updatebutton", employees.Emp_Updatebutton);
                sql.Parameters.AddWithValue("@Emp_Deletebutton", employees.Emp_Deletebutton);

                sql.ExecuteNonQuery();
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 직원 정보 수정 : | UpdateEmployees " + employees.Emp_Code);
                return Convert.ToBoolean(sqlParameter.Value);
            }
            catch (Exception err)
            {
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 직원 정보 수정 오류 : | UpdateEmployees " + err.Message, err);
                return false;
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
