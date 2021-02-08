using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
    public class InOutVO
    {
        public string WH_Code {get; set; }
        public string WH_Type {get; set; }
        public string WH_TypeName {get; set; }
        public string WH_Name {get; set; }
        public string Prod_Code {get; set; }
        public string Prod_Name {get; set; }
        public string Prod_Category {get; set; }
        public string Category_Code  {get; set; }
        public string Prod_Unit {get; set; }
        public decimal WHInOut_Count {get; set; }
        public string WHInOut_Type { get; set; }
    }

    public class CombInOutVO
    {
        public string Common_Code { get; set; }
        public string Common_Name { get; set; }
        public string Prod_Unit { get; set; }
    }
}
