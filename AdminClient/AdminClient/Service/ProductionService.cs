using System;
using System.Collections.Generic;
using System.Data;
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

		public List<ContractVO> GetQtyByDueDate(string from, string to, string limit)
		{
			List<ContractVO> list = dac.GetQtyByDueDate(from, to, limit);
			dac.Dispose();
			return list;
		}

		public List<ContractVO> GetConfirmedContractsList(string duedate)
		{
			List<ContractVO> list = dac.GetConfirmedContractsList(duedate);
			dac.Dispose();
			return list;
		}

        internal DataTable GetPlan(string from, string to)
        {
			DataTable dt = dac.GetPlan(from, to);
			dac.Dispose();
			return dt;
        }

        internal bool SetWorkOrder()
        {
			bool result = dac.SetWorkOrder();
			dac.Dispose();
			return result;
        }
    }
}
