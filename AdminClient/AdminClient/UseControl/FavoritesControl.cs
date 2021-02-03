using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminClient.UseControl
{
    public partial class FavoritesControl : UserControl
    {
        public event EventHandler FavoritesClick { add { this.Click += value; lbl_Title.Click += value; } remove { this.Click -= value; lbl_Title.Click -= value; } }
        public FavoritesControl()
        {
            InitializeComponent();
        }

        private void FavoritesControl_Load(object sender, EventArgs e)
        {
            lbl_Title.Text = this.Text;
        }

        private void FavoritesControl_Click(object sender, EventArgs e)
        {

        }
    }
}
