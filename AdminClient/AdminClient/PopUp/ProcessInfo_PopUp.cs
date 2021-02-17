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
    public partial class ProcessInfo_PopUp : AdminClient.BaseForm.EmpFormTemp
    {
        public enum Mode { Insert, Update } // Insert : 등록, Update : 수정
        Mode mode;
        ProcessVO vo;
        string userID = Global.Global.employees.Emp_Code;
        

        public Mode ThisMode { set { mode = value; } }
        public ProcessVO VO { get { return vo; } set { vo = value; } }
        public ProcessInfo_PopUp()
        {
            InitializeComponent();

            #region 콤보박스 셋팅
            cbo_State.Items.Add("Y");
            cbo_State.Items.Add("N");

            cbo_State.SelectedIndex = 0;
            #endregion
        }

		private void ProcessPopUp_Load(object sender, EventArgs e)
		{
            if (mode == Mode.Insert) //등록모드
            {
                #region 기초 셋팅
                lbl_Title.Text = "공정등록";

                txt_PcsCode.Enabled = false;
                txt_PcsCode.Text = "자동입력";

                btn_Add.Enabled = true;
                btn_Delete.Enabled = btn_Update.Enabled = false;
                #endregion
            }
            else
            {
                lbl_Title.Text = "공정정보수정";

                txt_PcsCode.Enabled = false;
                txt_PcsCode.Text = vo.Pcs_Code;
                txt_PcsName.Text = vo.Pcs_Name;
                cbo_State.SelectedValue = vo.Pcs_State;
                
                btn_Add.Enabled = false;
                btn_Delete.Enabled = btn_Update.Enabled = true;
            }
        }

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
                vo = new ProcessVO
                {
                    Pcs_Name = txt_PcsName.Text,
                    Pcs_State = cbo_State.SelectedItem.ToString()
                };

                ProcessService service = new ProcessService();
                if (service.AddProcess(userID, vo))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("공정정보 등록중 오류가 발생했습니다. 다시 시도하여 주십시오.");
                    return;
                }
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            vo = new ProcessVO
            {
                Pcs_Code = txt_PcsCode.Text,
                Pcs_Name = txt_PcsName.Text,
                Pcs_State = cbo_State.SelectedItem.ToString()
            };

            ProcessService service = new ProcessService();
            if (service.UpdateProcess(userID, vo))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("공정정보 수정중 오류가 발생했습니다. 다시 시도하여 주십시오.");
                return;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string code = txt_PcsCode.Text;

            if (MessageBox.Show("정말로 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ProcessService service = new ProcessService();
                if (service.DeleteProcess(userID, code))
                {
                    MessageBox.Show("삭제가 성공적으로 완료되었습니다.");
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("공정정보 삭제중 오류가 발생했습니다. 다시 시도하여 주십시오.");
                    return;
                }
            }
        }

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
