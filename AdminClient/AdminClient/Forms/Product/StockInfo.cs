using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminClient.Forms
{
	public partial class StockInfo : AdminClient.BaseForm.FormListTemp
	{
		public StockInfo()
		{
			InitializeComponent();
		}

        private void StockInfo_Load(object sender, EventArgs e)
        {
			gb_detail.Enabled = false;
        }
    }
}
