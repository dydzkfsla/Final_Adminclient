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
    public partial class ContractPopUp : AdminClient.BaseForm.EmpFormTemp
    {
        public enum Mode { Insert, Update } // Insert : 등록, Update : 수정
        Mode mode;
        ContractVO vo;
        string userID = Global.Global.employees.Emp_Code;
        List<ComboCompNameVO> compNameList;
        List<ComboProdNameVO> prodNameList;

        public Mode ThisMode { get; set; }
		public ContractVO VO { get { return vo; } set { vo = value; } }

		public ContractPopUp()
        {
            InitializeComponent();
        }

		#region 이벤트
		private void ContractPopUp_Load(object sender, EventArgs e) //로드 이벤트
		{
            if (mode == Mode.Insert) //등록모드
			{
                #region 기본 콤보박스 셋팅
                ComboBindingService service = new ComboBindingService();
                compNameList = service.BindingCompName();
                prodNameList = service.BindingProdName();
                service.Dispose();

                cbo_CompName.DataSource = compNameList; //회사이름 바인딩
                cbo_CompName.DisplayMember = "Comp_Name";
                cbo_CompName.ValueMember = "Comp_Code";
                cbo_ProdName.DataSource = prodNameList; //품목이름 바인딩
                cbo_ProdName.DisplayMember = "Prod_Name";
                cbo_ProdName.ValueMember = "Prod_Code";
				#endregion

				#region 기초 셋팅
				lbl_Title.Text = "수주등록";

                txt_ContCode.Enabled = false;
                txt_ContCode.Text = "자동입력";

                dtp_DueDate.Value = DateTime.Now;

				txt_ContCount.KeyPress += UtilEvent.TextBoxIsDigit;

                lbl_ContCancelCount.Visible = txt_ContCancelCount.Visible = lbl_ContCancelCountMark.Visible = false;
				#endregion
			}
		}

		private void btn_Save_Click(object sender, EventArgs e) //저장 버튼
		{
			//유효성체크
			if (!ChkTextBox())
			{
                MessageBox.Show("노란색 항목은 필수입력 입니다.");
                return;
			}

            if(mode == Mode.Insert)
			{
                vo = new ContractVO
                {
                    Comp_Code = cbo_CompName.ValueMember,
                    Contract_Destination = txt_ContDestination.Text,
                    Contract_DueDate = dtp_DueDate.Value.Date,
                    Contract_Note = txt_ContNote.Text,
                    Prod_Code = cbo_ProdName.ValueMember,
                    Contract_Count = Convert.ToInt32(txt_ContCount.Text)
                };

                ContractService service = new ContractService();
                if(service.AddContract(userID, vo))
				{
                    this.DialogResult = DialogResult.OK;
                    this.Close();
				}
				else
				{
                    MessageBox.Show("수주정보 등록중 오류가 발생했습니다. 다시 시도하여 주십시오.");
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
