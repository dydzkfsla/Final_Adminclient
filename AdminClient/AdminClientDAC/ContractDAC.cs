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

		//public List<ContractVO> 


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
						return false;
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
