using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
	public class ComboCompNameVO
	{
		public string Comp_Code { get; set; }
		public string Comp_Name { get; set; }
	}

	public class ComboProdNameVO
	{
		public string Prod_Code { get; set; }
		public string Prod_Name { get; set; }
	}

	public class ComboFgrpNameVO
	{
		public string FacGrp_Code { get; set; }
		public string FacGrp_Name { get; set; }
	}

	public class ComboWHNameVO
	{
		public string WH_Code { get; set; }
		public string WH_Name { get; set; }
	}

	public class ComboDestVO
	{
		public string Contract_Destination { get; set; }
	}
}
