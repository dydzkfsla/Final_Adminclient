using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminClient.Forms
{
    public partial class EmpInfo : AdminClient.BaseForm.FormSerchListTemp
    {
        public EmpInfo()
        {
            InitializeComponent();
        }

        private void EmpInfo_Load(object sender, EventArgs e)
        {

        }

        private void DgvColumSet()
        {
            CommonUtil.SetInitGridView(dgv_Emp, false);
        }
    }
}
