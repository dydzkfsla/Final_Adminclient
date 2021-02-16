using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
	public class ContractVO
	{
		public string Contract_Code { get; set; }
		public string Comp_Name { get; set; }
		public string Comp_Code { get; set; }
		public string Contract_Destination { get; set; }
		public DateTime Contract_DueDate { get; set; }
		public string Contract_Confirm { get; set; }
		public string Contract_Finish { get; set; }
		public string Contract_Note { get; set; }
		public string Prod_Code { get; set; }
		public string Prod_Name { get; set; }
		public int Contract_Count { get; set; }
		public int Contract_ShippingCount { get; set; }
		public int Contract_CancelCount { get; set; }
		public string Fst_Writer { get; set; }
		public DateTime Fst_WriteDate { get; set; }
		public string Lst_Writer { get; set; }
		public DateTime Lst_WriteDate { get; set; }
	}
	public class ShipmentVO
	{
		public string Contract_Code { get; set; }
		public DateTime Contract_DueDate { get; set; }
		public string Comp_Code { get; set; }
		public string Comp_Name { get; set; }
		public string Contract_Destination { get; set; }
		public string Contract_Confirm { get; set; }
		public string Contract_Finish { get; set; }
		public string Contract_Note { get; set; }
		public string Prod_Code { get; set; }
		public string Prod_Name { get; set; }
		public decimal WH_PsyCount { get; set; }
		public int Contract_Count { get; set; }
		public int Contract_ShippingCount { get; set; }
		public int Contract_CancelCount { get; set; }
		public string Fst_Writer { get; set; }
		public DateTime Fst_WriteDate { get; set; }
		public string Lst_Writer { get; set; }
		public DateTime Lst_WriteDate { get; set; }
	}
}
