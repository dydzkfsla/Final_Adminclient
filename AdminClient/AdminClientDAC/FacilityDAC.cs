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
	public class FacilityDAC : IDisposable
	{
		SqlConnection conn;
		LoggingUtility Info;

		public FacilityDAC()
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

		#region 설비
		public List<FacilityVO> GetFacilityList()
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = @"select Fac_Code, FacGrp_Code, Fac_Name, Fac_Enable, Fac_Outsourcing, Fac_ImgPath, 
											   Fac_MaterialWareHouse, Fac_GoodsWareHouse, Fac_FaultyWareHouse, Fac_Note
										  from Facility
										 where Fac_Enable = 'Y'; ";

					List<FacilityVO> list = Helper.DataReaderMapToList<FacilityVO>(cmd.ExecuteReader());

					return list;
				}
			}
			catch (Exception err)
			{
				Info.WriteError($"실행자: {Global.employees.Emp_Name} 설비목록(1) 불러오기 오류 :" + err.Message, err);
				return null;
			}
		}
		public List<FacilityVO> GetFacilityList(string fgrp)
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = @"select Fac_Code, FacGrp_Code, Fac_Name, Fac_Enable, Fac_Outsourcing, Fac_ImgPath, 
											   Fac_MaterialWareHouse, Fac_GoodsWareHouse, Fac_FaultyWareHouse, Fac_Note
										  from Facility
										 where FacGrp_Code = ISNULL(@fgrp, FacGrp_Code)
										   and Fac_Enable = 'Y'; ";

					cmd.Parameters.AddWithValue("@fgrp", string.IsNullOrEmpty(fgrp) ? DBNull.Value : (object)fgrp);

					List<FacilityVO> list = Helper.DataReaderMapToList<FacilityVO>(cmd.ExecuteReader());

					return list;
				}
			}
			catch (Exception err)
			{
				Info.WriteError($"실행자: {Global.employees.Emp_Name} 설비목록(2) 불러오기 오류 :" + err.Message, err);
				return null;
			}
		}

		/// <summary>
		/// 검색조건에 따른 설비 목록 불러오기
		/// </summary>
		/// <param name="limit"></param>
		/// <param name="enable"></param>
		/// <param name="outsourcing"></param>
		/// <returns></returns>
		public List<FacilityVO> GetFacilityList(string limit, string fgrp, string enable, string outsourcing)
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = @"select top(CONVERT(int, @limit)) Fac_Code, FacGrp_Code, Fac_Name, Fac_Enable, Fac_Outsourcing, Fac_ImgPath, 
																		 Fac_MaterialWareHouse, Fac_GoodsWareHouse, Fac_FaultyWareHouse, Fac_Note
										  from Facility
										 where FacGrp_Code = ISNULL(@fgrp, FacGrp_Code)
										   and Fac_Enable = ISNULL(@enable, Fac_Enable)
										   and Fac_Outsourcing = ISNULL(@outsourcing, Fac_Outsourcing)";

					cmd.Parameters.AddWithValue("@limit", string.IsNullOrEmpty(limit) ? 100000 : (object)limit);
					cmd.Parameters.AddWithValue("@fgrp", string.IsNullOrEmpty(fgrp) ? DBNull.Value : (object)fgrp);
					cmd.Parameters.AddWithValue("@enable", string.IsNullOrEmpty(enable) ? DBNull.Value : (object)enable);
					cmd.Parameters.AddWithValue("@outsourcing", string.IsNullOrEmpty(outsourcing) ? DBNull.Value : (object)outsourcing);

					List<FacilityVO> list = Helper.DataReaderMapToList<FacilityVO>(cmd.ExecuteReader());

					return list;
				}
			}
			catch (Exception err)
			{
				Info.WriteError($"실행자: {Global.employees.Emp_Name} 설비목록(3) 불러오기 오류 :" + err.Message, err);
				return null;
			}
		}

		/// <summary>
		/// 새로운 설비 등록(프로시져)
		/// </summary>
		/// <param name="userID">로그인한 유저</param>
		/// <param name="vo">설비정보 객체</param>
		/// <returns>성공 : true, 실패 : false </returns>
		public bool AddFacility(string userID, FacilityVO vo)
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = "SP_AddFacility";
					cmd.CommandType = CommandType.StoredProcedure;

					cmd.Parameters.AddWithValue("@fgrpcode", vo.FacGrp_Code);
					cmd.Parameters.AddWithValue("@name", vo.Fac_Name);
					cmd.Parameters.AddWithValue("@enable", vo.Fac_Enable);
					cmd.Parameters.AddWithValue("@outsourcing", vo.Fac_Outsourcing);
					cmd.Parameters.AddWithValue("@img", vo.Fac_ImgPath);
					cmd.Parameters.AddWithValue("@mwh", vo.Fac_MaterialWareHouse);
					cmd.Parameters.AddWithValue("@gwh", vo.Fac_GoodsWareHouse);
					cmd.Parameters.AddWithValue("@fwh", vo.Fac_FaultyWareHouse);
					cmd.Parameters.AddWithValue("@note", vo.Fac_Note);
					cmd.Parameters.AddWithValue("@id", userID);

					int iRowAffected = cmd.ExecuteNonQuery();
					if (iRowAffected > 0)
						return true;
					else
						return false;
				}
			}
			catch (Exception err)
			{
				Info.WriteError($"실행자: {Global.employees.Emp_Name} 설비 신규등록중 오류 : " + err.Message, err);
				return false;
			}
		}

		public bool UpdateFacility(string userID, FacilityVO vo)
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = @"update Facility 
										   set Fac_Name = @name,
											   Fac_Enable = @enable,
											   Fac_Outsourcing = @outsourcing,
											   Fac_ImgPath = @img,
											   Fac_MaterialWareHouse = @mwh,
											   Fac_GoodsWareHouse = @gwh,
											   Fac_FaultyWareHouse = @fwh,
											   Fac_Note = @note,
											   Lst_Writer = @id,
											   Lst_WriteDate = GETDATE()
										 where FacGrp_Code = @fgrp
										   and Fac_Code = @code; ";

					cmd.Parameters.AddWithValue("@name", vo.Fac_Name);
					cmd.Parameters.AddWithValue("@enable", vo.Fac_Enable);
					cmd.Parameters.AddWithValue("@outsourcing", vo.Fac_Outsourcing);
					cmd.Parameters.AddWithValue("@img", string.IsNullOrEmpty(vo.Fac_ImgPath) ? DBNull.Value : (object)vo.Fac_ImgPath);
					cmd.Parameters.AddWithValue("@mwh", vo.Fac_MaterialWareHouse);
					cmd.Parameters.AddWithValue("@gwh", vo.Fac_GoodsWareHouse);
					cmd.Parameters.AddWithValue("@fwh", vo.Fac_FaultyWareHouse);
					cmd.Parameters.AddWithValue("@note", vo.Fac_Note);
					cmd.Parameters.AddWithValue("@fgrp", vo.FacGrp_Code);
					cmd.Parameters.AddWithValue("@code", vo.Fac_Code);
					cmd.Parameters.AddWithValue("@id", userID);

					int iRowAffected = cmd.ExecuteNonQuery();
					if (iRowAffected > 0)
						return true;
					else
						return false;
				}
			}
			catch (Exception err)
			{
				Info.WriteError($"실행자: {Global.employees.Emp_Name} 설비 수정중 오류 : " + err.Message, err);
				return false;
			}
		}
		public bool DeleteFacility(string userID, string fgrpCode, string facCode)
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = @"update Facility
										   set Fac_Enable = 'N',
											   Lst_Writer = @id,
											   Lst_WriteDate = GETDATE()
										 where FacGrp_Code = @fgrpCode
										   and Fac_Code = @facCode; ";

					cmd.Parameters.AddWithValue("@id", userID);
					cmd.Parameters.AddWithValue("@fgrpCode", fgrpCode);
					cmd.Parameters.AddWithValue("@facCode", facCode);

					int iRowAffected = cmd.ExecuteNonQuery();
					if (iRowAffected > 0)
						return true;
					else
						return false;
				}
			}
			catch (Exception err)
			{
				Info.WriteError($"실행자: {Global.employees.Emp_Name} 설비 삭제중 오류 : " + err.Message, err);
				return false;
			}
		}
		#endregion

		#region 설비군
		/// <summary>
		/// 검색조건에 따른 설비군 목록 불러오기
		/// </summary>
		/// <param name="limit">검색제한수</param>
		/// <param name="enable">설비군 사용여부</param>
		/// <returns>성공 : 설비군목록 List, 실패 : null </returns>
		public List<FacilityGroupVO> GetFacilityGroupList()
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = @"select FacGrp_Code, FacGrp_Name, FacGrp_Enable ,FacGrp_Description
										  from FacilityGroup 
										 where FacGrp_Enable = 'Y'; ";

					List<FacilityGroupVO> list = Helper.DataReaderMapToList<FacilityGroupVO>(cmd.ExecuteReader());

					return list;
				}
			}
			catch (Exception err)
			{
				Info.WriteError($"실행자: {Global.employees.Emp_Name} 설비군목록 불러오기 오류 :" + err.Message, err);
				return null;
			}
		}

		/// <summary>
		/// 새로운 설비군 등록 (프로시져)
		/// </summary>
		/// <param name="userID">로그인한 유저 ID</param>
		/// <param name="vo">설비군 정보 객체</param>
		/// <returns>성공 : true, 실패 : false </returns>
		public bool AddFacilityGroup(string userID, FacilityGroupVO vo)
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = "SP_NewFacilityGroupAdd";
					cmd.CommandType = CommandType.StoredProcedure;

					cmd.Parameters.AddWithValue("@name", vo.FacGrp_Name);
					cmd.Parameters.AddWithValue("@enable", vo.FacGrp_Enable);
					cmd.Parameters.AddWithValue("@description", vo.FacGrp_Description);
					cmd.Parameters.AddWithValue("@id", userID);

					int iRowAffected = cmd.ExecuteNonQuery();
					if (iRowAffected > 0)
						return true;
					else
						return false;
				}
			}
			catch (Exception err)
			{
				Info.WriteError($"실행자: {Global.employees.Emp_Name} 설비군 신규등록중 오류 : " + err.Message, err);
				return false;
			}
		}
		public bool UpdateFacilityGroup(string userID, FacilityGroupVO vo)
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = @"update FacilityGroup
										   set FacGrp_Name = @name,
											   FacGrp_Enable = @enable,
											   FacGrp_Description = @desc,
											   Lst_Writer = @id,
											   Lst_WriteDate = GETDATE()
										 where FacGrp_Code = @code; ";

					cmd.Parameters.AddWithValue("@name", vo.FacGrp_Name);
					cmd.Parameters.AddWithValue("@enable", vo.FacGrp_Enable);
					cmd.Parameters.AddWithValue("@desc", vo.FacGrp_Description);
					cmd.Parameters.AddWithValue("@id", userID);
					cmd.Parameters.AddWithValue("@code", vo.FacGrp_Code);

					int iRowAffected = cmd.ExecuteNonQuery();
					if (iRowAffected > 0)
						return true;
					else
						return false;
				}
			}
			catch (Exception err)
			{
				Info.WriteError($"실행자: {Global.employees.Emp_Name} 설비군 수정중 오류 : " + err.Message, err);
				return false;
			}
		}
		public bool DeleteFacilityGroup(string userID, string code)
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = @"update FacilityGroup
										   set FacGrp_Enable = 'N',
											   Lst_Writer = @id,
											   Lst_WriteDate = GETDATE()
										 where FacGrp_Code = @code; ";

					cmd.Parameters.AddWithValue("@id", userID);
					cmd.Parameters.AddWithValue("@code", code);

					int iRowAffected = cmd.ExecuteNonQuery();
					if (iRowAffected > 0)
						return true;
					else
						return false;
				}
			}
			catch (Exception err)
			{
				Info.WriteError($"실행자: {Global.employees.Emp_Name} 설비군 삭제중 오류 : " + err.Message, err);
				return false;
			}
		}
		#endregion
	}
}

