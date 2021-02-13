using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
    public class WareHouseVO
    {
        public string WH_Code { get; set; }
        public string WH_Type { get; set; }
        public string Common_Name { get; set; }
        public string WH_State { get; set; }
        public string WH_Name { get; set; }
    }

    public class WhDetailVO
    {
        public string WH_Code { get; set; }
        public string Common_Name { get; set; }
        public string Prod_Code { get; set; }
        public string Prod_Name { get; set; }
        public string Prod_Unit { get; set; }
        public decimal WH_PsyCount { get; set; }
        public decimal WH_LogCount { get; set; }
        public decimal Prod_SafetyStock { get; set; }

    }

    public class ComboWhVO 
    {
        public string Common_Code { get; set; }
        public string Common_Name { get; set; }
    }
}
