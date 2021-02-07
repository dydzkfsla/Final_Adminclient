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
		public DemandPlan()
		{
			InitializeComponent();
		}

        private void DemandPlan_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dgv_Demand.DataSource = null;

            DemandService service = new DemandService();
            string sdate = dtp_sdate.Value.ToString("yyyy-MM-dd"), edate = dtp_edate.Value.ToString("yyyy-MM-dd");


            DataTable dt = service.GetDemandList(sdate, edate);

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
    }
}
