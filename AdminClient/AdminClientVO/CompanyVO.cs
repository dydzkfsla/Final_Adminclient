using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
    public class ComboCompVO
    {
        public string Comp_Type { get; set; }
        public string Common_Name { get; set; }
    }

    public class CompanyVO
    {
        public string Comp_Code { get; set; }
        public string Comp_Name { get; set; }
        public string Comp_CEO { get; set; }
        public string Common_Name { get; set; }
        public string Comp_Type { get; set; }
        public string Comp_Auto { get; set; }
        public string Comp_State { get; set; }
    }

    public class CompanyDetailVO
    {
        public string Comp_Code { get; set; }
        public string Prod_Code { get; set; }
        public string Prod_Name { get; set; }
        public string Prod_Unit{ get; set; }
        public decimal Prod_MinCount { get; set; }
        public int Prod_UnitPrice { get; set; }
        public int Prod_OldUnitPrice { get; set; }
        public string item_State { get; set; }
        public string Prod_WhCode { get; set; }
        public decimal totCount { get; set; }
        public decimal Prod_SafetyStock { get; set; }
        public string Check_Point { get; set; }

    }

    public class CompanyPopUpVO
    {
        public string Common_Code { get; set; }
        public string Common_Name { get; set; }

    }
}
