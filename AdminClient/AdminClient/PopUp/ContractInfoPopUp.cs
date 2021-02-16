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
	public partial class ContractInfoPopUp : AdminClient.BaseForm.EmpFormTemp
	{
		public enum Mode { Insert, Update } // Insert : 등록, Update : 수정
		Mode mode;
		ContractVO vo;
		string userID = Global.Global.employees.Emp_Code;
		List<ComboCompNameVO> compNameList;
		List<ComboProdNameVO> prodNameList;

		public Mode ThisMode { set { mode = value; } }
		public ContractVO VO { get { return vo; } set { vo = value; } }

		public ContractInfoPopUp()
		{
			InitializeComponent();

			#region 기본 콤보박스 셋팅
			ComboBindingService service = new ComboBindingService();
			compNameList = service.BindingCompName();
			prodNameList = service.BindingProdName();
			service.Dispose();

			compNameList.Insert(0, new ComboCompNameVO { Comp_Name = "선택", Comp_Code = "" });
			prodNameList.Insert(0, new ComboProdNameVO { Prod_Name = "선택", Prod_Code = "" });
			cbo_CompName.DataSource = compNameList; //회사이름 바인딩
			cbo_CompName.DisplayMember = "Comp_Name";
			cbo_CompName.ValueMember = "Comp_Code";
			cbo_ProdName.DataSource = prodNameList; //품목이름 바인딩
			cbo_ProdName.DisplayMember = "Prod_Name";
			cbo_ProdName.ValueMember = "Prod_Code";
			#endregion
		}

		#region 이벤트
		private void ContractPopUp_Load(object sender, EventArgs e) //로드 이벤트
		{
			if (mode == Mode.Insert) //등록모드
			{
				#region 기초 셋팅
				lbl_Title.Text = "수주등록";

				txt_ContCode.Enabled = false;
				txt_ContCode.Text = "자동입력";

				dtp_DueDate.Value = DateTime.Now;

				txt_ContCount.KeyPress += UtilEvent.TextBoxIsDigit;

				lbl_ContCancelCount.Visible = txt_ContCancelCount.Visible = lbl_ContCancelCountMark.Visible = false;
				btn_Add.Enabled = true;
				btn_Delete.Enabled = btn_Update.Enabled = false;
				#endregion
			}
			else
			{
				lbl_Title.Text = "수주정보수정";
				txt_ContCode.Enabled = false;
				txt_ContCode.Text = vo.Contract_Code;
				cbo_CompName.SelectedValue = vo.Comp_Code;
				txt_ContDestination.Text = vo.Contract_Destination;
				dtp_DueDate.Value = vo.Contract_DueDate;
				cbo_ProdName.SelectedValue = vo.Prod_Code;
				txt_ContCount.Text = vo.Contract_Count.ToString();
				txt_ContCancelCount.Text = vo.Contract_CancelCount.ToString();

				btn_Add.Enabled = false;
				btn_Delete.Enabled = btn_Update.Enabled = true;
			}
		}

		private void btn_Save_Click(object sender, EventArgs e) //추가 버튼
		{
			//유효성체크
			if (!ChkTextBox())
			{
				MessageBox.Show("노란색 항목은 필수입력 입니다.");
				return;
			}

			if (mode == Mode.Insert)
			{
				vo = new ContractVO
				{
					Comp_Code = cbo_CompName.SelectedValue.ToString(),
					Contract_Destination = txt_ContDestination.Text,
					Contract_DueDate = Convert.ToDateTime(dtp_DueDate.Value.ToString("yyyy-MM-dd")),
					Contract_Note = txt_ContNote.Text,
					Prod_Code = cbo_ProdName.SelectedValue.ToString(),
					Contract_Count = Convert.ToInt32(txt_ContCount.Text)
				};

				ContractService service = new ContractService();
				if (service.AddContract(userID, vo))
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

		private void btn_Update_Click(object sender, EventArgs e) //수정버튼
		{
			vo = new ContractVO
			{
				Contract_Code = txt_ContCode.Text,
				Comp_Code = cbo_CompName.SelectedValue.ToString(),
				Contract_Destination = txt_ContDestination.Text,
				Contract_DueDate = Convert.ToDateTime(dtp_DueDate.Value.ToString("yyyy-MM-dd")),
				Prod_Code = cbo_ProdName.SelectedValue.ToString(),
				Contract_Count = Convert.ToInt32(txt_ContCount.Text),
				Contract_CancelCount = Convert.ToInt32(txt_ContCancelCount.Text),
				Contract_Note = txt_ContNote.Text
			};

			ContractService service = new ContractService();
			if (service.UpdateContract(userID, vo))
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("수주정보 수정중 오류가 발생했습니다. 다시 시도하여 주십시오.");
				return;
			}
		}

		private void btn_Delete_Click(object sender, EventArgs e) //삭제버튼
		{
			string contCode = txt_ContCode.Text;
			string prodCode = cbo_ProdName.SelectedValue.ToString();

			if (MessageBox.Show("정말로 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				ContractService service = new ContractService();
				if (service.DeleteContract(contCode, prodCode))
				{
					MessageBox.Show("삭제가 성공적으로 완료되었습니다.");
					this.Close();
				}
				else
				{
					MessageBox.Show("수주정보 삭제중 오류가 발생했습니다. 다시 시도하여 주십시오.");
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
