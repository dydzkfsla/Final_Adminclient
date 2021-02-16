using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminClient.BaseForm
{
    public partial class FormSearchTemp : AdminClient.BaseForm.FormSerchListSplitTemp
    {
        public FormSearchTemp()
        {
            InitializeComponent();
        }

        private void FormSearchTemp_Load(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 370;
        }
    }
}
