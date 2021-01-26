using AdminClient.PopUp;
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
    public partial class CompanyInfo : AdminClient.BaseForm.FormSerchListThreeSplitTemp
    {
        //List<(string name, string text)> temp = new List<(string name, string text)>();
        List<ComboCompVO> cbolist;
        List<CompanyVO> compList;
        List<CompanyDetailVO> detailList;

        public CompanyInfo()
        {
            InitializeComponent();
        }

        private void CompanyInfo_Load(object sender, EventArgs e)
        {
            #region 기초세팅

            //키입력 불가
            txt_Code.KeyPress += TextNoneKeyPress;
            txt_Name.KeyPress += TextNoneKeyPress;
            txt_CEO.KeyPress += TextNoneKeyPress;
            txt_Type.KeyPress += TextNoneKeyPress;

            #region 콤보박스 바인딩
            CompanyService service = new CompanyService();
            cbolist = service.GetComboBindingList();

            cbolist.Insert(0, new ComboCompVO { Common_Name = "전체", Comp_Type = "none" });

            cbo_Auto.Items.Add("전체");
            cbo_Auto.Items.Add("Y");
            cbo_Auto.Items.Add("N");
            cbo_State.Items.Add("전체");
            cbo_State.Items.Add("Y");
            cbo_State.Items.Add("N");

            cbo_Auto.SelectedIndex = cbo_State.SelectedIndex = 0;


            cbo_Type.DataSource = cbolist;

            cbo_Type.DisplayMember = "Common_Name";
            cbo_Type.ValueMember = "Comp_Type";
            #endregion

            #region dgv 세팅
            dgv_CompList.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_CompList, "Code", "Comp_Code", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_CompList, "회사명", "Comp_Name");
            CommonUtil.AddGridTextColumn(dgv_CompList, "대표명", "Comp_CEO");
            CommonUtil.AddGridTextColumn(dgv_CompList, "업종", "Common_Name");
            CommonUtil.AddGridTextColumn(dgv_CompList, "자동출하", "Comp_Auto");
            CommonUtil.AddGridTextColumn(dgv_CompList, "상태", "Comp_State");
            CommonUtil.AddGridTextColumn(dgv_CompList, "Type", "Comp_Type", visibility: false);

            dgv_detail.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_detail, "Code", "Comp_Code", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_detail, "ProdCode", "Prod_Code");
            CommonUtil.AddGridTextColumn(dgv_detail, "물품명", "Prod_Name");
            CommonUtil.AddGridTextColumn(dgv_detail, "거래단위", "Prod_UnitCount");
            CommonUtil.AddGridTextColumn(dgv_detail, "단위", "Prod_Unit");
            CommonUtil.AddGridTextColumn(dgv_detail, "단위당가격", "Prod_UnitPrice", 150);
            CommonUtil.AddGridTextColumn(dgv_detail, "이전가격", "Prod_OldUnitPrice");
            CommonUtil.AddGridTextColumn(dgv_detail, "시작일", "Comp_StartDate");
            CommonUtil.AddGridTextColumn(dgv_detail, "만료일", "Comp_EndDate");
            CommonUtil.AddGridTextColumn(dgv_detail, "상태", "Item_State");
            CommonUtil.AddGridTextColumn(dgv_detail, "구분", "Comp_Div");


            #endregion

            nu_limit.Enabled = false;
            gb_detail.Enabled = false;

            #endregion


        }

        private void TextNoneKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void chk_limit_CheckedChanged(object sender, EventArgs e)
        {
            nu_limit.Enabled = chk_limit.Checked;
        }

        private void button1_Click(object sender, EventArgs e) // search
        {
            string auto, state, type, limit;
            auto = state = type = limit = string.Empty;

            if (cbo_Auto.SelectedIndex > 0)
                auto = cbo_Auto.SelectedItem.ToString();

            if (cbo_State.SelectedIndex > 0)
                state = cbo_State.SelectedItem.ToString();

            if (cbo_Type.SelectedIndex > 0)
                type = cbo_Type.SelectedValue.ToString();

            if (chk_limit.Checked)
                limit = nu_limit.Value.ToString();

            CompanyService service = new CompanyService();
            compList = service.GetCompanyList(limit, auto, state, type);

            dgv_CompList.DataSource = compList;

            if(compList != null && compList.Count > 0)
            {
                schCtrl.Getdata(dgv_CompList);
                gb_detail.Enabled = true;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            CompanyPopUp pop = new CompanyPopUp();
            pop.ThisMode = CompanyPopUp.Mode.New;
            pop.StartPosition = FormStartPosition.CenterParent;
            CompanyVO vo = null;

            if(pop.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("추가에 성공하였습니다.");
                vo = pop.VO;
            }

            if(compList.Count > 0)
            {
                compList.Add(vo);

                dgv_CompList.DataSource = null;
                dgv_CompList.DataSource = compList;

            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if(txt_Code.Text.Length < 1)
            {
                MessageBox.Show("수정할 목록을 선택해주세요");
                return;
            }

            string code = txt_Code.Text;

            CompanyPopUp pop = new CompanyPopUp();
            pop.ThisMode = CompanyPopUp.Mode.Old;
            pop.StartPosition = FormStartPosition.CenterParent;
            CompanyVO vo = null;

            compList.ForEach((comp) =>
            {
                if (comp.Comp_Code == code)
                {
                    vo = comp;
                }
            });

            pop.VO = vo; // 기존정보 전달

            if(pop.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("수정에 성공했습니다.");
                vo = pop.VO; // 바뀐정보 받아옴
            }

            compList.ForEach((comp) =>
            {
                if (comp.Comp_Code == code)
                {
                    comp = vo;
                }
            });

            dgv_CompList.DataSource = null;
            dgv_CompList.DataSource = compList;

        }

        private void dgv_CompList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_CEO.Text = txt_Code.Text = txt_Name.Text = txt_Type.Text = string.Empty;

            if(e.RowIndex > -1)
            {
                txt_Code.Text = dgv_CompList["Comp_Code", e.RowIndex].Value.ToString();
                txt_Name.Text = dgv_CompList["Comp_Name", e.RowIndex].Value.ToString();
                txt_Type.Text = dgv_CompList["Common_Name", e.RowIndex].Value.ToString();

                if(dgv_CompList["Comp_CEO", e.RowIndex].Value != null)
                    txt_CEO.Text = dgv_CompList["Comp_CEO", e.RowIndex].Value.ToString();

                CompanyService service = new CompanyService();
                detailList = service.GetDetailInfo(txt_Code.Text);

                dgv_detail.DataSource = detailList;

            }
        }
    }
}
