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

namespace AdminClient.Forms
{
    public partial class ProductInfo : AdminClient.BaseForm.FormSerchListTemp
    {
        List<ProductVO> pdList;
        List<ComboProductVO> cbolist;
        public ProductInfo()
        {
            InitializeComponent();
        }

        private void ProductInfo_Load(object sender, EventArgs e)
        {
            #region 초기세팅
            nu_limit.Enabled = false;

            #region 콤보박스 바인딩
            ProductService service = new ProductService();
            cbolist = service.GetComboBindingList();

            cbolist.Insert(0, new ComboProductVO { Common_Code = "", Common_Name = "전체", Prod_State = "전체", Prod_Unit = "전체" });

            var commList = (from item in cbolist
                            group item by new { item.Common_Code, item.Common_Name } into grp
                            select new
                            {
                                CommCode = grp.Key.Common_Code, 
                                CommName = grp.Key.Common_Name
                            }).ToList();

            cbo_Category.DataSource = commList;
            cbo_Category.ValueMember = "CommCode";
            cbo_Category.DisplayMember = "CommName";

            var unitList = (from item in cbolist
                            group item by new { item.Prod_Unit } into grp
                            select new { Unit = grp.Key.Prod_Unit }).ToList();

            cbo_Unit.DataSource = unitList;
            cbo_Unit.ValueMember = "Unit";
            cbo_Unit.DisplayMember = "Unit";

            var stateList = (from item in cbolist
                             group item by new { item.Prod_State } into grp
                             select new { State = grp.Key.Prod_State}).ToList();

            cbo_State.DataSource = stateList;
            cbo_State.ValueMember = "State";
            cbo_State.DisplayMember = "State";
            #endregion


            #endregion
        }

        private void chk_limit_CheckedChanged(object sender, EventArgs e)
        {
            nu_limit.Enabled = chk_limit.Checked;
        }

        private void button1_Click(object sender, EventArgs e) // search
        {
            string cate, unit, state, limit;
            cate = unit = state = limit = string.Empty;

            //유효성
            if (chk_limit.Checked)
                limit = nu_limit.Value.ToString();

            if (cbo_Category.SelectedIndex > 0)
                cate = cbo_Category.SelectedValue.ToString();

            if (cbo_State.SelectedIndex > 0)
                state = cbo_State.SelectedValue.ToString();

            if (cbo_Unit.SelectedIndex > 0)
                unit = cbo_Unit.SelectedValue.ToString();

            ProductService service = new ProductService();
            pdList = service.GetProdList(cate, unit, state, limit);

            dgv_ProdList.DataSource = pdList;

        }

        private void dgv_ProdList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                txt_Code.Enabled = false;

                txt_Code.Text = dgv_ProdList["Prod_Code", e.RowIndex].Value.ToString();
                txt_Cate.Text = dgv_ProdList["Prod_Category", e.RowIndex].Value.ToString();
                txt_Name.Text = dgv_ProdList["Prod_Name", e.RowIndex].Value.ToString();
                txt_Wh.Text = dgv_ProdList["Prod_WhCode", e.RowIndex].Value.ToString();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Code.Enabled = true;
            txt_Code.Text = txt_Cate.Text = txt_Name.Text = txt_Wh.Text = "";
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if(txt_Code.Enabled)
            {
                if(txt_Cate.Text.Length < 1 || txt_Name.Text.Length < 1 || txt_Wh.Text.Length < 1)
                {
                    MessageBox.Show("이름과 구분, 창고는 필수 입력사항입니다.");
                    return;
                }

                string code, name, cate, wh;
                code = txt_Code.Text;
                name = txt_Name.Text;
                cate = txt_Cate.Text;
                wh = txt_Wh.Text;

                ProductService service = new ProductService();
                bool result = service.UpdateProduct(code, name, cate, wh);

                if(result)
                {
                    MessageBox.Show("수정에 성공하였습니다.");

                    pdList.ForEach(item =>
                    {
                        if (item.Prod_Code == code)
                        {
                            item.Prod_Category = cate;
                            item.Prod_Name = name;
                            item.Prod_WhCode = wh;
                        }
                    });

                    dgv_ProdList.DataSource = null;
                    dgv_ProdList.DataSource = pdList;

                    btn_Clear.PerformClick();

                }
                else
                    MessageBox.Show("수정중 오류가 발생했습니다.");
            }
            else
                MessageBox.Show("목록중 선택해주세요");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(!txt_Code.Enabled)
            {
                if (txt_Code.Text.Length < 1 || txt_Cate.Text.Length < 1 || txt_Name.Text.Length < 1 || txt_Wh.Text.Length < 1)
                {
                    MessageBox.Show("모든 정보를 입력해 주세요");
                    return;
                }

                
            }
            else
            {
                if(MessageBox.Show("선택한 목록이 있을 경우 등록작업을 실행할 수 없습니다. 등록모드로 변경하시겠습니까?", "확인메세지", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    txt_Code.Enabled = true;
                    txt_Code.Text = "";
                }
            }
                
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(!txt_Code.Enabled)
            {
                string code = txt_Code.Text;

                ProductService service = new ProductService();
                bool result = service.DeleteProduct(code);


            }
        }
    }
}
