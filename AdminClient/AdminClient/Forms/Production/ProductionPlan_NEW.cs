﻿using AdminClient.Service;
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
			#region 데이터그리드뷰 셋팅
			dgv_ProductionCount.SetGridColumn();
			CommonUtil.AddGridTextColumn(dgv_ProductionCount, "주문수량", "Contract_Count");
			CommonUtil.AddGridTextColumn(dgv_ProductionCount, "납기일", "Contract_DueDate");

			dgv_ConfirmedContract.SetGridColumn();
			CommonUtil.AddGridTextColumn(dgv_ConfirmedContract, "수주코드", "Contract_Code");
			CommonUtil.AddGridTextColumn(dgv_ConfirmedContract, "고객사코드", "Comp_Code");
			CommonUtil.AddGridTextColumn(dgv_ConfirmedContract, "고객사명", "Comp_Name");
			CommonUtil.AddGridTextColumn(dgv_ConfirmedContract, "도착지", "Contract_Destination");
			CommonUtil.AddGridTextColumn(dgv_ConfirmedContract, "품목코드", "Prod_Code");
			CommonUtil.AddGridTextColumn(dgv_ConfirmedContract, "품목명", "Prod_Name");
			CommonUtil.AddGridTextColumn(dgv_ConfirmedContract, "납기일", "Contract_DueDate");
			CommonUtil.AddGridTextColumn(dgv_ConfirmedContract, "주문수량", "Contract_Count");
			CommonUtil.AddGridTextColumn(dgv_ConfirmedContract, "출고수량", "Contract_ShippingCount");
			CommonUtil.AddGridTextColumn(dgv_ConfirmedContract, "취소수량", "Contract_CancelCount");
			#endregion

			GetQtyByDueDate();
		}

		#region 이벤트
		#endregion

		#region 메서드

		public void GetQtyByDueDate()
		{
			ProductionService service = new ProductionService();
			QtyList = service.GetQtyByDueDate();
			service.Dispose();

			dgv_ProductionCount.DataSource = QtyList;
		}

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
	}
}
