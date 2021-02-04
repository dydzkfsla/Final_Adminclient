using AdminClient.PopUp;
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
		public ContractInfo()
		{
			InitializeComponent();
		}

		private void ContractInfo_Load(object sender, EventArgs e)
		{
			#region 기초셋팅
			nu_limit.Enabled = false;
			gb_detail.Enabled = false;
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
			cbo_ContractConfirm.Items.Add("전체");
			cbo_ContractConfirm.Items.Add("Y");
			cbo_ContractConfirm.Items.Add("N");
			cbo_ContractFinish.Items.Add("전체");
			cbo_ContractFinish.Items.Add("Y");
			cbo_ContractFinish.Items.Add("N");
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

		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			ContractPopUp pop = new ContractPopUp();
			pop.ThisMode = ContractPopUp.Mode.Insert;
			pop.StartPosition = FormStartPosition.CenterParent;
			ContractVO vo;

			if(pop.ShowDialog() == DialogResult.OK)
			{
				MessageBox.Show("성공적으로 등록되었습니다.");
				vo = pop.VO;
			}
		}


		#endregion

		private void searchControl1_Load(object sender, EventArgs e)
		{

		}

		
	}
}
