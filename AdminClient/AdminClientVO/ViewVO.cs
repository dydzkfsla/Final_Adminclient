using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
    public class View_EmpFormVO
    {
        public string Form_Name { get; set; }
        public string Emp_Code { get; set; }
        public string Grp_Name { get; set; }
        public string Form_Menu { get; set; }
    }

    public class View_FavoritesVO
    {
        public string Form_Name { get; set; }
        public string Grp_Name { get; set; }
        public string Form_Menu { get; set; }
    }
}
