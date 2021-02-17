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
	public class ProcessDAC : IDisposable
	{
		SqlConnection conn;
		LoggingUtility Info;
		public ProcessDAC()
		{
			conn = new SqlConnection(Connstring.conn);
			conn.Open();
			Info = new LoggingUtility("ProcessDACInfo", "ProcessDACError", Level.All, 30);
			Info.InfoFolder = "C:\\FP\\Log\\ProcessDAC\\Info";
			Info.ErrorFolder = "C:\\FP\\Log\\ProcessDAC\\Error";
		}
		public void Dispose()
		{
			conn.Dispose();
		}
		public List<ProcessVO> GetPcsList(string limit, string state)
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = @"select top(CONVERT(int, @limit)) Pcs_Code, Pcs_Name, Pcs_State
										  from ProcessInfo
										 where Pcs_State = ISNULL(@state, Pcs_State)";

					cmd.Parameters.AddWithValue("@limit", string.IsNullOrEmpty(limit) ? 100000 : (object)limit);
					cmd.Parameters.AddWithValue("@state", string.IsNullOrEmpty(state) ? DBNull.Value : (object)state);

					List<ProcessVO> list = Helper.DataReaderMapToList<ProcessVO>(cmd.ExecuteReader());

					return list;
				}
			}
			catch (Exception err)
			{
				Info.WriteError($"실행자:{Global.employees.Emp_Name} 공정정보 검색중 오류 :" + err.Message, err);
				return null;
			}
		}
		public List<ProcessDetailVO> GetPDList(string code)
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = @"select Pcs_Code, PcsD_Code, PcsD_Name, PcsD_State
										  from ProcessDetail
										 where Pcs_Code = @code
										   and PcsD_State = 'Y'; ";

					cmd.Parameters.AddWithValue("@code", string.IsNullOrEmpty(code) ? 100000 : (object)code);
					//cmd.Parameters.AddWithValue("@state", string.IsNullOrEmpty(state) ? DBNull.Value : (object)state);

					List<ProcessDetailVO> list = Helper.DataReaderMapToList<ProcessDetailVO>(cmd.ExecuteReader());

					return list;
				}
			}
			catch (Exception err)
			{
				Info.WriteError($"실행자:{Global.employees.Emp_Name} 세부공정정보 검색중 오류 :" + err.Message, err);
				return null;
			}
		}
		public List<ProcessVO> RefreshPcsList()
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = @"select Pcs_Code, Pcs_Name, Pcs_State from ProcessInfo; ";

					List<ProcessVO> list = Helper.DataReaderMapToList<ProcessVO>(cmd.ExecuteReader());

					return list;
				}
			}
			catch (Exception err)
			{
				Info.WriteError($"실행자:{Global.employees.Emp_Name} 공정목록 새로고침중 오류 :" + err.Message, err);
				return null;
			}
		}
		public bool AddProcess(string userID, ProcessVO vo)
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = "SP_AddProcess";
					cmd.CommandType = CommandType.StoredProcedure;

					cmd.Parameters.AddWithValue("@name", vo.Pcs_Name);
					cmd.Parameters.AddWithValue("@state", vo.Pcs_State);
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
				Info.WriteError($"실행자:{Global.employees.Emp_Name} 새 공정정보 입력중 오류 :" + err.Message, err);
				return false;
			}
		}
		public bool AddProcessDetil(string userID, ProcessDetailVO vo)
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = "SP_AddProcessDetail";
					cmd.CommandType = CommandType.StoredProcedure;

					cmd.Parameters.AddWithValue("@pcscode", vo.Pcs_Code);
					cmd.Parameters.AddWithValue("@name", vo.PcsD_Name);
					cmd.Parameters.AddWithValue("@state", vo.PcsD_State);
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
				Info.WriteError($"실행자:{Global.employees.Emp_Name} 새 세부공정정보 입력중 오류 :" + err.Message, err);
				return false;
			}
		}
		public bool UpdateProcess(string userID, ProcessVO vo)
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = @"update ProcessInfo
										   set Pcs_Name = @name,
											   Pcs_State = @state,
											   Lst_Writer = @uid,
											   Lst_WriteDate = GETDATE()
										 where Pcs_Code = @code; ";

					cmd.Parameters.AddWithValue("@code", vo.Pcs_Code);
					cmd.Parameters.AddWithValue("@name", vo.Pcs_Name);
					cmd.Parameters.AddWithValue("@state", vo.Pcs_State);
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
				Info.WriteError($"실행자:{Global.employees.Emp_Name} 공정정보 수정중 오류 :" + err.Message, err);
				return false;
			}
		}
		public bool UpdateProcessDetail(string userID, ProcessDetailVO vo)
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = @"update ProcessDetail
										   set PcsD_Name = @name,
											   PscD_State = @state,
											   Lst_Writer = @uid,
											   Lst_WriteDate = GETDATE()
										 where Pcs_Code = @pcscode
										   and PcsD_Code = @pdcode; ";

					cmd.Parameters.AddWithValue("@pcscode", vo.Pcs_Code);
					cmd.Parameters.AddWithValue("@pdcode", vo.PcsD_Code);
					cmd.Parameters.AddWithValue("@name", vo.PcsD_Name);
					cmd.Parameters.AddWithValue("@state", vo.PcsD_State);
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
				Info.WriteError($"실행자:{Global.employees.Emp_Name} 세부공정정보 수정중 오류 :" + err.Message, err);
				return false;
			}
		}
		public bool DeleteProcess(string userID, string code)
		{
			SqlTransaction tran = conn.BeginTransaction();
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.Transaction = tran;
					cmd.CommandText = @" update ProcessInfo
										    set Pcs_State = 'N',
												Lst_Writer = @uid,
											    Lst_WriteDate = GETDATE()
										  where Pcs_Code = @pcscode
										
										 update ProcessDetail
										    set PscD_State = 'N',
												Lst_Writer = @uid,
											    Lst_WriteDate = GETDATE()
										  where Pcs_Code = @pcscode; ";

					cmd.Parameters.AddWithValue("@uid", userID);
					cmd.Parameters.AddWithValue("@pcscode", code);
					
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
				Info.WriteError($"실행자:{Global.employees.Emp_Name} 공정정보 삭제중 오류 :" + err.Message, err);
				tran.Rollback();
				return false;
			}
		}
		public bool DeleteProcessDetail(string userID, string code)
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = @" update ProcessDetail
										    set PscD_State = 'N',
												Lst_Writer = @uid,
											    Lst_WriteDate = GETDATE()
										  where PcsD_Code = @code; ";

					cmd.Parameters.AddWithValue("@uid", userID);
					cmd.Parameters.AddWithValue("@code", code);

					int iAffectedRow = cmd.ExecuteNonQuery();

					if (iAffectedRow > 0)
					{
						return true;
					}
					else
						throw new Exception();
				}
			}
			catch (Exception err)
			{
				Info.WriteError($"실행자:{Global.employees.Emp_Name} 세부공정정보 삭제중 오류 :" + err.Message, err);
				return false;
			}
		}
	}
}
