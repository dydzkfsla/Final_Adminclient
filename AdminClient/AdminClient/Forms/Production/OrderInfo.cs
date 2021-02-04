using AdminClient.Service;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminClient.Forms
{
    public partial class OrderInfo : AdminClient.BaseForm.FormSerchListThreeSplitTemp
    {
        List<OrderVO> odlist;
        List<OrderDetailVO> oddlist;
        public OrderInfo()
        {
            InitializeComponent();
        }

        private void OrderInfo_Load(object sender, EventArgs e)
        {
            nu_limit.Enabled = gb_detail.Enabled = false;
        }

        private void chk_limit_CheckedChanged(object sender, EventArgs e)
        {
            nu_limit.Enabled = chk_limit.Checked;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string limit = string.Empty, sdate = dtp_start.Value.ToString("yyyy-MM-dd"), edate = dtp_end.Value.ToString("yyyy-MM-dd");

            if (chk_limit.Checked)
                limit = nu_limit.Value.ToString();

            OrderService service = new OrderService();
            odlist = service.GetOrderList(limit, sdate, edate);

            dgv_Odlist.DataSource = odlist;

            if(odlist.Count > 0)
            {
                gb_detail.Enabled = true;
                schCtrl.Getdata(dgv_Odlist);
                sortCtrl.Getdata(dgv_Odlist);
                
            }

        }

        private void rb_CheckedChange(object sender, EventArgs e)
        {
            dtp_start.Value = DateTime.Now;

            switch (((Control)sender).Name)
            {
                case "rb_Today":
                    dtp_end.Value = DateTime.Now.AddDays(1);
                    break;
                case "rb_OneWeek" :
                    dtp_end.Value = DateTime.Now.AddDays(7);
                    break;
                case "rb_1Month":
                    dtp_end.Value = DateTime.Now.AddMonths(1);
                    break;
                case "rb_3Month":
                    dtp_end.Value = DateTime.Now.AddMonths(3);
                    break;
            }
        }

        private void dgv_Odlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                string code = dgv_Odlist["Orders_Code", e.RowIndex].Value.ToString();

                OrderService service = new OrderService();
                oddlist = service.GetOdDetailList(code);

                dgv_oddList.DataSource = oddlist;

            }
        }

        private void dgv_Odlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1)
            {
                if(e.RowIndex > -1)
                {

                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }
    }
}
