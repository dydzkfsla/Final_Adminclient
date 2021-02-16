using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
	public class ProcessVO
	{
		public string Pcs_Code { get; set; }
		public string Pcs_Name { get; set; }
		public string Pcs_State { get; set; }
		public string Fst_Writer { get; set; }
		public string Fst_WriteDate { get; set; }
		public string Lst_Writer { get; set; }
		public string Lst_WriteDate { get; set; }
	}
	public class ProcessDetailVO
	{
		public string Pcs_Code { get; set; }
		public string PcsD_Code { get; set; }
		public string PcsD_Name { get; set; }
		public string PcsD_State { get; set; }
		public string Fst_Writer { get; set; }
		public string Fst_WriteDate { get; set; }
		public string Lst_Writer { get; set; }
		public string Lst_WriteDate { get; set; }

	}
}
