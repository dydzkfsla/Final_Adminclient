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
    public partial class FacilityGroupPopUp : AdminClient.BaseForm.EmpFormTemp
    {
        public enum Mode { Insert, Update } // Insert : 등록, Update : 수정
        Mode mode;
        FacilityGroupVO vo;
        string userID = Global.Global.employees.Emp_Code;

		public FacilityGroupVO VO { get { return vo; } set { vo = value; } }
		public Mode ThisMode { set { mode = value; } }

		public FacilityGroupPopUp()
        {
            InitializeComponent();
		}

		private void FacilityGroupPopUp_Load(object sender, EventArgs e)
		{
            #region 기초 셋팅
            if (mode == Mode.Insert)
            {
                txt_FgrpCode.Enabled = cbo_FgrpEnable.Enabled = false;
                txt_FgrpCode.Text = "자동입력";

                cbo_FgrpEnable.Items.Add("Y");
                cbo_FgrpEnable.Items.Add("N");
                cbo_FgrpEnable.SelectedIndex = 0;

                FacilityService service = new FacilityService();

            }
			else
			{
                lbl_Title.Text = "설비군 수정";
                txt_FgrpCode.Enabled = false;
                txt_FgrpCode.Text = "자동입력";

                cbo_FgrpEnable.Items.Add("Y");
                cbo_FgrpEnable.Items.Add("N");
                cbo_FgrpEnable.SelectedIndex = 0;

                txt_FgrpCode.Text = VO.FacGrp_Code;
                txt_FgrpName.Text = VO.FacGrp_Name;
                txt_FgrpDescrip.Text = VO.FacGrp_Description;
            }

			#endregion

		}

        #region 이벤트

        private void btn_Save_Click(object sender, EventArgs e)
        {


        }

        #endregion
    }
}
