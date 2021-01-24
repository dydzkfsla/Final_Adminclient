﻿using System;
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
        CheckBox cb = new CheckBox();

        event EventHandler Chk_CheckedChanged
        {
            add
            {
                cb.CheckedChanged += value;
            }
            remove
            {
                cb.CheckedChanged -= value;
            }
        }


        private bool isChkVisible = false;
        public bool IsChkVisible
        {
            get => isChkVisible;
            set
            {
                isChkVisible = value;
                if (this.Columns.Count > 0)
                {
                    this.Columns[1].Visible = isChkVisible;
                }
            }
        }
        bool IsADDChk = false;

        public CustomDataGridView()
        {
            InitializeComponent();
            this.DataBindingComplete += dataGridView1_DataBindingComplete;
            cb.CheckedChanged += ChkCheckedChanged;
            this.BackgroundColor = Color.White;



            this.DefaultCellStyle.SelectionBackColor = Color.IndianRed;
            this.DefaultCellStyle.SelectionForeColor = Color.White;
            this.GridColor = Color.Black;
        }


        private void ChkCheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in this.Rows)
            {
                r.Cells["Chk"].Value = ((CheckBox)sender).Checked;
            }
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
                row.Cells["Chk"].Value = false;
                if (row.Index % 2 == 0)
                    row.DefaultCellStyle.BackColor = Color.AliceBlue;
            }
        }

        private void CustomDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex == -1)
            {
                e.PaintBackground(e.ClipBounds, false);


                Point pt = e.CellBounds.Location;

                int nChkBoxWidth = 15;
                int nChkBoxHeight = 15;
                int offsetx = (e.CellBounds.Width - nChkBoxWidth) / 2;
                int offsety = (e.CellBounds.Height - nChkBoxHeight) / 2;

                pt.X += offsetx;
                pt.Y += offsety;


                cb.Size = new Size(nChkBoxWidth, nChkBoxHeight);
                cb.Location = pt;

                int whith = this.Location.X;

                if (e.CellBounds.X >= 100)
                {
                    if (!IsADDChk)
                    {
                        ((DataGridView)sender).Controls.Add(cb);
                        IsADDChk = true;
                    }
                }
                else
                {
                    if (IsADDChk)
                    {
                        ((DataGridView)sender).Controls.Remove(cb);
                        IsADDChk = false;
                    }
                }
                e.Handled = true;
            }
        }

        public void SetGridColumn()
        {
            CommonUtil.SetInitGridView(this, false);
            CommonUtil.AddGridTextColumn(this, "No", "No", 100);
            CommonUtil.AddGridCheckColumn(this, "", "Chk", 20);
        }
    }
}
