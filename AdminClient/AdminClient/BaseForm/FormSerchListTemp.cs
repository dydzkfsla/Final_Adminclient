using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminClient.BaseForm
{
    public partial class FormSerchListTemp : AdminClient.BaseForm.FormListTemp
    {
        public FormSerchListTemp()
        {
            InitializeComponent();
        }

        private void FormSerchListTemp_Load(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 365;
        }
    }
}
