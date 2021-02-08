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
        List<ProductVO> addList = new List<ProductVO>();

        public List<ProductVO> AddList { get { return addList; } }

        public ProductSearch()
        {
            InitializeComponent();
        }

        private void ProductSearch_Load(object sender, EventArgs e)
        {
            gb_detail.Enabled = nu_limit.Enabled = false;

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

            #endregion

            #region dgv prodlist
            dgv_ProdList.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_ProdList, "Code", "Prod_Code", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_ProdList, "Category", "Prod_Category", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_ProdList, "카테고리", "Common_Name");
            CommonUtil.AddGridTextColumn(dgv_ProdList, "물품명", "Prod_Name");
            CommonUtil.AddGridTextColumn(dgv_ProdList, "상태", "Prod_State");
            CommonUtil.AddGridTextColumn(dgv_ProdList, "저장창고", "Prod_WhCode");
            CommonUtil.AddGridTextColumn(dgv_ProdList, "최소재고량", "Prod_SafetyStock", 150);
            CommonUtil.AddGridTextColumn(dgv_ProdList, "현재재고량", "totcnt", 150);

            #endregion

            #region dgv addlist
            dgv_AddList.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_AddList, "Code", "Prod_Code", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_AddList, "Category", "Prod_Category", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_AddList, "카테고리", "Common_Name");
            CommonUtil.AddGridTextColumn(dgv_AddList, "물품명", "Prod_Name");
            CommonUtil.AddGridTextColumn(dgv_AddList, "상태", "Prod_State");
            CommonUtil.AddGridTextColumn(dgv_AddList, "저장창고", "Prod_WhCode");
            CommonUtil.AddGridTextColumn(dgv_AddList, "최소재고량", "Prod_SafetyStock", 150);
            CommonUtil.AddGridTextColumn(dgv_ProdList, "현재재고량", "totcnt", 150);
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
                gb_detail.Enabled = true;
                schCtrl.Getdata(dgv_ProdList);
                sortCtrl.Getdata(dgv_ProdList);
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {

            //이미 추가된 물품이 있는지 검사
            foreach(DataGridViewRow rw in dgv_ProdList.Rows)
            {
                if(Convert.ToBoolean(rw.Cells[0].Value)) // 체크가 된 열이면
                {
                    pdList.ForEach((prod) =>
                    {
                        if (prod.Prod_Code == rw.Cells["Prod_Code"].Value.ToString())    // 물품 리스트중에서 체크된 물품의 정보를 가져옴
                        {
                            bool alr = false;

                            addList.ForEach((addprod) =>  
                            {
                                if (addprod.Prod_Code == prod.Prod_Code)  // 추가된 리스트에서 이미 추가되있는 물품인지 검사
                                    alr = true;
                            });

                            if (!alr)  // 추가되지 않은 물품일 경우 addList에 추가
                                addList.Add(prod);

                            rw.Cells[0].Value = false;  // 체크 해제
                        }
                    });
                }
            }

            dgv_AddList.DataSource = null;
            dgv_AddList.DataSource = addList;

        }

        private void chk_limit_CheckedChanged(object sender, EventArgs e)
        {
            nu_limit.Enabled = chk_limit.Checked;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(addList.Count < 1)
            {
                DialogResult dRes = MessageBox.Show("등록된 물품이 없습니다. 추가 없이 종료하시겠습니까?", "안내 메세지", MessageBoxButtons.YesNo);

                if (dRes == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
    }
}
