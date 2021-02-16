﻿using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient.Service
{
	public class ContractService : IDisposable
	{
		ContractDAC dac;
		public ContractService()
		{
			dac = new ContractDAC();
		}

		public bool AddContract(string userID, ContractVO vo)
		{
			return dac.AddContract(userID, vo);
		}

		public bool UpdateContract(string userID, ContractVO vo)
		{
			return dac.UpdateContract(userID, vo);
		}

		public bool CreateProduction(string userID, string contcode, string contDate)
		{
			return dac.CreateProduction(userID, contcode, contDate);
		}

		public bool DeleteContract(string contcode, string prodcode)
		{
			return dac.DeleteContract(contcode, prodcode);
		}

		public List<ContractVO> GetContractsList(string limit, string confirm, string fin, string fdate, string tdate, string comp, string destination)
		{
			return dac.GetContractsList(limit, confirm, fin, fdate, tdate, comp, destination);
		}

		public List<ContractVO> RefreshContractsList()
		{
			return dac.RefreshContractsList();
		}
		public void Dispose()
		{
			dac.Dispose();
		}
	}
}
