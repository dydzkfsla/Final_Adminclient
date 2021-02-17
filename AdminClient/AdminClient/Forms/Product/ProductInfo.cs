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
using System.Windows.Forms;

namespace AdminClient.Forms
{
    public partial class ProductInfo : AdminClient.BaseForm.FormSerchListTemp
    {
        List<ProductVO> pdList;
        List<ComboProductVO> cbolist;
        public ProductInfo()
        {
            InitializeComponent();
        }

        private void ProductInfo_Load(object sender, EventArgs e)
        {
            #region 초기세팅
            splitContainer1.SplitterDistance = 365;
            nu_limit.Enabled = false;
            txt_Code.KeyPress += NoneKeyPress;
            txt_Cate.KeyPress += NoneKeyPress;
            txt_Name.KeyPress += NoneKeyPress;
            txt_Wh.KeyPress += NoneKeyPress;

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

            var stateList = (from item in cbolist
                             group item by new { item.Prod_State } into grp
                             select new { State = grp.Key.Prod_State}).ToList();

            cbo_State.DataSource = stateList;
            cbo_State.ValueMember = "State";
            cbo_State.DisplayMember = "State";
            #endregion

            #region dgv
            dgv_ProdList.SetGridColumn(); //설명 // 커몬유틸의 셋그리드뷰 사용x
            CommonUtil.AddGridTextColumn(dgv_ProdList, "Code", "Prod_Code", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_ProdList, "Category", "Prod_Category", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_ProdList, "카테고리", "Common_Name");
            CommonUtil.AddGridTextColumn(dgv_ProdList, "품목명", "Prod_Name");
            CommonUtil.AddGridTextColumn(dgv_ProdList, "상태", "Prod_State");
            CommonUtil.AddGridTextColumn(dgv_ProdList, "저장창고", "Prod_WhCode");
            CommonUtil.AddGridTextColumn(dgv_ProdList, "재고량", "totcnt");
            CommonUtil.AddGridTextColumn(dgv_ProdList, "단위", "Prod_Unit");
            CommonUtil.AddGridTextColumn(dgv_ProdList, "안전재고량", "Prod_SafetyStock", 103);
            #endregion

            gb_detail.Enabled = false;

            #endregion
        }

        #region 품목 입력 불가
        private void NoneKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        #endregion

        #region 갯수 제한 체크 
        private void chk_limit_CheckedChanged(object sender, EventArgs e)
        {
            nu_limit.Enabled = chk_limit.Checked;

            if (!chk_limit.Checked)
            {
                nu_limit.Value = 0;
            }
        }
        #endregion

        #region 검색 버튼
        private void button1_Click(object sender, EventArgs e) // search
        {
            string cate, unit, state, limit;
            cate = unit = state = limit = string.Empty;



            //유효성
            if (chk_limit.Checked)
                limit = nu_limit.Value.ToString();

            if (cbo_Category.SelectedIndex > 0)
                cate = cbo_Category.SelectedValue.ToString();

            if (cbo_State.SelectedIndex > 0)
                state = cbo_State.SelectedValue.ToString();

            if (cbo_Unit.SelectedIndex > 0)
                unit = cbo_Unit.SelectedValue.ToString();

            ProductService service = new ProductService();
            pdList = service.GetProdList(cate, unit, state, limit);

            dgv_ProdList.DataSource = pdList;

            //하나라도 검색된것이 있으면
            if(pdList.Count > 0)
            {
                gb_detail.Enabled = true;
                schCtrl.Getdata(dgv_ProdList); // 설명
                sortCtrl.Getdata(dgv_ProdList);
            }
        }
        #endregion

        private void dgv_ProdList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                txt_Code.Text = dgv_ProdList["Prod_Code", e.RowIndex].Value.ToString();
                txt_Cate.Text = dgv_ProdList["Prod_Category", e.RowIndex].Value.ToString();
                txt_Name.Text = dgv_ProdList["Prod_Name", e.RowIndex].Value.ToString();
                txt_Wh.Text = dgv_ProdList["Prod_WhCode", e.RowIndex].Value.ToString();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ProductInfoPopUp pop = new ProductInfoPopUp();
            pop.StartPosition = FormStartPosition.CenterParent;
            pop.CombVO = cbolist;
            pop.ThisMode = ProductInfoPopUp.Mode.New;

            if(pop.ShowDialog() == DialogResult.OK)
            {
                ProductVO vo = pop.VO;

                pdList.Add(vo);

                dgv_ProdList.DataSource = null;
                dgv_ProdList.DataSource = pdList;
            }
        }

        private void dgv_ProdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1 && e.RowIndex > -1)
            {
                ProductVO vo = null;

                pdList.ForEach((prod) =>
                {
                    if (prod.Prod_Code == txt_Code.Text)
                    {
                        vo = prod;
                    }
                });

                ProductInfoPopUp pop = new ProductInfoPopUp();
                pop.VO = vo;
                pop.StartPosition = FormStartPosition.CenterParent;
                pop.CombVO = cbolist;
                pop.ThisMode = ProductInfoPopUp.Mode.Old;

                DialogResult popbool = pop.ShowDialog();

                if (popbool == DialogResult.OK)
                {
                    vo = pop.VO;

                    pdList.ForEach((prod) =>
                    {
                        if (prod.Prod_Code == vo.Prod_Code)
                        {
                            prod.Prod_Name = vo.Prod_Name;
                            prod.Prod_State = vo.Prod_State;
                            prod.Prod_WhCode = vo.Prod_WhCode;
                            prod.Prod_Category = vo.Common_Name;
                            prod.Prod_Category = vo.Prod_Category;
                            prod.Prod_SafetyStock = vo.Prod_SafetyStock;
                            prod.Prod_Unit = vo.Prod_Unit;
                        }
                    });

                    dgv_ProdList.DataSource = null;
                    dgv_ProdList.DataSource = pdList;
                }
                else if(popbool == DialogResult.None)
                {
                    pdList.ForEach((prod) =>
                    {
                        if (prod.Prod_Code == pop.VO.Prod_Code)
                        {
                            prod.Prod_State = "N";
                        }
                    });

                    dgv_ProdList.DataSource = null;
                    dgv_ProdList.DataSource = pdList;
                }

            }
        }

        private void btn_Xls_Click(object sender, EventArgs e)
        {
            if (dgv_ProdList.DataSource == null)
                return;
            SaveFileDialog dlg = new SaveFileDialog();
            CommonExcel excel = new CommonExcel();
            excel.Cursor = this.Cursor;
            dlg.Filter = "Excel File(*.xls)|*.xls";
            dlg.Title = "엑셀파일로 내보내기";
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            DataTable dt = null;
            dt = ((List<ProductVO>)dgv_ProdList.DataSource).ConvertToDataTable();

            dt.TableName = this.Name;
            string toltip = $@"Prod_Code: 품목 코드값
                            {System.Environment.NewLine}Prod_Category: 품목 카테고리
                            {System.Environment.NewLine}Prod_Name:  품목명
                            {System.Environment.NewLine}Prod_WhCode: 해당품목의 주 저장 창고";
            if (excel.ExportDataToExcel(dt, dlg.FileName, toltip))
            {
                MessageBox.Show("엑셀파일에 저장하였습니다.");
            }
        }
    }
}
