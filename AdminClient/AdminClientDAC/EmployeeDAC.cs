using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminClientVO;

namespace AdminClientDAC
{
	public class EmployeeDAC : IDisposable
	{
		SqlConnection conn;

		public EmployeeDAC()
		{
			conn = new SqlConnection(Connstring.conn);
			conn.Open();
		}

		#region SELECT

		#region 로그인
		/// <summary>
		/// 관리자폼 직원 로그인
		/// </summary>
		/// <param name="id">직원코드</param>
		/// <param name="pwd">비밀번호</param>
		/// <returns>로그인성공 : 직원정보객체 EmployeesVO, 로그인실패 : null</returns>
		public EmployeesVO EmpLogin(string id, string pwd)
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = @"select Emp_Code, Emp_Name, Emp_HireDate, Emp_RetireDate, Emp_Phone, Emp_Email, Emp_PostCode, Emp_Addr, Emp_AddrDetail, Emp_Pwd, Emp_Addbutton, Emp_Updatebutton,Emp_Deletebutton
									  from Employees
									 where Emp_Code = @Emp_Code
									   and Emp_Pwd = @Emp_Pwd";
					cmd.Parameters.AddWithValue("@Emp_Code", id);
					cmd.Parameters.AddWithValue("@Emp_Pwd", pwd);

					List<EmployeesVO> login = Helper.DataReaderMapToList<EmployeesVO>(cmd.ExecuteReader());

					return login[0];

					//SqlDataReader reader = cmd.ExecuteReader();



					//if (reader.Read())
					//{
					//	EmployeesVO login = new EmployeesVO()
					//	{
					//		Emp_Code = reader["Emp_Code"].ToString(),
					//		Emp_Name = reader["Emp_Name"].ToString(),
					//		Emp_HireDate = Convert.ToDateTime(reader["Emp_HireDate"]),
					//		Emp_RetireDate = Convert.ToDateTime(reader["Emp_RetireDate"]),
					//		Emp_Phone = reader["Emp_Phone"].ToString(),
					//		Emp_Email = reader["Emp_Email"].ToString(),
					//		Emp_PostCode = Convert.ToInt32(reader["Emp_PostCode"]),
					//		Emp_Addr = reader["Emp_Addr"].ToString(),
					//		Emp_AddrDetail = reader["Emp_AddrDetail"].ToString(),
					//		Emp_Pwd = reader["Emp_Pwd"].ToString()
					//	};
					//	return login;
					//}
					//else
					//	return null;
					

				}
			}
			catch
			{
				return null;
			}
		}
		#endregion

		#endregion

		public void Dispose()
		{
			conn.Dispose();
		}
	}
}
