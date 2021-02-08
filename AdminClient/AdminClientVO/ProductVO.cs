using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
    #region ProductInfo Form
    public class ProductVO
    {
        public string Prod_Code { get; set; }
        public string Prod_Category { get; set; }
        public string Common_Name { get; set; }
        public string Prod_Name { get; set; }
        public string Prod_Unit { get; set; }
        public string Prod_State { get; set; }
        public string Prod_WhCode { get; set; }
        public decimal Prod_SafetyStock { get; set; }
        public decimal totcnt { get; set; }
    }

    public class ComboProductVO
    {
        public string Common_Code { get; set; }
        public string Common_Name { get; set; }
        public string Prod_Unit { get; set; }
        public string Prod_State { get; set; }

    }
    #endregion

    #region ProductSearch Form

    #endregion
}
