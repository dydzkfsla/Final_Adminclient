using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminClient.BaseForm
{
    public partial class EmpFormTemp : AdminClient.BaseForm.FormTemp
    {
        public EmpFormTemp()
        {
            InitializeComponent();
        }

        private void EmpFormTemp_Load(object sender, EventArgs e)
        {
            lbl_Title.Text = this.Text;
        }
    }
}
