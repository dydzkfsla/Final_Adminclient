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
			dtp_DueDateFrom.Value = DateTime.Now;
			dtp_DueDateTo.Value = dtp_DueDateFrom.Value.AddDays(14);
			#endregion

			#region 데이터그리드뷰 셋팅
			dgv_ShipList.SetGridColumn();
			CommonUtil.AddGridTextColumn(dgv_ShipList, "수주코드", "Contract_Code", 180);
			CommonUtil.AddGridTextColumn(dgv_ShipList, "납기일", "Contract_DueDate");
			CommonUtil.AddGridTextColumn(dgv_ShipList, "고객사코드", "Comp_Code", 103, true, DataGridViewContentAlignment.MiddleCenter);
			CommonUtil.AddGridTextColumn(dgv_ShipList, "고객사명", "Comp_Name");
			CommonUtil.AddGridTextColumn(dgv_ShipList, "도착지", "Contract_Destination");
			CommonUtil.AddGridTextColumn(dgv_ShipList, "품목코드", "Prod_Code", 90, true, DataGridViewContentAlignment.MiddleCenter);
			CommonUtil.AddGridTextColumn(dgv_ShipList, "품목명", "Prod_Name");
			CommonUtil.AddGridTextColumn(dgv_ShipList, "품목재고량", "WH_PsyCount", 103);
			CommonUtil.AddGridTextColumn(dgv_ShipList, "주문수량", "Contract_Count");
			CommonUtil.AddGridTextColumn(dgv_ShipList, "출고지시수량", "Contract_ShippingCount", 118);
			CommonUtil.AddGridTextColumn(dgv_ShipList, "취소수량", "Contract_CancelCount");
			CommonUtil.AddGridTextColumn(dgv_ShipList, "확정여부", "Contract_Confirm",10, false);
			CommonUtil.AddGridTextColumn(dgv_ShipList, "완료여부", "Contract_Finish");
			#endregion

			#region 콤보박스 셋팅
			ComboBindingService service = new ComboBindingService();
			compList = service.BindingCompNameForContract();
			service.Dispose();
			compList.Insert(0, new ComboCompNameVO { Comp_Name = "전체", Comp_Code = "" });
			cbo_CompName.DataSource = compList;//고객사 바인딩
			cbo_CompName.DisplayMember = "Comp_Name";
			cbo_CompName.ValueMember = "Comp_Code";
			cbo_ContractFinish.Items.Add("전체");
			cbo_ContractFinish.Items.Add("Y");
			cbo_ContractFinish.Items.Add("N");

			cbo_CompName.SelectedIndex = cbo_ContractFinish.SelectedIndex = 0;
			#endregion
		}
		#region 이벤트
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

		private void btn_search_Click(object sender, EventArgs e)
		{
			string limit, comp, finish;
			limit = comp = finish = string.Empty;
			string fDate = dtp_DueDateFrom.Value.Date.ToString("yyyy-MM-dd");
			string tDate = dtp_DueDateTo.Value.Date.ToString("yyyy-MM-dd");

			if (chk_limit.Checked)
				limit = nu_limit.Value.ToString();

			if (cbo_CompName.SelectedIndex > 0)
			{
				comp = cbo_CompName.SelectedValue.ToString();
			}
			if (cbo_ContractFinish.SelectedIndex > 0)
			{
				finish = cbo_ContractFinish.SelectedItem.ToString();
			}

			ContractService service = new ContractService();
			ContList = service.GetShipList(limit, fDate, tDate, comp, finish);
			service.Dispose();

			dgv_ShipList.DataSource = ContList;

			if (ContList != null && ContList.Count > 0)
			{
				searchControl1.Getdata(dgv_ShipList);
				sortControl1.Getdata(dgv_ShipList);
				gb_detail.Enabled = true;
			}
		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			DataGridViewRow row = dgv_ShipList.CurrentRow;

			ShipmentVO vo = new ShipmentVO
			{
				Contract_Code = dgv_ShipList["Contract_Code", row.Index].Value.ToString(),
				Comp_Code = dgv_ShipList["Comp_Code", row.Index].Value.ToString(),
				Comp_Name = dgv_ShipList["Comp_Name", row.Index].Value.ToString(),
				Prod_Code = dgv_ShipList["Prod_Code", row.Index].Value.ToString(),
				Prod_Name = dgv_ShipList["Prod_Name", row.Index].Value.ToString(),
				Contract_DueDate = Convert.ToDateTime(dgv_ShipList["Contract_DueDate", row.Index].Value),
				Contract_Count = Convert.ToInt32(dgv_ShipList["Contract_Count", row.Index].Value),
				Contract_CancelCount = Convert.ToInt32(dgv_ShipList["Contract_CancelCount", row.Index].Value),
				Contract_ShippingCount = Convert.ToInt32(dgv_ShipList["Contract_ShippingCount", row.Index].Value)
			};

			Shipment_PopUP pop = new Shipment_PopUP();
			pop.VO = vo;
			pop.StartPosition = FormStartPosition.CenterParent;

			if(pop.ShowDialog() == DialogResult.OK)
			{
				MessageBox.Show("출하지시가 성공적으로 완료되었습니다.");
				RefreshList();
			}
			
		}
		#endregion

		#region 메서드

		public void RefreshList() //목록 새로고침을 위한 메서드
		{
			ContractService service = new ContractService();
			ContList = service.RefreshShipList();
			service.Dispose();

			dgv_ShipList.DataSource = ContList;
		}


		#endregion
	}
}
