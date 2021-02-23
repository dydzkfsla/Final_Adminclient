using AdminClient.Service;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminClient.Forms
{
	public partial class DemandPlan : AdminClient.BaseForm.FormSerchListTemp
	{
        DataTable dt;
		public DemandPlan()
		{
			InitializeComponent();
		}

        private void DemandPlan_Load(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 365;
            dtp_edate.Value = DateTime.Now.AddDays(15);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dgv_Demand.DataSource = null;

            DemandService service = new DemandService();
            string sdate = dtp_sdate.Value.ToString("yyyy-MM-dd"), edate = dtp_edate.Value.ToString("yyyy-MM-dd");

            dgv_Demand.Columns.Clear();
            CommonUtil.AddGridCheckColumn(dgv_Demand, "", "", 30, textAlign : DataGridViewContentAlignment.MiddleCenter );
            CommonUtil.AddGridTextColumn(dgv_Demand, "업체코드", "Comp_Code");
            CommonUtil.AddGridTextColumn(dgv_Demand, "업체명", "Comp_Name");
            CommonUtil.AddGridTextColumn(dgv_Demand, "업체타입", "Common_Name");
            CommonUtil.AddGridTextColumn(dgv_Demand, "품목코드", "prod");
            CommonUtil.AddGridTextColumn(dgv_Demand, "품목명", "Prod_Name");
            dt = service.GetDemandList(sdate, edate);

            dgv_Demand.DataSource = dt;

            //if(dgv_Demand.Rows.Count > 0)
            //{
            //    schCtrl.Getdata(dgv_Demand);
            //    sortCtrl.Getdata(dgv_Demand);
            //}


            //foreach (DataGridViewColumn dc in dgv_Demand.Columns)
            //{
            //    if (dc.DataPropertyName == "prod")
            //        MessageBox.Show("Test");
            //}
        }

        private void dtp_sdate_ValueChanged(object sender, EventArgs e)
        {
            if(dtp_edate.Value < dtp_sdate.Value)
            {
                dtp_edate.Value = dtp_sdate.Value.AddDays(1);
            }
        }

        private void dtp_edate_ValueChanged(object sender, EventArgs e)
        {
            if(dtp_sdate.Value > dtp_edate.Value)
            {
                dtp_sdate.Value = dtp_edate.Value.AddDays(-1);
            }
        }

        private void btn_Xls_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            CommonExcel excel = new CommonExcel();
            excel.Cursor = this.Cursor;
            dlg.Filter = "Excel File(*.xls)|*.xls";
            dlg.Title = "엑셀파일로 내보내기";
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            
            if (dt != null)
            {
                dt.TableName = this.Name;
                string toltip = $@"Comp_Code: 업체코드
                            {System.Environment.NewLine}Comp_Name : 업체명
                            {System.Environment.NewLine}Common_Name : 업체타입명
                            {System.Environment.NewLine}Common_Name : 업체타입코드
                            {System.Environment.NewLine}prod : 품목코드
                            {System.Environment.NewLine}Prod_Name : 품목명";
                if (excel.ExportDataToExcel(dt, dlg.FileName, toltip))
                {
                    MessageBox.Show("엑셀파일에 저장하였습니다.");
                }
            }
        }

		private void chk_limit_CheckedChanged(object sender, EventArgs e)
		{
            nu_limit.Enabled = chk_limit.Checked;

            if (!chk_limit.Checked)
            {
                nu_limit.Value = 0;
            }
        }
	}
}
