using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminClient.Forms
{
    public partial class CompanyInfo : AdminClient.BaseForm.FormSerchListThreeSplitTemp
    {
        List<(string name, string text)> temp = new List<(string name, string text)>();


        public CompanyInfo()
        {
            InitializeComponent();
            temp.Add(("text", "text"));
            temp.Add(("text", "text"));
            temp.Add(("text", "text"));
            temp.Add(("text", "text"));
            temp.Add(("text", "text"));

            customDataGridView1.DataSource = temp;
            customDataGridView2.DataSource = temp;
        }
    }
}
