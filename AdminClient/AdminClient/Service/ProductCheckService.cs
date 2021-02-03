using AdminClientDAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient.Service
{
    public class ProductCheckService
    {
        public bool InsertProductCheck(string Prod_Code, string Check_Type, string Check_System, string Check_Point, string Check_Item, string Check_Standard)
        {
            using (ProductCheckDAC DAC = new ProductCheckDAC())
            {
                return DAC.InsertProductCheck(Prod_Code, Check_Type, Check_System, Check_Point, Check_Item, Check_Standard);
            }
        }

        public bool UpdateProductCheck(string Prod_Code, string Check_Type, string Check_System, string Check_Point, string Check_Item, string Check_Standard)
        {
            using (ProductCheckDAC DAC = new ProductCheckDAC())
            {
                return DAC.UpdateProductCheck(Prod_Code, Check_Type, Check_System, Check_Point, Check_Item, Check_Standard);
            }
        }

        public bool DeleteProductCheck(string Prod_Code, string Check_Type)
        {
            using (ProductCheckDAC DAC = new ProductCheckDAC())
            {
                return DAC.DeleteProductCheck(Prod_Code, Check_Type);
            }
        }


    }
}
