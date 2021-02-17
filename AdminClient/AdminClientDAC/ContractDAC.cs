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

		#region 수주관리 (ContractInfo)
		/// <summary>
		/// 검색조건에 따른 수주목록 불러오기
		/// </summary>
		/// <param name="limit"></param>
		/// <param name="confirm"></param>
		/// <param name="fin"></param>
		/// <param name="fdate"></param>
		/// <param name="tdate"></param>
		/// <param name="comp"></param>
		/// <param name="destination"></param>
		/// <returns></returns>
		public List<ContractVO> GetContractsList(string limit, string confirm, string fin, string fdate, string tdate, string comp, string destination)
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = @"select top(CONVERT(int, @limit)) C.Contract_Code, C.Comp_Code, CO.Comp_Name, C.Contract_Destination, CD.Prod_Code, P.Prod_Name, 
																	 C.Contract_DueDate, CD.Contract_Count, CD.Contract_ShippingCount, CD.Contract_CancelCount,
																	 C.Contract_Confirm, C.Contract_Finish
										  from Contract C, ContractDetail CD, CompanyInfo CO, Product P
										 where C.Contract_Code = CD.Contract_Code
										   and C.Comp_Code = CO.Comp_Code
										   and CD.Prod_Code = P.Prod_Code
										   and C.Contract_Confirm = ISNULL(@Contract_Confirm, C.Contract_Confirm)
										   and C.Contract_Finish = ISNULL(@Contract_Finish, C.Contract_Finish)
										   and C.Contract_DueDate >= @fdate
										   and C.Contract_DueDate <= @tdate
										   and C.Comp_Code = ISNULL(@Comp_Code, C.Comp_Code)
										   and C.Contract_Destination = ISNULL(@Contract_Destination, C.Contract_Destination)";

					cmd.Parameters.AddWithValue("@limit", string.IsNullOrEmpty(limit) ? 100000 : (object)limit);
					cmd.Parameters.AddWithValue("@Contract_Confirm", string.IsNullOrEmpty(confirm) ? DBNull.Value : (object)confirm);
					cmd.Parameters.AddWithValue("@Contract_Finish", string.IsNullOrEmpty(fin) ? DBNull.Value : (object)fin);
					cmd.Parameters.AddWithValue("@fdate", string.IsNullOrEmpty(fdate) ? DBNull.Value : (object)fdate);
					cmd.Parameters.AddWithValue("@tdate", string.IsNullOrEmpty(tdate) ? DBNull.Value : (object)tdate);
					cmd.Parameters.AddWithValue("@Comp_Code", string.IsNullOrEmpty(comp) ? DBNull.Value : (object)comp);
					cmd.Parameters.AddWithValue("@Contract_Destination", string.IsNullOrEmpty(destination) ? DBNull.Value : (object)destination);

					List<ContractVO> list = Helper.DataReaderMapToList<ContractVO>(cmd.ExecuteReader());

					return list;
				}
			}
			catch (Exception err)
			{
				Info.WriteError($"실행자:{Global.employees.Emp_Name} 수주정보 검색중 오류 :" + err.Message, err);
				return null;
			}
		}


		public List<ContractVO> RefreshContractsList()
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = @"select C.Contract_Code, C.Comp_Code, CO.Comp_Name, C.Contract_Destination, CD.Prod_Code, P.Prod_Name, 
											   C.Contract_DueDate, CD.Contract_Count, CD.Contract_ShippingCount, CD.Contract_CancelCount,
											   C.Contract_Confirm, C.Contract_Finish
										  from Contract C, ContractDetail CD, CompanyInfo CO, Product P
										 where C.Contract_Code = CD.Contract_Code
										   and C.Comp_Code = CO.Comp_Code
									       and CD.Prod_Code = P.Prod_Code; ";

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

		/// <summary>
		/// 수주정보 수정, 프로시져 이용
		/// </summary>
		/// <param name="userID"></param>
		/// <param name="vo"></param>
		/// <returns>성공 : true, 실패 : false </returns>
		public bool UpdateContract(string userID, ContractVO vo)
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = "SP_UpdateContract";
					cmd.CommandType = CommandType.StoredProcedure;

					cmd.Parameters.AddWithValue("@contcode", vo.Contract_Code);
					cmd.Parameters.AddWithValue("@uid", userID);
					cmd.Parameters.AddWithValue("@compcode", vo.Comp_Code);
					cmd.Parameters.AddWithValue("@destination", vo.Contract_Destination);
					cmd.Parameters.AddWithValue("@duedate", vo.Contract_DueDate);
					cmd.Parameters.AddWithValue("@note", vo.Contract_Note);
					cmd.Parameters.AddWithValue("@prodcode", vo.Prod_Code);
					cmd.Parameters.AddWithValue("@count", vo.Contract_Count);
					cmd.Parameters.AddWithValue("@cancel", vo.Contract_CancelCount);

					int iAffectedRow = cmd.ExecuteNonQuery();

					if (iAffectedRow > 0)
						return true;
					else
						throw new Exception();
				}
			}
			catch (Exception err)
			{
				Info.WriteError($"실행자:{Global.employees.Emp_Name} 수주정보 수정중 오류 :" + err.Message, err);
				return false;
			}
		}

		/// <summary>
		/// 수주정보 삭제
		/// </summary>
		/// <param name="contcode"></param>
		/// <param name="prodcode"></param>
		/// <returns>성공 : true, 실패 : false  </returns>
		public bool DeleteContract(string contcode, string prodcode)
		{
			SqlTransaction tran = conn.BeginTransaction();
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.Transaction = tran;

					cmd.CommandText = @"delete from Contract 
										 where Contract_Code = @contcode;

										delete from ContractDetail 
										 where Contract_Code = @contcode
										   and Prod_Code = @prodcode; ";
					cmd.Parameters.AddWithValue("@contcode", contcode);
					cmd.Parameters.AddWithValue("@prodcode", prodcode);


					int iAffectedRow = cmd.ExecuteNonQuery();

					if (iAffectedRow > 0)
					{
						tran.Commit();
						return true;
					}
					else
						throw new Exception();
				}
			}
			catch (Exception err)
			{
				Info.WriteError($"실행자:{Global.employees.Emp_Name} 수주정보 삭제중 오류 :" + err.Message, err);
				tran.Rollback();
				return false;
			}
		}

		/// <summary>
		/// 생산계획을 생성하기위해 수주확정여부를 업데이트
		/// </summary>
		/// <param name="userID"></param>
		/// <param name="contcode"></param>
		/// <returns> 성공 : true, 실패 : false </returns>
		public bool CreateProduction(string userID, string contcode, string contDate)
		{
			SqlTransaction trans = conn.BeginTransaction();
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = @"SP_SetContract";
					cmd.CommandType = CommandType.StoredProcedure;
					
					cmd.Parameters.AddWithValue("@contcode", contcode);
					cmd.Parameters.AddWithValue("@uid", userID);

					cmd.Transaction = trans;

					int iAffectedRow = cmd.ExecuteNonQuery();

					if (iAffectedRow > 0)
					{
						cmd.Parameters.Clear();
						cmd.CommandText = "SP_SetBalance";
						cmd.Parameters.AddWithValue("@setDate", contDate);

						cmd.ExecuteNonQuery();
					}

					trans.Commit();
					return true;
				}
			}
			catch (Exception err)
			{
				trans.Rollback();

				Info.WriteError($"실행자:{Global.employees.Emp_Name} 수주확정여부 수정중 오류 :" + err.Message, err);

				return false;
			}
		}
		#endregion

		#region 출하지시 (Shipment)
		public List<ShipmentVO> RefreshShipList()
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = @"select C.Contract_Code, C.Contract_DueDate, C.Comp_Code, CO.Comp_Name, C.Contract_Destination, 
											   CD.Prod_Code, P.Prod_Name, WH.WH_PsyCount, 
											   CD.Contract_Count, CD.Contract_ShippingCount, CD.Contract_CancelCount,
											   C.Contract_Confirm, C.Contract_Finish
										  from Contract C, ContractDetail CD, CompanyInfo CO, Product P, WareHouseDetail WH
										 where C.Contract_Code = CD.Contract_Code
										   and C.Comp_Code = CO.Comp_Code
										   and CD.Prod_Code = P.Prod_Code 
										   and P.Prod_Code = WH.Prod_Code
										   and C.Contract_Confirm = 'Y'; ";

					List<ShipmentVO> list = Helper.DataReaderMapToList<ShipmentVO>(cmd.ExecuteReader());

					return list;
				}
			}
			catch (Exception err)
			{
				Info.WriteError($"실행자:{Global.employees.Emp_Name} 출하수주목록 새로고침중 오류 :" + err.Message, err);
				return null;
			}
		}
		public List<ShipmentVO> GetShipList(string limit, string fdate, string tdate, string comp, string finish)
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = @"select top(CONVERT(int, @limit)) C.Contract_Code, C.Contract_DueDate, C.Comp_Code, CO.Comp_Name, C.Contract_Destination, 
																		 CD.Prod_Code, P.Prod_Name, WH.WH_PsyCount, 
																		 CD.Contract_Count, CD.Contract_ShippingCount, CD.Contract_CancelCount,
																		 C.Contract_Confirm, C.Contract_Finish
										  from Contract C, ContractDetail CD, CompanyInfo CO, Product P, WareHouseDetail WH
										 where C.Contract_Code = CD.Contract_Code
										   and C.Comp_Code = CO.Comp_Code
										   and CD.Prod_Code = P.Prod_Code 
										   and P.Prod_Code = WH.Prod_Code
										   and C.Contract_Confirm = 'Y'
										   and C.Contract_DueDate >= @fdate
										   and C.Contract_DueDate <= @tdate
										   and C.Comp_Code = ISNULL(@Comp_Code, C.Comp_Code)
										   and C.Contract_Finish = ISNULL(@Contract_Finish, C.Contract_Finish); ";

					cmd.Parameters.AddWithValue("@limit", string.IsNullOrEmpty(limit) ? 100000 : (object)limit);
					cmd.Parameters.AddWithValue("@fdate", string.IsNullOrEmpty(fdate) ? DBNull.Value : (object)fdate);
					cmd.Parameters.AddWithValue("@tdate", string.IsNullOrEmpty(tdate) ? DBNull.Value : (object)tdate);
					cmd.Parameters.AddWithValue("@Comp_Code", string.IsNullOrEmpty(comp) ? DBNull.Value : (object)comp);
					cmd.Parameters.AddWithValue("@Contract_Finish", string.IsNullOrEmpty(finish) ? DBNull.Value : (object)finish);

					List<ShipmentVO> list = Helper.DataReaderMapToList<ShipmentVO>(cmd.ExecuteReader());

					return list;
				}
			}
			catch (Exception err)
			{
				Info.WriteError($"실행자:{Global.employees.Emp_Name} 출하수주목록 검색중 오류 :" + err.Message, err);
				return null;
			}
		}

		public bool Shipping(string userID, ShipmentVO vo)
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = "SP_Shipping";
					cmd.CommandType = CommandType.StoredProcedure;

					cmd.Parameters.AddWithValue("@count", vo.Contract_ShippingCount);
					cmd.Parameters.AddWithValue("@contcode", vo.Contract_Code);
					cmd.Parameters.AddWithValue("@prodcode", vo.Prod_Code);
					cmd.Parameters.AddWithValue("@uid", userID);

					int iAffectedRow = cmd.ExecuteNonQuery();

					if (iAffectedRow > 0)
						return true;
					else
						throw new Exception();
				}
			}
			catch (Exception err)
			{
				Info.WriteError($"실행자:{Global.employees.Emp_Name} 출하 지시중 오류 :" + err.Message, err);
				return false;
			}
		}
		#endregion
	}
}
