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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminClient.Forms
{
	public partial class ContractInfo : AdminClient.BaseForm.FormSerchListTemp
	{
		string userID = Global.Global.employees.Emp_Code;
		List<ComboCompNameVO> compList;
		List<ComboDestVO> destList;
		List<ContractVO> ContList;
		//ContractVO selectedCont;

		public ContractInfo()
		{
			InitializeComponent();
		}

		private void ContractInfo_Load(object sender, EventArgs e)
		{
			#region 기초셋팅
			nu_limit.Enabled = false;
			gb_detail.Enabled = false;
			dtp_DueDateFrom.Value = DateTime.Now;
			dtp_DueDateTo.Value = dtp_DueDateFrom.Value.AddDays(7);
			#endregion

			#region 데이터그리드뷰 셋팅
			dgv_ContractList.SetGridColumn();
			CommonUtil.AddGridTextColumn(dgv_ContractList, "수주코드", "Contract_Code");
			CommonUtil.AddGridTextColumn(dgv_ContractList, "고객사코드", "Comp_Code");
			CommonUtil.AddGridTextColumn(dgv_ContractList, "고객사명", "Comp_Name");
			CommonUtil.AddGridTextColumn(dgv_ContractList, "도착지", "Contract_Destination");
			CommonUtil.AddGridTextColumn(dgv_ContractList, "품목코드", "Prod_Code");
			CommonUtil.AddGridTextColumn(dgv_ContractList, "품목명", "Prod_Name");
			CommonUtil.AddGridTextColumn(dgv_ContractList, "납기일", "Contract_DueDate");
			CommonUtil.AddGridTextColumn(dgv_ContractList, "주문수량", "Contract_Count");
			CommonUtil.AddGridTextColumn(dgv_ContractList, "출고수량", "Contract_ShippingCount");
			CommonUtil.AddGridTextColumn(dgv_ContractList, "취소수량", "Contract_CancelCount");
			CommonUtil.AddGridTextColumn(dgv_ContractList, "확정여부", "Contract_Confirm");
			CommonUtil.AddGridTextColumn(dgv_ContractList, "완료여부", "Contract_Finish");
			#endregion

			#region 콤보박스 셋팅
			ComboBindingService service = new ComboBindingService();
			compList = service.BindingCompNameForContract();
			destList = service.BindingDestName();
			service.Dispose();
			compList.Insert(0, new ComboCompNameVO { Comp_Name = "전체", Comp_Code = "" });
			destList.Insert(0, new ComboDestVO { Contract_Destination = "전체" });
			cbo_CompName.DataSource = compList;//고객사 바인딩
			cbo_CompName.DisplayMember = "Comp_Name";
			cbo_CompName.ValueMember = "Comp_Code";
			cbo_Destination.DataSource = destList;//도착지 바인딩
			cbo_Destination.DisplayMember = "Contract_Destination";
			cbo_Destination.ValueMember = "Contract_Destination";

			cbo_ContractConfirm.Items.Add("전체");
			cbo_ContractConfirm.Items.Add("Y");
			cbo_ContractConfirm.Items.Add("N");
			cbo_ContractFinish.Items.Add("전체");
			cbo_ContractFinish.Items.Add("Y");
			cbo_ContractFinish.Items.Add("N");

			cbo_CompName.SelectedIndex = cbo_Destination.SelectedIndex = cbo_ContractConfirm.SelectedIndex = cbo_ContractFinish.SelectedIndex = 0;
			#endregion
		}

		#region 이벤트

		private void chk_limit_CheckedChanged(object sender, EventArgs e)
		{
			nu_limit.Enabled = chk_limit.Checked;

			if (!chk_limit.Checked)
			{
				nu_limit.Value = 0;
			}
		}

		private void btn_search_Click(object sender, EventArgs e)
		{
			string limit, confirm, finish, comp, dest;
			limit = confirm = finish = comp = dest = string.Empty;
			string fDate = dtp_DueDateFrom.Value.Date.ToString("yyyy-MM-dd");
			string tDate = dtp_DueDateTo.Value.Date.ToString("yyyy-MM-dd");

			if (chk_limit.Checked)
				limit = nu_limit.Value.ToString();

			if (cbo_ContractConfirm.SelectedIndex > 0)
			{
				confirm = cbo_ContractConfirm.SelectedItem.ToString();
			}

			if (cbo_ContractFinish.SelectedIndex > 0)
			{
				finish = cbo_ContractFinish.SelectedItem.ToString();
			}

			if (cbo_CompName.SelectedIndex > 0)
			{
				comp = cbo_CompName.SelectedValue.ToString();
			}

			if (cbo_Destination.SelectedIndex > 0)
			{
				dest = cbo_Destination.SelectedItem.ToString();
			}

			ContractService service = new ContractService();
			ContList = service.GetContractsList(limit, confirm, finish, fDate, tDate, comp, dest);
			service.Dispose();

			dgv_ContractList.DataSource = ContList;

			if (ContList != null && ContList.Count > 0)
			{
				searchControl1.Getdata(dgv_ContractList);
				sortControl1.Getdata(dgv_ContractList);
				gb_detail.Enabled = true;
			}

		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			ContractPopUp pop = new ContractPopUp();
			pop.ThisMode = ContractPopUp.Mode.Insert;
			pop.StartPosition = FormStartPosition.CenterParent;
			ContractVO vo;

			if (pop.ShowDialog() == DialogResult.OK)
			{
				MessageBox.Show("성공적으로 등록되었습니다.");
				vo = pop.VO;
				RefreshList();
			}
		}

		private void dgv_ContractList_CellContentClick(object sender, DataGridViewCellEventArgs e) //수정버튼
		{
			if (e.RowIndex < 0)
				return;

			if (e.ColumnIndex == 1)
			{
				ContractVO vo = new ContractVO
				{
					Contract_Code = dgv_ContractList["Contract_Code", e.RowIndex].Value.ToString(),
					Comp_Code = dgv_ContractList["Comp_Code", e.RowIndex].Value.ToString(),
					Contract_Destination = dgv_ContractList["Contract_Destination", e.RowIndex].Value.ToString(),
					Contract_DueDate = Convert.ToDateTime(dgv_ContractList["Contract_DueDate", e.RowIndex].Value),
					Prod_Code = dgv_ContractList["Prod_Code", e.RowIndex].Value.ToString(),
					Contract_Count = Convert.ToInt32(dgv_ContractList["Contract_Count", e.RowIndex].Value),
					Contract_CancelCount = Convert.ToInt32(dgv_ContractList["Contract_CancelCount", e.RowIndex].Value)
				};

				ContractPopUp pop = new ContractPopUp();
				pop.ThisMode = ContractPopUp.Mode.Update;
				pop.VO = vo;
				pop.StartPosition = FormStartPosition.CenterParent;

				if (pop.ShowDialog() == DialogResult.OK)
				{
					MessageBox.Show("수정이 성공적으로 완료되었습니다.");
					RefreshList();
				}
			}
		}

		private void btn_CreateProduction_Click(object sender, EventArgs e) //생산계획 생성버튼
		{
			DataGridViewRow row = dgv_ContractList.CurrentRow;
			if (dgv_ContractList["Contract_Confirm", row.Index].Value.ToString() == "Y")
			{
                MessageBox.Show("이미 확정된 수주입니다.");
				return;
            }

			string contCode = dgv_ContractList["Contract_Code", row.Index].Value.ToString();
			

			ContractService service = new ContractService();
			if (service.CreateProduction(userID, contCode))
			{
				MessageBox.Show("수주 확정이 완료되었습니다.");
				RefreshList();
			}
			else
			{
				MessageBox.Show("생산계획 생성중 오류가 발생했습니다. 다시 시도하여 주십시오.");
				return;
			}
		}

		#endregion

		#region 메서드

		public void RefreshList() //수주목록 새로고침을 위한 메서드
		{
			ContractService service = new ContractService();
			ContList = service.RefreshContractsList();
			service.Dispose();

			dgv_ContractList.DataSource = ContList;
		}

		#endregion


	}
}
