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
	public class ProductionDAC : IDisposable
	{
		SqlConnection conn;
		LoggingUtility Info;

		public ProductionDAC()
		{
			conn = new SqlConnection(Connstring.conn);
			conn.Open();
			Info = new LoggingUtility("ProductionDACInfo", "ProductionDACError", Level.All, 30);
			Info.InfoFolder = "C:\\FP\\Log\\ProductionDAC\\Info";
			Info.ErrorFolder = "C:\\FP\\Log\\ProductionDAC\\Error";
		}

		public void Dispose()
		{
			conn.Dispose();
		}

		public List<ContractVO> GetConfirmedContractsList()
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = @"select C.Contract_Code, C.Comp_Code, CO.Comp_Name, C.Contract_Destination, CD.Prod_Code, P.Prod_Name, 
									  		   C.Contract_DueDate, CD.Contract_Count, CD.Contract_ShippingCount, CD.Contract_CancelCount
										  from Contract C, ContractDetail CD, CompanyInfo CO, Product P
										 where C.Contract_Code = CD.Contract_Code
										   and C.Comp_Code = CO.Comp_Code
										   and CD.Prod_Code = P.Prod_Code
									       and C.Contract_Confirm = 'Y'; ";

					List<ContractVO> list = Helper.DataReaderMapToList<ContractVO>(cmd.ExecuteReader());

					return list;
				}
			}
			catch (Exception err)
			{
				Info.WriteError($"실행자:{Global.employees.Emp_Name} 수주목록 새로고침중 오류 :" + err.Message, err);
				return null;
			}
		}
	}
}
