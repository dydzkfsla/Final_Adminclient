using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
    public class BOMVO
    {
        public int BOM_Code { get; set; }
        public string BOM_ProdCode { get; set; }
        public string childName { get; set; }
        public decimal BOM_Count { get; set; }
        public string BOM_P_ProdCode { get; set; }
        public string parentName { get; set; }
        public DateTime BOM_StartDate { get; set; }
        public DateTime BOM_EndDate { get; set; }
        public string BOM_State { get; set; }
        public string BOM_AutoDecrease { get; set; }
        public string BOM_Note { get; set; }
    }

    public class UpLevelList
    {
        public string Prod_Code { get; set; }
        public string Prod_Name { get; set; }
    }

    public class ForwardBOM
    {
        public int BOM_Code { get; set; }
        public string Info { get; set; }
        public string Common_Name { get; set; }
        public string Prod_Code { get; set; }
        public string childName { get; set; }
        public string BOM_P_ProdCode { get; set; }
        public string parentName { get; set; }
        public decimal BOM_Count { get; set; }
        public int level { get; set; }
        public string sortOrder { get; set; }
        public DateTime BOM_StartDate { get; set; }
        public DateTime BOM_EndDate { get; set; }
        public string BOM_State { get; set; }
        public string BOM_AutoDecrease { get; set; }
        public string BOM_Note { get; set; }
    }

    public class ReverseBOM
    {
        public int BOM_Code { get; set; }
        public string childCode { get; set; }
        public string childName { get; set; }
        public string parentCode { get; set; }
        public string parentName { get; set; }
        public decimal BOM_Count { get; set; }
        public DateTime BOM_StartDate { get; set; }
        public DateTime BOM_EndDate { get; set; }
        public string BOM_State { get; set; }
        public string BOM_AutoDecrease { get; set; }
        public string BOM_Note { get; set; }

    }

    public class BOMInfo
    {
        public DateTime Date { get; set; }
        public string ProdCode { get; set; }
        public string State { get; set; }
    }
}
