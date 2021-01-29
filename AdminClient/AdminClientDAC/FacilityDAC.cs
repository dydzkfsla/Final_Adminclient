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

		/// <summary>
		/// 검색조건에 따른 설비군 목록 불러오기
		/// </summary>
		/// <param name="limit">검색제한수</param>
		/// <param name="enable">설비군 사용여부</param>
		/// <returns>성공 : 설비군목록 List, 실패 : null </returns>
		public List<FacilityGroupVO> GetFacilityGroupList(string limit, string enable)
		{
			try
			{
				using(SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = @"select top(CONVERT(int, @limit)) FacGrp_Code, FacGrp_Name, FacGrp_Enable ,FacGrp_Description
										  from FacilityGroup
										 where FacGrp_Enable = isnull(@enable, FacGrp_Enable)";
					cmd.Parameters.AddWithValue("@limit", string.IsNullOrEmpty(limit) ? 100000 : (object)limit);
					cmd.Parameters.AddWithValue("@enable", string.IsNullOrEmpty(enable) ? DBNull.Value : (object)enable);

					List<FacilityGroupVO> list = Helper.DataReaderMapToList<FacilityGroupVO>(cmd.ExecuteReader());

					return list;
				}
			}
			catch(Exception err)
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
				using(SqlCommand cmd = new SqlCommand())
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
			catch(Exception err)
			{
				Info.WriteError($"실행자: {Global.employees.Emp_Name} 설비군 신규등록중 오류 : " + err.Message, err);
				return false;
			}
		}

		public void Dispose()
		{
			conn.Dispose();
		}
	}
}
