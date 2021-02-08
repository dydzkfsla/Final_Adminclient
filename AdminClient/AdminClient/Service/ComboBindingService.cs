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

		public List<ComboCompNameVO> BindingCompNameForContract()
		{
			return dac.BindingCompNameForContract();
		}

		public List<ComboProdNameVO> BindingProdName()
		{
			return dac.BindingProdName();
		}

		public List<ComboFgrpNameVO> BindingFgrpName()
		{
			return dac.BindingFgrpName();
		}

		public List<ComboWHNameVO> BindingWHName()
		{
			return dac.BindingWHName();
		}

		public List<ComboDestVO> BindingDestName()
		{
			return dac.BindingDestName();
		}

		public void Dispose()
		{
			dac.Dispose();
		}
	}
}
