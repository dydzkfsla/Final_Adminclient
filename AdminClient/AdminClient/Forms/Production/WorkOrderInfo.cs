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
    }
}
