using AdminClient.Service;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdminClient.Forms
{
	public partial class StockInfo : AdminClient.BaseForm.FormListTemp
	{
		List<ComboStockVO> comblist;
		List<StockInfoVO> stocklist;

		public StockInfo()
		{
			InitializeComponent();
		}

        private void StockInfo_Load(object sender, EventArgs e)
        {
			gb_detail.Enabled = false;
			nu_limit.Enabled = false;
			splitContainer1.SplitterDistance = 365;
			#region 콤보박스 바인딩
			StockInfoService service = new StockInfoService();
			comblist = service.GetComboBindingList();

			var typelist = (from type in comblist
							group type by new { type.Prod_Category, type.Common_Name } into grp
							select new
							{
								Type = grp.Key.Prod_Category,
								Name = grp.Key.Common_Name
							}).ToList();

			typelist.Insert(0, new { Type = "type", Name = "전체" });
			cbo_Type.DataSource = typelist;
			cbo_Type.DisplayMember = "Name";
			cbo_Type.ValueMember = "Type";

			var unitlist = (from unit in comblist
							group unit by new { unit.Prod_Unit } into grp
							select new
							{
								Unit = grp.Key.Prod_Unit
							}).ToList();

			unitlist.Insert(0, new { Unit = "전체" });

			cbo_Unit.DataSource = unitlist;
			cbo_Unit.DisplayMember = "Unit";
			cbo_Unit.ValueMember = "Unit";

			#endregion

			#region dgv 세팅
			dgv_Stock.SetGridColumn();
			CommonUtil.AddGridTextColumn(dgv_Stock, "창고코드", "WH_Code");
			CommonUtil.AddGridTextColumn(dgv_Stock, "Type", "WH_Type", visibility: false);
			CommonUtil.AddGridTextColumn(dgv_Stock, "창고타입", "Common_Name");
			CommonUtil.AddGridTextColumn(dgv_Stock, "ProdCatrgory", "Prod_Category", visibility : false);
			CommonUtil.AddGridTextColumn(dgv_Stock, "품목타입", "ProdType");
			CommonUtil.AddGridTextColumn(dgv_Stock, "품목코드", "Prod_Code");
			CommonUtil.AddGridTextColumn(dgv_Stock, "품목명", "Prod_Name");
			CommonUtil.AddGridTextColumn(dgv_Stock, "단위", "Prod_Unit");
			CommonUtil.AddGridTextColumn(dgv_Stock, "재고량", "WH_PsyCount");
			CommonUtil.AddGridTextColumn(dgv_Stock, "안전재고량", "Prod_SafetyStock", 150);

            #endregion

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
			string limit, type, unit;
			limit = type = unit = string.Empty;

			if (chk_limit.Checked)
				limit = nu_limit.Value.ToString();

			if (cbo_Type.SelectedIndex > 0)
				type = cbo_Type.SelectedValue.ToString();

			if (cbo_Unit.SelectedIndex > 0)
				unit = cbo_Unit.Text;

			StockInfoService service = new StockInfoService();
			stocklist = service.GetStockList(limit, type, unit);

			dgv_Stock.DataSource = stocklist;

			if(stocklist != null && stocklist.Count > 0)
            {
				gb_detail.Enabled = true;
				schCtrl.Getdata(dgv_Stock);
				sortCtrl.Getdata(dgv_Stock);
			}
        }
    }
}
