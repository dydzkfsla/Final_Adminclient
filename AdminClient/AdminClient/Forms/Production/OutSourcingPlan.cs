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
		public OutSourcingPlan()
		{
			InitializeComponent();
		}

        private void btn_search_Click(object sender, EventArgs e)
        {
			string from, to;
			from = to = string.Empty;

			from = dtp_from.Value.ToString("yyyy-MM-dd");
			to = dtp_to.Value.ToString("yyyy-MM-dd");

			DemandService service = new DemandService();
			DataTable dt = service.GetDemandPlan(from, to);

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

    }
}
