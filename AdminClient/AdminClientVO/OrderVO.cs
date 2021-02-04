﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
    public class OrderVO
    {
        public int Orders_Code { get; set; }
        public string Comp_Code { get; set; }
        public string Comp_Name { get; set; }
        public string WH_Code { get; set; }
        public DateTime Orders_DueDate { get; set; }
        public string Orders_Note { get; set; }
    }

    public class OrderDetailVO
    {
        public int OrdersDetail_Code { get; set; }
        public int Orders_Code { get; set; }
        public string Prod_Code { get; set; }
        public string Prod_Name { get; set; }
        public string Prod_Unit { get; set; }
        public decimal Orders_Count  { get; set; }
        public decimal Orders_ReceiveQuantity { get; set; }
        public decimal Orders_CancelQuantity { get; set; }
        public string Orders_State_Comm { get; set; }
    }
}
