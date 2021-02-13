using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminClientDAC;
using AdminClientVO;

namespace AdminClient.Service
{
	public class ProductionService : IDisposable
	{
		ProductionDAC dac;
		public ProductionService()
		{
			dac = new ProductionDAC();
		}
		public void Dispose()
		{
			dac.Dispose();
		}

		public List<ContractVO> GetConfirmedContractsList()
		{
			return dac.GetConfirmedContractsList();
		}
	}
}
