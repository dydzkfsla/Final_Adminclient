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

namespace AdminClient.PopUp
{
	public partial class Shipment_PopUP : AdminClient.BaseForm.EmpFormTemp
	{
		ShipmentVO vo;
		string userID = Global.Global.employees.Emp_Code;

		public ShipmentVO VO { get { return vo; } set { vo = value; } }
		public Shipment_PopUP()
		{
			InitializeComponent();
		}

		private void Shipment_PopUP_Load(object sender, EventArgs e)
		{
			lbl_Title.Text = "출고수량등록";

			lbl_ContCode.Text = vo.Contract_Code;
			lbl_CompCode.Text = vo.Comp_Code;
			lbl_Comp.Text = vo.Comp_Name;
			lbl_DueDate.Text = vo.Contract_DueDate.ToString("yyyy-MM-dd dddd");
			lbl_Prod.Text = vo.Prod_Name;
			lbl_ProdCode.Text = vo.Prod_Code;
			lbl_Count.Text = vo.Contract_Count.ToString();
			lbl_Cancel.Text = vo.Contract_CancelCount.ToString();
			lbl_Shipping.Text = vo.Contract_ShippingCount.ToString();

			txt_NowShipping.KeyPress += UtilEvent.TextBoxIsDigit;
			txt_NowShipping.Text = "0";
		}

		#region 이벤트
		private void btn_Add_Click(object sender, EventArgs e)
		{
			//유효성체크
			if (!ChkTextBox())
			{
				MessageBox.Show("출고수량을 입력해주세요.");
				return;
			}
			if (!ChkCount())
			{
				MessageBox.Show("남은 출고수량보다 큰 수량을 출하 할 수 없습니다. 다시 시도하여 주십시오.");
				return;
			}
				

			vo = new ShipmentVO
			{
				Contract_ShippingCount = Convert.ToInt32(txt_NowShipping.Text),
				Contract_Code = lbl_ContCode.Text,
				Prod_Code = lbl_ProdCode.Text
			};

			ContractService service = new ContractService();
			if (service.Shipping(userID, vo))
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("출하 지시중 오류가 발생했습니다. 다시 시도하여 주십시오.");
				return;
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

		private bool ChkCount()
		{
			bool flag = true;
			int count = Convert.ToInt32(lbl_Count.Text);
			int cancel = Convert.ToInt32(lbl_Cancel.Text);
			int shipped = Convert.ToInt32(lbl_Shipping.Text);
			int nowShip = Convert.ToInt32(txt_NowShipping.Text);

			int left = count - (cancel + shipped);
			if (nowShip > left)
				flag = false;

			return flag;
		}

		#endregion

		#endregion


	}
}
