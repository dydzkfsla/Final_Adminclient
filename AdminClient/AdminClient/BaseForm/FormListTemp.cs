using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminClient.BaseForm
{
    public partial class FormListTemp : AdminClient.BaseForm.FormTemp
    {
        public FormListTemp()
        {
            InitializeComponent();
            lbl_Title.Text = this.Text;
            //CommonUtil.SetInitGridView(dgv_data, false);
        }

        private void btn_folding_Click(object sender, EventArgs e)
        {
            if (btn_folding.Text == "<<")
            {
                splitContainer1.Panel1Collapsed = true;
                btn_folding.Text = ">>";
            }
            else
            {
                splitContainer1.Panel1Collapsed = false;
                btn_folding.Text = "<<";
            }
        }

        private void FormListTemp_Load(object sender, EventArgs e)
        {
            lbl_Title.Text = this.Text;
        }
    }
}
