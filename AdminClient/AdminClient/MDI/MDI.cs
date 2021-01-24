using AdminClient.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminClient.MDI
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            EmpInfo form1 = new EmpInfo();
            this.OpenCreateForm(form1, true);
            form1.Dock = DockStyle.Fill;
        }


    }
}
