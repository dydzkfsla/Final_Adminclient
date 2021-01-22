using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminClient
{
    public partial class CustomDataGridView : DataGridView
    {
        public bool IsChkVisible { get; set; }
        public CustomDataGridView()
        {
            InitializeComponent();
            this.DataBindingComplete += dataGridView1_DataBindingComplete;
            this.BackgroundColor = Color.White;
            CommonUtil.AddGridTextColumn(this, "No", "No", 100);
            CommonUtil.AddGridCheckColumn(this, "Chk", "Chk", 80, IsChkVisible);
            this.DefaultCellStyle.SelectionBackColor = Color.IndianRed;
            this.DefaultCellStyle.SelectionForeColor = Color.White;
            this.GridColor = Color.Black;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in this.Rows)
            {
                
                row.Cells["No"].Value = row.Index.ToString();
                if (row.Index % 2 == 0)
                    row.DefaultCellStyle.BackColor = Color.AliceBlue;
            }
        }
    }
}
