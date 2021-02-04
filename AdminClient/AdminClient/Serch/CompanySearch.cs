using AdminClient.Service;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminClient.Serch
{
    public partial class CompanySearch : AdminClient.BaseForm.FormSearchTemp
    {
        string prodcode = string.Empty;
        List<ComboCompVO> comblist;

        public string ProdCode { get { return prodcode; } set { prodcode = value; } }


        public CompanySearch()
        {
            InitializeComponent();
        }

        private void CompanySearch_Load(object sender, EventArgs e)
        {
            nu_limit.Enabled = gb_detail.Enabled = false;

            CompanyService service = new CompanyService();
            comblist = service.GetComboBindingList();

            cbo_Category.DataSource = comblist;
            cbo_Category.DisplayMember = "Common_Name";
            cbo_Category.ValueMember = "Comp_Type";



        }

        private void chk_limit_CheckedChanged(object sender, EventArgs e)
        {
            nu_limit.Enabled = chk_limit.Checked;
        }
    }
}
