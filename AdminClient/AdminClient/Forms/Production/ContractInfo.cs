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
			splitContainer1.SplitterDistance = 365;
			nu_limit.Enabled = false;
			gb_detail.Enabled = false;
			dtp_DueDateFrom.Value = DateTime.Now;
			dtp_DueDateTo.Value = dtp_DueDateFrom.Value.AddDays(14);
			#endregion

			#region 데이터그리드뷰 셋팅
			dgv_ContractList.SetGridColumn();
			CommonUtil.AddGridTextColumn(dgv_ContractList, "수주코드", "Contract_Code", 200);
			CommonUtil.AddGridTextColumn(dgv_ContractList, "고객사코드", "Comp_Code", 103);
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
			ContractInfoPopUp pop = new ContractInfoPopUp();
			pop.ThisMode = ContractInfoPopUp.Mode.Insert;
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

				ContractInfoPopUp pop = new ContractInfoPopUp();
				pop.ThisMode = ContractInfoPopUp.Mode.Update;
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
			string contDate = dgv_ContractList["Contract_DueDate", row.Index].Value.ToString();

			ContractService service = new ContractService();
			if (service.CreateProduction(userID, contCode, contDate))
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

        private void btn_Xls_Click(object sender, EventArgs e)
        {
			SaveFileDialog dlg = new SaveFileDialog();
			CommonExcel excel = new CommonExcel();
			excel.Cursor = this.Cursor;
			dlg.Filter = "Excel File(*.xls)|*.xls";
			dlg.Title = "엑셀파일로 내보내기";
			if (dlg.ShowDialog() != DialogResult.OK)
				return;
			DataTable dt = null;

			if (dgv_ContractList.DataSource is List<ContractVO>)
			{
				dt = ((List<ContractVO>)dgv_ContractList.DataSource).ConvertToDataTable();
			}

			if (dt != null)
			{
				dt.TableName = this.Name;
				string toltip = $@"Contract_Code: 수주코드
                            {System.Environment.NewLine}Comp_Name : 업체명
                            {System.Environment.NewLine}Comp_Code : 업체코드
                            {System.Environment.NewLine}Contract_Destination : 도착지
                            {System.Environment.NewLine}Contract_DueDate : 납기일
                            {System.Environment.NewLine}Contract_Confirm : 수주확정여부
                            {System.Environment.NewLine}Contract_Finish : 수주완료여부
                            {System.Environment.NewLine}Contract_Note : 수주메모
                            {System.Environment.NewLine}Prod_Code : 품목코드
                            {System.Environment.NewLine}Prod_Name : 품목명
                            {System.Environment.NewLine}Contract_Count : 수주갯수
                            {System.Environment.NewLine}Contract_ShippingCount : 배송갯수
                            {System.Environment.NewLine}Contract_CancelCount : 취소갯수
                            {System.Environment.NewLine}Fst_Writer : 첫작성자
                            {System.Environment.NewLine}Fst_WriteDate : 첫작성일자
                            {System.Environment.NewLine}Lst_Writer : 마지막수정자
                            {System.Environment.NewLine}Lst_WriteDate : 마지막수정일자";
				if (excel.ExportDataToExcel(dt, dlg.FileName, toltip))
				{
					MessageBox.Show("엑셀파일에 저장하였습니다.");
				}
			}

		}
    }
}
