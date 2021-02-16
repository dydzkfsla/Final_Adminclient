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
        public WorkOrderInfo()
        {
            InitializeComponent();
        }

        private void WorkOrderInfo_Load(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 365;
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
