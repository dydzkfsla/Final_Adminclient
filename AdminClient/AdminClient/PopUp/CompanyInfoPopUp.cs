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
    public partial class CompanyInfoPopUp : AdminClient.BaseForm.EmpFormTemp
    {
        public enum Mode { New, Old}  // New : 등록모드(등록버튼만 활성화), Old : 수정모드(수정, 삭제버튼만 활성화)
        List<CompanyPopUpVO> typeList;
        Mode mode;
        CompanyVO vo;
        string userID = Global.Global.employees.Emp_Code;

        public Mode ThisMode { set { mode = value; } }

        public CompanyVO VO { get { return vo; } set { vo = value; } }

        public CompanyInfoPopUp()
        {
            InitializeComponent();
        }

        private void CompanyPopUp_Load(object sender, EventArgs e)
        {
            
            
            if (mode == Mode.New)
            {
                lbl_Title.Text = "업체정보등록";
                #region 등록 기초세팅
                btn_Update.Enabled = btn_Delete.Enabled = false;
                txt_Code.Text = "자동입력";
                txt_Code.KeyPress += Txt_Code_KeyPress;

                cbo_Auto.Items.Add("Y");
                cbo_Auto.Items.Add("N");
                cbo_State.Items.Add("Y");
                cbo_State.Items.Add("N");
                cbo_Auto.SelectedIndex = cbo_State.SelectedIndex = 0;

                CompanyService service = new CompanyService();
                typeList = service.GetCompanyTypeList_Popup();

                cbo_Type.DataSource = typeList;
                cbo_Type.DisplayMember = "Common_Name";
                cbo_Type.ValueMember = "Common_Code";
                #endregion
            }
            else
            {
                lbl_Title.Text = "업체정보수정";
                #region 수정 기초세팅

                CompanyService service = new CompanyService();
                typeList = service.GetCompanyTypeList_Popup();

                cbo_Type.DataSource = typeList;
                cbo_Type.DisplayMember = "Common_Name";
                cbo_Type.ValueMember = "Common_Code";

                cbo_Auto.Items.Add("Y");
                cbo_Auto.Items.Add("N");
                cbo_State.Items.Add("Y");
                cbo_State.Items.Add("N");

                txt_Code.KeyPress += Txt_Code_KeyPress;

                txt_Code.Text = vo.Comp_Code;
                txt_Name.Text = vo.Comp_Name;
                txt_CEO.Text = vo.Comp_CEO;

                //기존정보에 해당하는 값으로 콤보박스 인덱스 설정
                int index = 0;

                foreach(var idx in cbo_Auto.Items)
                {
                    if (idx.ToString() == vo.Comp_Auto)
                        break;

                    index += 1;
                }

                cbo_Auto.SelectedIndex = index;

                index = 0;

                foreach(var idx in cbo_State.Items)
                {
                    if (idx.ToString() == vo.Comp_State)
                        break;

                    index += 1;
                }

                cbo_State.SelectedIndex = index;

                index = 0;


                for(int i = 0; i<cbo_Type.Items.Count - 1; i++)
                {
                    cbo_Type.SelectedIndex = i;
                    if (cbo_Type.SelectedValue.ToString() == vo.Comp_Type)
                        break;
                }

                #endregion
                btn_Add.Enabled = false;
            }

        }

        private void Txt_Code_KeyPress(object sender, KeyPressEventArgs e)  // 키입력 불가
        {
            e.Handled = true;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            bool check = true;

            //유효성체크 (텍스트박스 길이 1미만일경우 x, 콤보박스는 값 무조건 들어가있기때문에 검사x)
            if (txt_Name.Text.Trim().Length < 1)
                check = false;

            

            if(check)
            {
                vo = new CompanyVO
                {
                    Comp_Auto = cbo_Auto.SelectedItem.ToString(),
                    Comp_Type = cbo_Type.SelectedValue.ToString(), 
                    Common_Name = cbo_Type.Text, 
                    Comp_Name = txt_Name.Text,
                    Comp_CEO = txt_CEO.Text,
                    Comp_State = cbo_State.SelectedItem.ToString()
                };


                CompanyService service = new CompanyService();
                string result = service.AddCompany(userID, vo);

                vo.Comp_Code = result;

                if(result != null)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("추가중 오류가 발생했습니다.");

            }
            else
                MessageBox.Show("주황색 표시는 필수 입력 사항입니다.");

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (txt_Name.Text.Trim().Length < 1)
                check = false;

            if(check)
            {
                vo = new CompanyVO
                {
                    Comp_Code = txt_Code.Text,
                    Comp_Name = txt_Name.Text,
                    Comp_Auto = cbo_Auto.SelectedItem.ToString(),
                    Comp_State = cbo_State.SelectedItem.ToString(),
                    Comp_Type = cbo_Type.SelectedValue.ToString(), 
                    Comp_CEO = txt_CEO.Text
                };

                CompanyService service = new CompanyService();
                bool result = service.UpdateCompany(userID, vo);

                if (result)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("수정중 오류가 발생했습니다.");
            }
            else
                MessageBox.Show("주황색 표시는 필수 입력 사항입니다.");
        }

        private void Form_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("회사 상태를 비활성화 시키겠습니까?", "삭제확인", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            CompanyService service = new CompanyService();
            bool result = service.CompInfoDel(txt_Code.Text);

            if(result)
            {
                this.DialogResult = DialogResult.None;
                this.Close();
            }
            else
                MessageBox.Show("비활성화 작업중 오류가 발생했습니다.");

        }
    }
}
