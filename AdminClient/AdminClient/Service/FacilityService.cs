using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminClientDAC;
using AdminClientVO;

namespace AdminClient.Service
{
	public class FacilityService : IDisposable
	{
		FacilityDAC dac;
		public FacilityService()
		{
			dac = new FacilityDAC();
		}
		public void Dispose()
		{
			dac.Dispose();
		}
		#region 설비군
		public List<FacilityGroupVO> GetFacilityGroupList()
		{
			return dac.GetFacilityGroupList();
		}
		public List<FacilityVO> GetFacilityList(string fgrp)
		{
			return dac.GetFacilityList(fgrp);
		}
		public bool AddFacilityGroup(string userID, FacilityGroupVO vo)
		{
			return dac.AddFacilityGroup(userID, vo);
		}
		public bool UpdateFacilityGroup(string userID, FacilityGroupVO vo)
		{
			return dac.UpdateFacilityGroup(userID, vo);
		}
		public bool DeleteFacilityGroup(string userID, string code)
		{
			return dac.DeleteFacilityGroup(userID, code);
		}
		#endregion


		#region 설비
		public List<FacilityVO> GetFacilityList()
		{
			return dac.GetFacilityList();
		}
		public List<FacilityVO> GetFacilityList(string limit, string fgrp, string enable, string outsourcing)
		{
			return dac.GetFacilityList(limit, fgrp, enable, outsourcing);
		}
		public bool AddFacility(string userID, FacilityVO vo)
		{
			return dac.AddFacility(userID, vo);
		}
		public bool UpdateFacility(string userID, FacilityVO vo)
		{
			return dac.UpdateFacility(userID, vo);
		}
		public bool DeleteFacility(string userID, string fgrpCode, string facCode)
		{
			return dac.DeleteFacility(userID, fgrpCode, facCode);
		}
		#endregion
	}
}
