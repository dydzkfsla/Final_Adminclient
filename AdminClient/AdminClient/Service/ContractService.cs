using AdminClientDAC;
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

		public List<ContractVO> GetContractsList(string limit, string confirm, string fin, string fdate, string tdate, string comp, string destination)
		{
			return dac.GetContractsList(limit, confirm, fin, fdate, tdate, comp, destination);
		}

		public void Dispose()
		{
			dac.Dispose();
		}
	}
}
