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

		public List<ContractVO> GetQtyByDueDate(string from, string to, string limit)
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = @"SP_GetContGrpList";
					cmd.CommandType = System.Data.CommandType.StoredProcedure;

					string fromto = string.Empty;
					if(!(string.IsNullOrEmpty(from) && string.IsNullOrEmpty(to)))
                    {
						DateTime dtfrom, dtto;

						dtfrom = Convert.ToDateTime(from);
						dtto = Convert.ToDateTime(to);


						while (dtfrom.Date <= dtto.Date)
						{
							fromto += "'" + dtfrom.ToString("yyyy-MM-dd") + "'";

							if(dtfrom.Date != dtto.Date)
								fromto += ", ";

							dtfrom = dtfrom.AddDays(1);
						}
                    }



					cmd.Parameters.AddWithValue("@limit", string.IsNullOrEmpty(limit) ? 10000 : int.Parse(limit));
					cmd.Parameters.AddWithValue("@datelist", string.IsNullOrEmpty(fromto) ? DBNull.Value : (object)fromto);

					List<ContractVO> list = Helper.DataReaderMapToList<ContractVO>(cmd.ExecuteReader());

					return list;
				}
			}
			catch (Exception err)
			{
				Info.WriteError($"실행자:{Global.employees.Emp_Name} 총수량 목록 불러오기중 오류 :" + err.Message, err);
				return null;
			}
		}

        public bool SetWorkOrder()
        {
            try
            {
				using(SqlCommand cmd = new SqlCommand())
                {
					cmd.Connection = conn;
					cmd.CommandText = "SP_SetWorkOrder";
					cmd.CommandType = CommandType.StoredProcedure;

					cmd.Parameters.AddWithValue("@empcode", Global.employees.Emp_Code);

					int cnt = cmd.ExecuteNonQuery();

					return cnt > 0 ? true : false;
                }

            }
			catch(Exception err)
            {
				Info.WriteError($"실행자:{Global.employees.Emp_Name} 작업지시생성중 오류 :" + err.Message, err);
				return false;
            }
        }

        public DataTable GetPlan(string from, string to)
        {
			try
			{
				string sql = "SP_GetPlan";
				SqlConnection test = new SqlConnection(Connstring.conn);
				using (SqlDataAdapter da = new SqlDataAdapter(sql, test))
				{
					da.SelectCommand.CommandType = CommandType.StoredProcedure;
					da.SelectCommand.Parameters.AddWithValue("@fst", string.IsNullOrEmpty(from)? DBNull.Value : (object)from);
					da.SelectCommand.Parameters.AddWithValue("@lst", string.IsNullOrEmpty(to) ? DBNull.Value : (object)to);

					DataTable dt = new DataTable();
					da.Fill(dt);

					return dt;

				}
			}
			catch (Exception err)
			{
				Info.WriteError($"실행자:{Global.employees.Emp_Name}  계획 불러오기중 오류 :" + err.Message, err);
				return null;
			}
        }

        public List<ContractVO> GetConfirmedContractsList(string duedate)
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
									       and C.Contract_Confirm = 'Y'
										   and C.Contract_DueDate = @duedate ; ";

					cmd.Parameters.AddWithValue("@duedate", duedate);

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
