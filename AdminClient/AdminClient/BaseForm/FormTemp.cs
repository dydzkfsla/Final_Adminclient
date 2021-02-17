using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminClient.BaseForm
{
    public partial class FormTemp : Form
    {
        Point point = new Point();
        Size size = new Size();
        public FormTemp()
        {
            InitializeComponent();
        }

        private void Form_maximise_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                point = this.Location;
                size = this.Size;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Location = point;
                this.Size = size;
            }


        }

        private void Form_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void From_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        protected override void WndProc(ref Message m)
        {
            const int RESIZE_HANDLE_SIZE = 10;
            switch (m.Msg)
            {

                case 0x0084/*NCHITTEST*/ :
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x01/*HTCLIENT*/)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);
                        if (clientPoint.Y <= RESIZE_HANDLE_SIZE)
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)13/*HTTOPLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)12/*HTTOP*/ ;
                            else
                                m.Result = (IntPtr)14/*HTTOPRIGHT*/ ;
                        }
                        else if (clientPoint.Y <= (Size.Height - RESIZE_HANDLE_SIZE))
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)10/*HTLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)2/*HTCAPTION*/ ;
                            else
                                m.Result = (IntPtr)11/*HTRIGHT*/ ;
                        }
                        else
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)16/*HTBOTTOMLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)15/*HTBOTTOM*/ ;
                            else
                                m.Result = (IntPtr)17/*HTBOTTOMRIGHT*/ ;
                        }
                    }
                    return;
            }

            base.WndProc(ref m);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- use 0x20000
                return cp;
            }
        }

        private void FormTemp_Load(object sender, EventArgs e)
        {
            SerchButton(this.Controls);
        }

        private void SerchButton(Control.ControlCollection controls)
        {
            if (Global.Global.Emp_Form == null)
                return;
            if (this.GetType().FullName.Contains("AdminClient.Serch"))
                return;

            var List = Global.Global.Emp_Form.FindAll(x =>
            {
                return this.GetType().FullName.Contains(x.Form_Name);

            });
            foreach (Control control in controls)
            {
                if (control is Button)
                {
                    if (control.Name.ToLower().Contains("search"))
                    {
                        bool result = false;
                        foreach (var item in List)
                        {
                            if (item.Form_Select)
                            {
                                result = true;
                            }
                        }
                       ((Button)control).Enabled = result;
                    }
                    if (control.Name.ToLower().Contains("add"))
                    {
                        bool result = false;
                        foreach (var item in List)
                        {
                            if (item.Form_Insert)
                            {
                                result = true;
                            }
                        }
                        ((Button)control).Enabled = result;
                    }
                    if (control.Name.ToLower().Contains("update"))
                    {
                        bool result = false;
                        foreach (var item in List)
                        {
                            if (item.Form_Update)
                            {
                                result = true;
                            }
                        }
                        ((Button)control).Enabled = result;
                    }
                    if (control.Name.ToLower().Contains("delete"))
                    {
                        bool result = false;
                        foreach (var item in List)
                        {
                            if (item.Form_Delete)
                            {
                                result = true;
                            }
                        }
                        ((Button)control).Enabled = result;
                    }
                }
                if (control.Controls.Count > 0)
                {
                    SerchButton(control.Controls);
                }
            }
        }

        private void FormTemp_Activated(object sender, EventArgs e)
        {
            if (this.MdiParent == null)
            {
                return;
            }
            ToolStripItem Addcontrols = null;
            ToolStripItem Selectcontrols = null;
            ToolStripItem Updatecontrols = null;
            ToolStripItem Deletecontrols = null;
            var List = Global.Global.Emp_Form.FindAll(x =>
            {
                return this.GetType().FullName.Contains(x.Form_Name);

            });
            Addcontrols = ((ToolStrip)this.MdiParent.Controls["toolStrip1"]).Items.Find("toolStripLabel_Btn_add", true)[0];
            Selectcontrols = ((ToolStrip)this.MdiParent.Controls["toolStrip1"]).Items.Find("toolStripLabel_Btn_Select", true)[0];
            Updatecontrols = ((ToolStrip)this.MdiParent.Controls["toolStrip1"]).Items.Find("toolStripLabel_Btn_Update", true)[0];
            Deletecontrols = ((ToolStrip)this.MdiParent.Controls["toolStrip1"]).Items.Find("toolStripLabel_Btn_Delete", true)[0];
            

            foreach (var item in List)
            {
                Selectcontrols.Text = "조회권한 : " + (item.Form_Select == true ? "Y" : "N");
                Addcontrols.Text = "추가권한 : " + (item.Form_Insert == true ? "Y" : "N");
                Updatecontrols.Text = "수정권한 : " + (item.Form_Update == true ? "Y" : "N");
                Deletecontrols.Text = "삭제권한 : " + (item.Form_Delete == true ? "Y" : "N");
            }
        }
    }
}
