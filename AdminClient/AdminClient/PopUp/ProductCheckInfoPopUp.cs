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
    public partial class ProductCheckInfoPopUp : AdminClient.BaseForm.EmpFormTemp
    {
        string selectProductName = string.Empty;
        public View_ProductNameAndCheckVO vo = new View_ProductNameAndCheckVO();
        public ProductCheckInfoPopUp()
        {
            InitializeComponent();

            txt_ProdCode.KeyPress += UtilEvent.Handled_KeyPress;
            txt_CheckItem.KeyPress += UtilEvent.isHangul_KeyPress;
            txt_CheckPoint.KeyPress += UtilEvent.isHangul_KeyPress;
            txt_CheckType.KeyPress += UtilEvent.isHangul_KeyPress;

            btn_update.Enabled = btn_delete.Enabled = true;
        }


        public ProductCheckInfoPopUp(View_ProductNameAndCheckVO vo) : this()
        {
            txt_ProdCode.Text = vo.Prod_Code;
            txt_CheckItem.Text = vo.Check_Item;
            txt_CheckPoint.Text = vo.Check_Point;
            txt_CheckStandard.Text = vo.Check_Standard;
            txt_CheckSystem.Text = vo.Check_System;
            txt_CheckType.Text = vo.Check_Type;
        }

        #region 필수입력 추가 여부
        private bool CheckTextBoxText()
        {
            bool result = true;
            CommonUtil.ControlAction<Panel, TextBox>(panel1, x =>
            {
                if (string.IsNullOrWhiteSpace(x.Text))
                {
                    result = false;
                }
            });
            return result;
        }
        #endregion

        #region 품목검색
        private void button1_Click(object sender, EventArgs e)
        {
            ProductSearch productSearch = new ProductSearch();
            productSearch.ThisMode = ProductSearch.Mode.One;
            if(productSearch.ShowDialog() == DialogResult.OK)
            {
                txt_ProdCode.Text = productSearch.AddList[0].Prod_Code;
                selectProductName = productSearch.AddList[0].Prod_Name;
            }
        }
        #endregion

        #region 업데이트
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!CheckTextBoxText())
                return;
            ProductCheckService Service = new ProductCheckService();
            if (Service.UpdateProductCheck(txt_ProdCode.Text, txt_CheckType.Text, txt_CheckSystem.Text, txt_CheckPoint.Text, txt_CheckItem.Text, txt_CheckStandard.Text))
            {
                vo.Prod_Name = selectProductName;
                vo.Prod_Code = txt_ProdCode.Text;
                vo.Check_Type = txt_CheckType.Text;
                vo.Check_Point = txt_CheckPoint.Text;
                vo.Check_Standard = txt_CheckStandard.Text;
                vo.Check_System = txt_CheckSystem.Text;
                vo.Check_Item = txt_CheckItem.Text;

                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }
        #endregion

        #region 추가
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!CheckTextBoxText())
                return;
            ProductCheckService Service = new ProductCheckService();
            if (Service.InsertProductCheck(txt_ProdCode.Text, txt_CheckType.Text, txt_CheckSystem.Text, txt_CheckPoint.Text, txt_CheckItem.Text, txt_CheckStandard.Text))
            {
                vo.Prod_Name = selectProductName;
                vo.Prod_Code = txt_ProdCode.Text;
                vo.Check_Type = txt_CheckType.Text;
                vo.Check_Point = txt_CheckPoint.Text;
                vo.Check_Standard = txt_CheckStandard.Text;
                vo.Check_System = txt_CheckSystem.Text;
                vo.Check_Item = txt_CheckItem.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        #endregion

        #region 삭제
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (!CheckTextBoxText())
                return;
            ProductCheckService Service = new ProductCheckService();
            if (Service.DeleteProductCheck(txt_ProdCode.Text, txt_CheckType.Text))
            {
                vo.Prod_Code = txt_ProdCode.Text;
                vo.Check_Type = txt_CheckType.Text;

                this.DialogResult = DialogResult.No;
                this.Close();
            }
        }
        #endregion

        private void ProductCheckInfoPopUp_Load(object sender, EventArgs e)
        {
            lbl_Title.Text = "검사기준정보 등록";
        }
    }
}
