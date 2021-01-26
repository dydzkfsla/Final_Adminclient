using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
    public class FormInfoVO
    {
        public string Form_Name { get; set; }
        public string Form_Menu { get; set; }

        public FormInfoVO()
        {

        }

        public FormInfoVO(string form_Name)
        {
            Form_Name = form_Name;
        }

        public FormInfoVO(string form_Name, string form_Menu) : this(form_Name)
        {
            Form_Menu = form_Menu;
        }
    }
}
