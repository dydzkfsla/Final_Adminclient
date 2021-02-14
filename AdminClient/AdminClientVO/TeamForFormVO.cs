using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
    public class TeamForFormVO
    {
        public string Team_Code { get; set; }
        public string Form_Name { get; set; }
        public bool Form_Select { get; set; }
        public bool Form_Insert { get; set; }
        public bool Form_Update { get; set; }
        public bool Form_Delete { get; set; }
    }
}
