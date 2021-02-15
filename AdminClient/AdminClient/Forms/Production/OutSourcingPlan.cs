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

        }
    }
}
