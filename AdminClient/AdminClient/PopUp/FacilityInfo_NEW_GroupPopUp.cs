using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AdminClient.Service;
using AdminClientVO;

namespace AdminClient.PopUp
{
    public partial class FacilityInfo_NEW_GroupPopUp : AdminClient.BaseForm.EmpFormTemp
    {
        public enum Mode { Insert, Update } // Insert : 등록, Update : 수정
        Mode mode;
        FacilityGroupVO vo;

        string userID = Global.Global.employees.Emp_Code;

		public FacilityGroupVO VO { get { return vo; } set { vo = value; } }
		public Mode ThisMode { set { mode = value; } }

		public FacilityInfo_NEW_GroupPopUp()
        {
            InitializeComponent();
		}

		private void FacilityGroupPopUp_Load(object sender, EventArgs e)
		{
            #region 기초 셋팅
            if (mode == Mode.Insert)
            {
                lbl_Title.Text = "설비군 등록";

                txt_FgrpCode.Enabled = cbo_FgrpEnable.Enabled = false;
                txt_FgrpCode.Text = "자동입력";

                cbo_FgrpEnable.Items.Add("Y");
                cbo_FgrpEnable.Items.Add("N");
                cbo_FgrpEnable.SelectedIndex = 0;

                btn_Add.Enabled = true;
                btn_Delete.Enabled = btn_Update.Enabled = false;
            }
			else
			{
                lbl_Title.Text = "설비군 수정";
                txt_FgrpCode.Enabled = false;
                txt_FgrpCode.Text = vo.FacGrp_Code;
                txt_FgrpName.Text = vo.FacGrp_Name;

                cbo_FgrpEnable.Items.Add("Y");
                cbo_FgrpEnable.Items.Add("N");
                cbo_FgrpEnable.SelectedIndex = 0;
               
                txt_FgrpDescrip.Text = vo.FacGrp_Description;

                btn_Add.Enabled = false;
                btn_Delete.Enabled = btn_Update.Enabled = true;
            }

			#endregion

		}

        #region 이벤트
        private void btn_Add_Click(object sender, EventArgs e)
        {
            //유효성체크
            if (!ChkTextBox())
            {
                MessageBox.Show("노란색 항목은 필수입력 입니다.");
                return;
            }

            if (mode == Mode.Insert)
            {
                vo = new FacilityGroupVO
                {
                    FacGrp_Name = txt_FgrpName.Text,
                    FacGrp_Enable = cbo_FgrpEnable.SelectedItem.ToString(),
                    FacGrp_Description = txt_FgrpDescrip.Text
                };

                FacilityService service = new FacilityService();
                if (service.AddFacilityGroup(userID, vo))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("설비군 등록중 오류가 발생했습니다. 다시 시도하여 주십시오.");
                    return;
                }
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            vo = new FacilityGroupVO
            {
                FacGrp_Code = txt_FgrpCode.Text,
                FacGrp_Name = txt_FgrpName.Text,
                FacGrp_Enable = cbo_FgrpEnable.SelectedItem.ToString(),
                FacGrp_Description = txt_FgrpDescrip.Text
            };

            FacilityService service = new FacilityService();
            if (service.UpdateFacilityGroup(userID, vo))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("설비군정보 수정중 오류가 발생했습니다. 다시 시도하여 주십시오.");
                return;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string code = txt_FgrpCode.Text;

            if (MessageBox.Show("정말로 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FacilityService service = new FacilityService();
                if (service.DeleteFacilityGroup(userID, code))
                {
                    MessageBox.Show("삭제가 성공적으로 완료되었습니다.");
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("설비군정보 삭제중 오류가 발생했습니다. 다시 시도하여 주십시오.");
                    return;
                }
            }
        }
        #endregion

        #region 메서드

        #region 텍스트박스 유효성체크
        private bool ChkTextBox()
        {
            bool ChkTextBox = true;

            CommonUtil.ControlAction<Panel, TextBox>(panel1, (x) =>
            {
                if (string.IsNullOrWhiteSpace(x.Text.Trim()))
                {
                    ChkTextBox = false;
                }
            });
            return ChkTextBox;
        }

		#endregion

		#endregion

		
	}
}
