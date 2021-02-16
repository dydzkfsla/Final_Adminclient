using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
    public class WorkOrderVO
    {
        public string WO_Code { get; set; }
        public string Prod_Code { get; set; }
        public string Prod_Name { get; set; }
        public string WO_State { get; set; }
        public string Fac_Code { get; set; }
        public string Fac_Name { get; set; }
        public string Team_Code { get; set; }
        public string Team_Name { get; set; }
        public int WO_EstimatedQuantity { get; set; }
        public int WO_OrderQuantity { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime makeDate { get; set; }

    }
}
