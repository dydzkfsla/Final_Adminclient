using AdminClientVO;
using log4net.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientDAC
{
	public class ContractDAC : IDisposable
	{
		SqlConnection conn;
		LoggingUtility Info;

		public ContractDAC()
		{
			conn = new SqlConnection(Connstring.conn);
			conn.Open();
			Info = new LoggingUtility("FacilityDACInfo", "FacilityDACError", Level.All, 30);
			Info.InfoFolder = "C:\\FP\\Log\\FacilityDAC\\Info";
			Info.ErrorFolder = "C:\\FP\\Log\\FacilityDAC\\Error";
		}

		public void Dispose()
		{
			conn.Dispose();
		}

		//public List<ContractVO> GetContractsList(string limit, string confirm, string fin, string fdate, string tdate, string contcode, string prodname, string comp, string destination)
		//{
		//	try
		//	{
		//		using(SqlCommand cmd = new SqlCommand())
		//		{
		//			cmd.Connection = conn;
		//			cmd.CommandText = @"select top(CONVERT(int, 20)) C.Contract_Code, C.Comp_Code, CO.Comp_Name, C.Contract_Destination, CD.Prod_Code, P.Prod_Name, 
		//															 C.Contract_DueDate, CD.Contract_Count, CD.Contract_ShippingCount, CD.Contract_CancelCount,
		//															 C.Contract_Confirm, C.Contract_Finish
		//								  from Contract C, ContractDetail CD, CompanyInfo CO, Product P
		//								 where C.Contract_Code = CD.Contract_Code
		//								   and C.Comp_Code = CO.Comp_Code
		//								   and CD.Prod_Code = P.Prod_Code
		//								   and C.Contract_Confirm = ISNULL(@Contract_Confirm, C.Contract_Confirm)
		//								   and C.Contract_Finish = ISNULL(@Contract_Finish, C.Contract_Finish)
		//								   and C.Contract_DueDate >= @fdate
		//								   and C.Contract_DueDate <= @tdate
		//								   and C.Contract_Code = ISNULL(@Contract_Code, C.Contract_Code)
		//								   and P.Prod_Name = ISNULL(@Prod_Name, CD.Prod_Code)
		//								   and C.Comp_Code = ISNULL(@Comp_Code, C.Comp_Code)
		//								   and C.Contract_Destination = ISNULL(@Contract_Destination, C.Contract_Destination)";
		//		}
		//	}
		//	catch(Exception err)
		//	{
		//		Info.WriteError($"실행자:{Global.employees.Emp_Name} 수주정보 검색중 오류 :" + err.Message, err);
		//		return null;
		//	}
		//}


		/// <summary>
		/// 신규 수주정보 등록, 프로시져 이용
		/// </summary>
		/// <param name="userID">입력자</param>
		/// <param name="vo">수주정보 객체</param>
		/// <returns>성공 : true, 실패 : false </returns>
		public bool AddContract(string userID, ContractVO vo)
		{
			try
			{
				using(SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = "SP_AddContract";
					cmd.CommandType = CommandType.StoredProcedure;

					cmd.Parameters.AddWithValue("@uid", userID);
					cmd.Parameters.AddWithValue("@compcode", vo.Comp_Code);
					cmd.Parameters.AddWithValue("@destination", vo.Contract_Destination);
					cmd.Parameters.AddWithValue("@duedate", vo.Contract_DueDate);
					cmd.Parameters.AddWithValue("@note", vo.Contract_Note);
					cmd.Parameters.AddWithValue("@prodcode", vo.Prod_Code);
					cmd.Parameters.AddWithValue("@count", vo.Contract_Count);

					int iAffectedRow = cmd.ExecuteNonQuery();

					if (iAffectedRow > 0)
						return true;
					else
						throw new Exception();
				}
			}
			catch (Exception err)
			{
				Info.WriteError($"실행자:{Global.employees.Emp_Name} 새 수주정보 입력중 오류 :" + err.Message, err);
				return false;
			}
		}


	}
}
