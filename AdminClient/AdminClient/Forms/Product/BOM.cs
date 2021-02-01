using AdminClient.Service;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminClient.Forms
{
    public partial class BOM : AdminClient.BaseForm.EmpFormNoSerchTemp
    {
        List<ForwardBOM> forward;

        public BOM()
        {
            InitializeComponent();
        }

        private void BOM_Load(object sender, EventArgs e)
        {
            txt_Code.KeyPress += ProdCodeInput;

            cbo_choice.Items.Add("정전개");
            cbo_choice.Items.Add("역전개");
            cbo_choice.SelectedIndex = 0;

            cbo_state.Items.Add("Y");
            cbo_state.Items.Add("N");
            cbo_state.SelectedIndex = 0;

        }

        private void ProdCodeInput(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsNumber(e.KeyChar) || e.KeyChar == '_' || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            BOMInfo info = new BOMInfo
            {
                Date = dtp_date.Value,
                ProdCode = txt_Code.Text,
                State = cbo_state.Text
            };

            BOMService service = new BOMService();
            forward = service.GetForwardList(info);

            dgv_bom.DataSource = forward;

        }
    }
}
