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

    public class View_ProductNameAndCheckVO
    {
        public string Prod_Code         { get; set; }
        public string Prod_Name         { get; set; }
        public string Check_Type        { get; set; }
        public string Check_System      { get; set; }
        public string Check_Point       { get; set; }
        public string Check_Item        { get; set; }
        public string Check_Standard    { get; set; }
    }

    public class Imagedata
    {
        public byte[] image;
        public string filename;
    }

}
