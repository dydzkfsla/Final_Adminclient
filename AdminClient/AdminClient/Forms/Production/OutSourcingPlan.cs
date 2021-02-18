using AdminClient.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace AdminClient.Forms
{
	public partial class OutSourcingPlan : AdminClient.BaseForm.FormSerchListTemp
	{
        DataTable dt;

        public OutSourcingPlan()
		{
			InitializeComponent();

			dtp_to.Value = DateTime.Now.AddDays(15);
		}

        private void btn_search_Click(object sender, EventArgs e)
        {
			string from, to;
			from = to = string.Empty;

			from = dtp_from.Value.ToString("yyyy-MM-dd");
			to = dtp_to.Value.ToString("yyyy-MM-dd");

			DemandService service = new DemandService();
			dt = service.GetDemandPlan(from, to);

			dgv_Plan.DataSource = null;
			dgv_Plan.DataSource = dt;

			if(dgv_Plan.Rows.Count > 0)
            {
				bool dgvCol = false;

				foreach(DataGridViewRow dr in dgv_Plan.Rows)
                {
					if (dr.Cells["Category"].Value.ToString() == "소요량")
						dgvCol = !dgvCol;

					if (dgvCol)
						dr.DefaultCellStyle.BackColor = Color.PowderBlue;
					else
						dr.DefaultCellStyle.BackColor = Color.White;

					
				}

				

            }

        }

        private void OutSourcingPlan_Load(object sender, EventArgs e)
        {
			splitContainer1.SplitterDistance = 365;

			CommonUtil.AddGridTextColumn(dgv_Plan, "품목코드", "BOM_ProdCode");
			CommonUtil.AddGridTextColumn(dgv_Plan, "품목명", "BOM_ProdName", 150);
			CommonUtil.AddGridTextColumn(dgv_Plan, "카테고리", "Category", 150);

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
                string toltip = $@"BOM_ProdCode: 품목코드
                            {System.Environment.NewLine}BOM_ProdName : 품목명
                            {System.Environment.NewLine}Category : 카테고리";
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
