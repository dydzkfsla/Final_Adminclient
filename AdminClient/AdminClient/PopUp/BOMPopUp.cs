using AdminClient.Serch;
using AdminClient.Service;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminClient.PopUp
{
    public partial class BOMPopUp : AdminClient.BaseForm.EmpFormTemp
    {
        ProductVO prodinfo = null;

        public BOMPopUp()
        {
            InitializeComponent();
        }

        private void btn_ProdSearch_Click(object sender, EventArgs e)
        {
            ProductSearch frm = new ProductSearch();
            if(frm.ShowDialog() == DialogResult.OK)
                prodinfo = frm.AddList[0];

            txt_ProdName.Text = prodinfo.Prod_Name;
            txt_ProdName.Tag = prodinfo.Prod_Code;

            if(prodinfo != null)
            {
                BOMService service = new BOMService();
                List<UpLevelList> upItemList = service.GetUpLevelItemList(prodinfo);

                if(upItemList.Count > 0)
                {
                    cbo_ProdP.DisplayMember = "Prod_Name";
                    cbo_ProdP.ValueMember = "Prod_Code";
                    cbo_ProdP.DataSource = upItemList;
                    cbo_ProdP.Enabled = true;

                }
            }

            //변경필요
            if (prodinfo.Prod_Unit == "ea")
                txt_Count.KeyPress += UtilEvent.TextBoxIsDigit;
            else
                txt_Count.KeyPress += UtilEvent.TextBoxIsDigitAndOneDot;

        }

        private void BOMPopUp_Load(object sender, EventArgs e)
        {
            cbo_ProdP.Enabled = false;
            txt_ProdName.KeyPress += NoneKeyPress;
            dtp_End.Value = DateTime.Now.AddDays(1);

            cbo_State.Items.Add("Y");
            cbo_State.Items.Add("N");
            cbo_State.SelectedIndex = 0;
            cbo_AutoDecreaseState.Items.Add("Y");
            cbo_AutoDecreaseState.Items.Add("N");
            cbo_AutoDecreaseState.SelectedIndex = 0;

        }

        private void NoneKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dtp_Start_ValueChanged(object sender, EventArgs e)
        {
            if(dtp_Start.Value >= dtp_End.Value)
            {
                dtp_Start.Value = dtp_End.Value.AddDays(-1);
            }
        }

        private void dtp_End_ValueChanged(object sender, EventArgs e)
        {
            if(dtp_End.Value <= dtp_Start.Value)
            {
                dtp_End.Value = dtp_Start.Value.AddDays(1);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(txt_ProdName.Text.Trim().Length < 1)
            {
                MessageBox.Show("물품을 선택해주세요");
                return;
            }

            if(cbo_ProdP.Text.Length < 1)
            {
                MessageBox.Show("더이상 BOM을 설정할 수 없는 물품입니다.");
                return;
            }

            BOMVO bom = new BOMVO
            {
                BOM_ProdCode = txt_ProdName.Tag.ToString(),
                BOM_Count = decimal.Parse(txt_Count.Text),
                BOM_P_ProdCode = cbo_ProdP.SelectedValue.ToString(),
                BOM_StartDate = dtp_Start.Value,
                BOM_EndDate = dtp_End.Value,
                BOM_State = cbo_State.Text,
                BOM_AutoDecrease = cbo_AutoDecreaseState.Text,
                BOM_Note = txt_Note.Text
            };

            BOMService service = new BOMService();
            bool result = service.AddBOM(bom);

            if(result)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("BOM입력중 오류가 발생했습니다.");


        }
    }
}
