using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
    public class BORVO
    {
        public int BOR_Code { get; set; }
        public string Prod_Code { get; set; }
        public string Prod_Name { get; set; }
        public string Pcs_Code { get; set; }
        public string Pcs_Name { get; set; }
        public string Fac_Code { get; set; }
        public string Fac_Name { get; set; }
        public int Tact_Time { get; set; }
        public int BOR_Priority { get; set; }
        public int BOR_DelayTime { get; set; }
        public string BOR_State { get; set; }
        public string BOR_Note { get; set; }

    }


    public class CombBORVO 
    {
        public string Fac_Code { get; set; }
        public string Fac_Name { get; set; }
        public string Pcs_Code { get; set; }
        public string Pcs_Name { get; set; }

    }

}
