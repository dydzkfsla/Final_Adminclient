using AdminClient.Service;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdminClient.PopUp
{
    public partial class ProductInfoPopUp : AdminClient.BaseForm.EmpFormTemp
    {
        public enum Mode { New, Old }  // New : 등록모드(등록버튼만 활성화), Old : 수정모드(수정, 삭제버튼만 활성화)
        Mode mode;
        ProductVO vo;
        List<ComboProductVO> cbolist;
        List<WareHouseVO> whlist;

        public ProductVO VO { get { return vo; } set { vo = value; } }
        public Mode ThisMode { set { mode = value; } }
        public List<ComboProductVO> CombVO { set { cbolist = value; } }

        public ProductInfoPopUp()
        {
            InitializeComponent();
        }

        private void ProductPopUp_Load(object sender, EventArgs e)
        {
            txt_Code.KeyPress += NoneKeyPress; // 키입력불가
            txt_Safety.KeyPress += UtilEvent.TextBoxIsDigitAndOneDot; //숫자, 백스페이스 입력가능 . (점) 은 한개만

            var commList = (from item in cbolist
                            group item by new { item.Common_Code, item.Common_Name } into grp
                            select new
                            {
                                CommCode = grp.Key.Common_Code,
                                CommName = grp.Key.Common_Name
                            }).ToList();

            commList.RemoveAt(0);
            cbo_Cate.DataSource = commList;
            cbo_Cate.ValueMember = "CommCode";
            cbo_Cate.DisplayMember = "CommName";

            cbo_State.Items.Add("Y");
            cbo_State.Items.Add("N");
            cbo_State.SelectedIndex = 0;

            WareHouseService service = new WareHouseService();
            whlist = service.GetWareHouseList(null, null, null);

            //whlist.RemoveAt(0);
            cbo_WH.DataSource = whlist;
            cbo_WH.DisplayMember = "WH_Code";
            cbo_WH.ValueMember = "WH_Code";

            if (mode == Mode.Old)
            {
                lbl_Title.Text = "품목정보 수정";
                btn_Add.Enabled = false;
                txt_Code.Text = vo.Prod_Code;
                txt_Name.Text = vo.Prod_Name;
                txt_Safety.Text = vo.Prod_SafetyStock.ToString();
                txt_Unit.Text = vo.Prod_Unit;

                for (int i = 0; i < cbo_WH.Items.Count; i++)
                {
                    cbo_WH.SelectedIndex = i;
                    if (cbo_WH.Text == vo.Prod_WhCode)
                        break;
                }

                for (int i = 0; i < cbo_Cate.Items.Count; i++)
                {
                    cbo_Cate.SelectedIndex = i;
                    if (cbo_Cate.SelectedValue.ToString() == vo.Prod_Category)
                        break;
                }

                if (vo.Prod_State == "Y")
                    cbo_State.SelectedIndex = 0;
                else
                    cbo_State.SelectedIndex = 1;
            }
            else
            {
                lbl_Title.Text = "신규 품목 등록";
                btn_Update.Enabled = btn_Delete.Enabled = false;
                txt_Code.Text = "자동입력";
            }

        }

        private void NoneKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_Safety.Text.Trim().Length < 1)
                txt_Safety.Text = "0";

            vo = new ProductVO
            {
                Prod_Code = txt_Code.Text,
                Prod_Name = txt_Name.Text,
                Prod_Category = cbo_Cate.SelectedValue.ToString(),
                Prod_State = cbo_State.SelectedItem.ToString(),
                Prod_SafetyStock = decimal.Parse(txt_Safety.Text),
                Prod_WhCode = cbo_WH.SelectedValue.ToString(),
                Common_Name = cbo_Cate.Text,
                Prod_Unit = txt_Unit.Text
            };

            ProductService service = new ProductService();
            bool result = service.UpdateProduct(vo);

            if(result)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("수정중 오류 발생");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text.Trim().Length < 1)
                return;

            ProductService service = new ProductService();
            bool result = service.DeleteProduct(txt_Code.Text);

            if(result)
            {
                this.DialogResult = DialogResult.None;
                this.Close();
            }
            else
                MessageBox.Show("삭제중 오류 발생");
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_Safety.Text.Trim().Length < 1)
                txt_Safety.Text = "0";

            if(txt_Name.Text.Trim().Length < 1 || txt_Unit.Text.Trim().Length < 1)
            {
                MessageBox.Show("주황색 표시는 필수 입력 정보입니다.");
                return;
            }

            vo = new ProductVO
            {
                Prod_Name = txt_Name.Text,
                Prod_Category = cbo_Cate.SelectedValue.ToString(),
                Prod_State = cbo_State.SelectedItem.ToString(),
                Prod_SafetyStock = decimal.Parse(txt_Safety.Text),
                Prod_WhCode = cbo_WH.SelectedValue.ToString(),
                Common_Name = cbo_Cate.Text,
                Prod_Unit = txt_Unit.Text
            };

            ProductService service = new ProductService();
            string pdcode = service.AddProduct(vo);

            if (pdcode.Length > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("추가중 오류 발생");
        }
    }
}
