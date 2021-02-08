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

		public List<FacilityGroupVO> GetFacilityGroupList(string limit, string enable)
		{
			return dac.GetFacilityGroupList(limit, enable);
		}

		public List<FacilityVO> GetFacilityList(string limit, string fgrp, string enable, string outsourcing)
		{
			return dac.GetFacilityList(limit, fgrp, enable, outsourcing);
		}

		public bool AddFacilityGroup(string userID, FacilityGroupVO vo)
		{
			return dac.AddFacilityGroup(userID, vo);
		}

		public bool AddFacility(string userID, FacilityVO vo)
		{
			return dac.AddFacility(userID, vo);
		}

		public void Dispose()
		{
			dac.Dispose();
		}
	}
}
