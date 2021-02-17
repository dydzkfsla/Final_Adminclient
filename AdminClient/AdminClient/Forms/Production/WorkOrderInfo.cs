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
    public partial class WorkOrderInfo : AdminClient.BaseForm.FormListTemp
    {
        List<WorkOrderVO> wolist;
        public WorkOrderInfo()
        {
            InitializeComponent();
        }

        private void WorkOrderInfo_Load(object sender, EventArgs e)
        {
            lbl_Title.Text = "작업지시현황";
            splitContainer1.SplitterDistance = 365;
            gb_work.Enabled = false;
            gb_due.Enabled = false;
            nu_limit.Enabled = false;

            dgv_woList.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_woList, "작업번호", "WO_Code", 200);
            CommonUtil.AddGridTextColumn(dgv_woList, "품목번호", "Prod_Code");
            CommonUtil.AddGridTextColumn(dgv_woList, "품목명", "Prod_Name", 200);
            CommonUtil.AddGridTextColumn(dgv_woList, "작업상태", "WO_State");
            CommonUtil.AddGridTextColumn(dgv_woList, "설비번호", "Fac_Code");
            CommonUtil.AddGridTextColumn(dgv_woList, "설비명", "Fac_Name", 150);
            CommonUtil.AddGridTextColumn(dgv_woList, "작업팀코드", "Team_Code", 150);
            CommonUtil.AddGridTextColumn(dgv_woList, "작업팀명", "Team_Name", 150);
            CommonUtil.AddGridTextColumn(dgv_woList, "지시수량", "WO_EstimatedQuantity", 150);
            CommonUtil.AddGridTextColumn(dgv_woList, "목표수량", "WO_OrderQuantity", 150);
            CommonUtil.AddGridTextColumn(dgv_woList, "지시일", "makeDate", 150);
            

        }

		private void chk_limit_CheckedChanged(object sender, EventArgs e)
		{
            nu_limit.Enabled = chk_limit.Checked;

            if (!chk_limit.Checked)
            {
                nu_limit.Value = 0;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string limit, wfrom, wto, dfrom, dto;
            limit = wfrom = wto = dfrom = dto = string.Empty;

            if (chk_limit.Checked)
                limit = nu_limit.Value.ToString();

            if(chk_Work.Checked)
            {
                wfrom = dtp_wfrom.Value.ToString("yyyy-MM-dd");
                wto = dtp_wto.Value.ToString("yyyy-MM-dd");
            }

            if(chk_Due.Checked)
            {
                dfrom = dtp_dfrom.Value.ToString("yyyy-MM-dd");
                dto = dtp_dto.Value.ToString("yyyy-MM-dd");
            }

            WorkOrderService service = new WorkOrderService();
            wolist = service.GetWorkOrder(limit, wfrom, wto, dfrom, dto);

            dgv_woList.DataSource = null;
            dgv_woList.DataSource = wolist;

            if(wolist != null && wolist.Count > 0)
            {
                schCtrl.Getdata(dgv_woList);
                sortCtrl.Getdata(dgv_woList);
            }
        }

        private void chk_Work_CheckedChanged(object sender, EventArgs e)
        {
            gb_work.Enabled = chk_Work.Checked;
        }

        private void chk_Due_CheckedChanged(object sender, EventArgs e)
        {
            gb_due.Enabled = chk_Due.Checked;
        }
    }
}
