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
	public partial class ProductionPlan_NEW : AdminClient.BaseForm.FormSerchListSplitTemp
	{
		string userID = Global.Global.employees.Emp_Code;
		List<ContractVO> QtyList;
		List<ContractVO> ContList;

		public ProductionPlan_NEW()
		{
			InitializeComponent();
		}

		private void ProductionPlan_NEW_Load(object sender, EventArgs e)
		{
			splitContainer1.SplitterDistance = 365;
			splitContainer2.SplitterDistance = 300;
			#region 데이터그리드뷰 셋팅
			dgv_ProductionCount.SetGridColumn();
			CommonUtil.AddGridTextColumn(dgv_ProductionCount, "주문수량", "Contract_Count");
			CommonUtil.AddGridTextColumn(dgv_ProductionCount, "납기일", "Contract_DueDate");

			dgv_ConfirmedContract.SetGridColumn();
			CommonUtil.AddGridTextColumn(dgv_ConfirmedContract, "수주코드", "Contract_Code");
			CommonUtil.AddGridTextColumn(dgv_ConfirmedContract, "고객사코드", "Comp_Code", 150);
			CommonUtil.AddGridTextColumn(dgv_ConfirmedContract, "고객사명", "Comp_Name");
			CommonUtil.AddGridTextColumn(dgv_ConfirmedContract, "도착지", "Contract_Destination");
			CommonUtil.AddGridTextColumn(dgv_ConfirmedContract, "품목코드", "Prod_Code");
			CommonUtil.AddGridTextColumn(dgv_ConfirmedContract, "품목명", "Prod_Name");
			CommonUtil.AddGridTextColumn(dgv_ConfirmedContract, "납기일", "Contract_DueDate");
			CommonUtil.AddGridTextColumn(dgv_ConfirmedContract, "주문수량", "Contract_Count");
			CommonUtil.AddGridTextColumn(dgv_ConfirmedContract, "출고수량", "Contract_ShippingCount");
			CommonUtil.AddGridTextColumn(dgv_ConfirmedContract, "취소수량", "Contract_CancelCount");

			CommonUtil.AddGridTextColumn(dgv_Plan, "설비코드", "Fac_Code");
			CommonUtil.AddGridTextColumn(dgv_Plan, "설비명", "Fac_Name");
			CommonUtil.AddGridTextColumn(dgv_Plan, "품목코드", "Prod_Code");
			CommonUtil.AddGridTextColumn(dgv_Plan, "품목명", "Prod_Name");
			CommonUtil.AddGridTextColumn(dgv_Plan, "단위", "Prod_Unit");
			#endregion

			gb_SetDate.Enabled = false;
			nu_limit.Enabled = false;

			//GetQtyByDueDate();
		}

		#region 이벤트
		#endregion

		#region 메서드

		//public void GetQtyByDueDate()
		//{
		//	ProductionService service = new ProductionService();
		//	QtyList = service.GetQtyByDueDate();
		//	service.Dispose();

		//	dgv_ProductionCount.DataSource = QtyList;
		//}

		//public void GetContList()
		//{
		//	ProductionService service = new ProductionService();
		//	ContList = service.GetConfirmedContractsList();
		//	service.Dispose();

		//	dgv_ConfirmedContract.DataSource = ContList;
		//}
		#endregion

		private void dgv_ProductionCount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			string dueDate = Convert.ToDateTime(dgv_ProductionCount["Contract_DueDate", e.RowIndex].Value).ToString("yyyy-MM-dd");

			ProductionService service = new ProductionService();
			ContList = service.GetConfirmedContractsList(dueDate);
			service.Dispose();

			dgv_ConfirmedContract.DataSource = ContList;
		}

        private void chk_SetDate_CheckedChanged(object sender, EventArgs e)
        {
			gb_SetDate.Enabled = chk_SetDate.Checked;
        }

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
			string from, to, limit;
			from = to = limit = string.Empty;

			if (chk_limit.Checked)
				limit = nu_limit.Value.ToString();

			if(chk_SetDate.Checked)
            {
				from = dtp_from.Value.ToString("yyyy-MM-dd");
				to = dtp_to.Value.ToString("yyyy-MM-dd");
			}

			ProductionService service = new ProductionService();
			QtyList = service.GetQtyByDueDate(from, to, limit);

			dgv_ProductionCount.DataSource = null;
			dgv_ProductionCount.DataSource = QtyList;

			DataTable dt = service.GetPlan(from, to);

			dgv_Plan.DataSource = null;
			dgv_Plan.DataSource = dt;

		}

        private void dgv_Plan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			if (e.RowIndex < 0)
				return;
        }

        private void btn_CreateWorkOrder_Click(object sender, EventArgs e)
        {
			ProductionService service = new ProductionService();
			bool result = service.SetWorkOrder();

			if(result)
                MessageBox.Show("작업지시목록이 생성되었습니다. 작업지시 메뉴에서 확인해주세요");
			else
                MessageBox.Show("작업지시목록 생성중 오류가 발생했습니다.");
        }
    }
}
