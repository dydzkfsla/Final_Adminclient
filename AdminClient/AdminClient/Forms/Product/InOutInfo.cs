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
    public partial class InOutInfo : AdminClient.BaseForm.FormListTemp
    {
        List<CombInOutVO> comb;
        List<InOutVO> ioList;
        public InOutInfo()
        {
            InitializeComponent();
        }

        private void InOutInfo_Load(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 365;
            nu_limit.Enabled = false;
            txt_Keyword.KeyPress += UtilEvent.tbx_Trim;

            InOutService service = new InOutService();
            comb = service.GetComboList();

            var category = (from item in comb
                            where string.IsNullOrEmpty(item.Prod_Unit)
                            select item).ToList();

            cbo_Category.DataSource = category;
            cbo_Category.DisplayMember = "Common_Name";
            cbo_Category.ValueMember = "Common_Code";

            var unit = (from item in comb
                        where string.IsNullOrEmpty(item.Common_Code)
                        select item).ToList();

            unit.Insert(0, new CombInOutVO { Prod_Unit = "전체" });

            cbo_Unit.DataSource = unit;
            cbo_Unit.DisplayMember = "Prod_Unit";

            dgv_List.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_List, "창고코드", "WH_Code");
            CommonUtil.AddGridTextColumn(dgv_List, "WH_Type", "WH_Type", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_List, "창고유형", "WH_TypeName");
            CommonUtil.AddGridTextColumn(dgv_List, "창고이름", "WH_Name");
            CommonUtil.AddGridTextColumn(dgv_List, "품목코드", "Prod_Code");
            CommonUtil.AddGridTextColumn(dgv_List, "품목명", "Prod_Name", 200);
            CommonUtil.AddGridTextColumn(dgv_List, "품목유형", "Prod_Category");
            CommonUtil.AddGridTextColumn(dgv_List, "Category_Code", "Category_Code", visibility : false);
            CommonUtil.AddGridTextColumn(dgv_List, "기준", "Prod_Unit");
            CommonUtil.AddGridTextColumn(dgv_List, "수량", "WHInOut_Count");
            CommonUtil.AddGridTextColumn(dgv_List, "입출고", "WHInOut_Type");

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
            #region 검색조건 체크
            string limit, keyword, unit, category, inout;
            limit = keyword = unit = category = inout = string.Empty;

            if (chk_limit.Checked)
                limit = nu_limit.Value.ToString();

            if (txt_Keyword.Text.Trim().Length > 0)
                keyword = txt_Keyword.Text.Trim();

            if (cbo_Category.SelectedIndex > 0)
                category = cbo_Category.SelectedValue.ToString();

            if (cbo_Unit.SelectedIndex > 0)
                unit = cbo_Unit.Text;

            if (chk_in.Checked)
                inout = "입고";
            else if (chk_out.Checked)
                inout = "출고";

            #endregion

            InOutService service = new InOutService();
            ioList = service.GetInOutList(limit, keyword, unit, category, inout);

            dgv_List.DataSource = ioList;

            if(ioList.Count > 0)
            {
                sch_Ctrl.Getdata(dgv_List);
                sort_Ctrl.Getdata(dgv_List);
            }
        }

        private void chk_in_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_in.Checked)
                chk_out.Checked = false;
        }

        private void chk_out_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_out.Checked)
                chk_in.Checked = false;
        }
    }
}
