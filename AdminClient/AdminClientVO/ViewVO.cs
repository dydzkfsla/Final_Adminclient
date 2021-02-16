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
        public bool Form_Insert { get; set; }
        public bool Form_Select { get; set; }
        public bool Form_Update { get; set; }
        public bool Form_Delete { get; set; }

       
    }

    public class View_EmpFormVOComparer : IEqualityComparer<View_EmpFormVO>
    {
        public bool Equals(View_EmpFormVO x, View_EmpFormVO y)
        {
            if (Object.ReferenceEquals(x, y)) return true;

            //Check whether any of the compared objects is null.
            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;

            //Check whether the products' properties are equal.
            return x.Form_Name.Equals(y.Form_Name) && x.Form_Menu.Equals(y.Form_Menu);
        }

        public int GetHashCode(View_EmpFormVO c)
        {
            if (Object.ReferenceEquals(c, null)) return 0;

            //Get hash code for the Name field if it is not null.
            int hashProductName = c.Form_Name == null ? 0 : c.Form_Name.GetHashCode();

            //Get hash code for the Code field.
            int hashProductCode = c.Form_Name.GetHashCode();

            //Calculate the hash code for the product.
            return hashProductName ^ hashProductCode;
        }
    }

    public class View_FavoritesVO
    {
        public string Form_Name { get; set; }
        public string Grp_Name { get; set; }
        public string Form_Menu { get; set; }
    }

    public class View_ProductNameAndCheckVO
    {
        public string Prod_Code { get; set; }
        public string Prod_Name { get; set; }
        public string Check_Type { get; set; }
        public string Check_System { get; set; }
        public string Check_Point { get; set; }
        public string Check_Item { get; set; }
        public string Check_Standard { get; set; }
    }

    public class View_FormConnGroupVO
    {
        public string Form_Menu { get; set; }
        public string Form_Name { get; set; }
        public int Grp_No { get; set; }
    }


    public class Imagedata
    {
        public byte[] image;
        public string filename;
    }

}
