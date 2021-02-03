using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient.Service
{
	public class ComboBindingService : IDisposable
	{
		ComboBindingDAC dac;
		public ComboBindingService()
		{
			dac = new ComboBindingDAC();
		}

		public List<ComboCompNameVO> BindingCompName()
		{
			return dac.BindingCompName();
		}

		public List<ComboProdNameVO> BindingProdName()
		{
			return dac.BindingProdName();
		}

		public void Dispose()
		{
			dac.Dispose();
		}
	}
}
