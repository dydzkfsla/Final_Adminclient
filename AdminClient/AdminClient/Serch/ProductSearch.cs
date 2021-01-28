using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AdminClient.Service;
using AdminClientDAC;
using AdminClientVO;

namespace AdminClient.Serch
{
    public partial class ProductSearch : AdminClient.BaseForm.FormSearchTemp
    {
        List<ProductVO> pdList;
        List<ComboProductVO> cbolist;
        List<ProductVO> AddList = new List<ProductVO>();

        public ProductSearch()
        {
            InitializeComponent();
        }

        private void ProductSearch_Load(object sender, EventArgs e)
        {
            #region 콤보박스 바인딩
            ProductService service = new ProductService();
            cbolist = service.GetComboBindingList();

            cbolist.Insert(0, new ComboProductVO { Common_Code = "", Common_Name = "전체", Prod_State = "전체", Prod_Unit = "전체" });

            var commList = (from item in cbolist
                            group item by new { item.Common_Code, item.Common_Name } into grp
                            select new
                            {
                                CommCode = grp.Key.Common_Code,
                                CommName = grp.Key.Common_Name
                            }).ToList();

            cbo_Category.DataSource = commList;
            cbo_Category.ValueMember = "CommCode";
            cbo_Category.DisplayMember = "CommName";

            var unitList = (from item in cbolist
                            group item by new { item.Prod_Unit } into grp
                            select new { Unit = grp.Key.Prod_Unit }).ToList();

            cbo_Unit.DataSource = unitList;
            cbo_Unit.ValueMember = "Unit";
            cbo_Unit.DisplayMember = "Unit";

            cbo_State.Items.Add("전체");
            cbo_State.Items.Add("Y");
            cbo_State.Items.Add("N");
            cbo_State.SelectedIndex = 0;

            //var stateList = (from item in cbolist
            //                 group item by new { item.Prod_State } into grp
            //                 select new { State = grp.Key.Prod_State }).ToList();

            //cbo_State.DataSource = stateList;
            //cbo_State.ValueMember = "State";
            //cbo_State.DisplayMember = "State";
            #endregion

            #region dgv prodlist
            dgv_ProdList.SetGridColumn(); //설명 // 커몬유틸의 셋그리드뷰 사용x
            CommonUtil.AddGridTextColumn(dgv_ProdList, "Code", "Prod_Code", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_ProdList, "Category", "Prod_Category", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_ProdList, "카테고리", "Common_Name");
            CommonUtil.AddGridTextColumn(dgv_ProdList, "물품명", "Prod_Name");
            CommonUtil.AddGridTextColumn(dgv_ProdList, "상태", "Prod_State");
            CommonUtil.AddGridTextColumn(dgv_ProdList, "저장창고", "Prod_WhCode");
            CommonUtil.AddGridTextColumn(dgv_ProdList, "최소", "Prod_SafetyStock");
            #endregion

            #region dgv addlist
            dgv_ProdList.SetGridColumn(); //설명 // 커몬유틸의 셋그리드뷰 사용x
            CommonUtil.AddGridTextColumn(dgv_AddList, "Code", "Prod_Code", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_AddList, "Category", "Prod_Category", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_AddList, "카테고리", "Common_Name");
            CommonUtil.AddGridTextColumn(dgv_AddList, "물품명", "Prod_Name");
            CommonUtil.AddGridTextColumn(dgv_AddList, "상태", "Prod_State");
            CommonUtil.AddGridTextColumn(dgv_AddList, "저장창고", "Prod_WhCode");
            CommonUtil.AddGridTextColumn(dgv_AddList, "최소", "Prod_SafetyStock");
            #endregion
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string cate, unit, state, limit;
            cate = unit = state = limit = string.Empty;

            //유효성
            if (chk_limit.Checked)
                limit = nu_limit.Value.ToString();

            if (cbo_Category.SelectedIndex > 0)
                cate = cbo_Category.SelectedValue.ToString();

            if (cbo_State.SelectedIndex > 0)
                state = cbo_State.SelectedItem.ToString();

            if (cbo_Unit.SelectedIndex > 0)
                unit = cbo_Unit.SelectedValue.ToString();

            ProductService service = new ProductService();
            pdList = service.GetProdList(cate, unit, state, limit);

            dgv_ProdList.DataSource = pdList;

            if (pdList.Count > 0)
            {
                schCtrl.Getdata(dgv_ProdList);
                sortCtrl.Getdata(dgv_ProdList);
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {

        }
    }
}
