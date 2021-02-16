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
	public partial class Shipment : AdminClient.BaseForm.FormSerchListTemp
	{
		string userID = Global.Global.employees.Emp_Code;
		List<ComboCompNameVO> compList; //고객사 콤보박스 바인딩용
		List<ShipmentVO> ContList; //dgv바인딩용
		public Shipment()
		{
			InitializeComponent();

			#region 기초셋팅
			nu_limit.Enabled = false;
			gb_detail.Enabled = false;
			#endregion

			#region 데이터그리드뷰 셋팅
			dgv_ShipList.SetGridColumn();
			CommonUtil.AddGridTextColumn(dgv_ShipList, "수주코드", "Contract_Code");
			CommonUtil.AddGridTextColumn(dgv_ShipList, "납기일", "Contract_DueDate");
			CommonUtil.AddGridTextColumn(dgv_ShipList, "고객사코드", "Comp_Code");
			CommonUtil.AddGridTextColumn(dgv_ShipList, "고객사명", "Comp_Name");
			CommonUtil.AddGridTextColumn(dgv_ShipList, "도착지", "Contract_Destination");
			CommonUtil.AddGridTextColumn(dgv_ShipList, "품목코드", "Prod_Code");
			CommonUtil.AddGridTextColumn(dgv_ShipList, "품목명", "Prod_Name");
			CommonUtil.AddGridTextColumn(dgv_ShipList, "품목재고량", "Prod_Name");
			CommonUtil.AddGridTextColumn(dgv_ShipList, "주문수량", "Contract_Count");
			CommonUtil.AddGridTextColumn(dgv_ShipList, "출고수량", "Contract_ShippingCount");
			CommonUtil.AddGridTextColumn(dgv_ShipList, "취소수량", "Contract_CancelCount");
			CommonUtil.AddGridTextColumn(dgv_ShipList, "확정여부", "Contract_Confirm");
			CommonUtil.AddGridTextColumn(dgv_ShipList, "완료여부", "Contract_Finish");
			#endregion
		}
		private void Shipment_Load(object sender, EventArgs e)
		{

		}

		private void chk_limit_CheckedChanged(object sender, EventArgs e)
		{
			nu_limit.Enabled = chk_limit.Checked;

			if (!chk_limit.Checked)
			{
				nu_limit.Value = 0;
			}
		}
	}
}
