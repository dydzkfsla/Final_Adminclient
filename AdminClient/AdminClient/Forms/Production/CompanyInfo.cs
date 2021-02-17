using AdminClient.PopUp;
using AdminClient.Serch;
using AdminClient.Service;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AdminClient.Forms
{
    public partial class CompanyInfo : AdminClient.BaseForm.FormSerchListThreeSplitTemp
    {
        //List<(string name, string text)> temp = new List<(string name, string text)>();
        List<ComboCompVO> cbolist;
        List<CompanyVO> compList;
        List<CompanyDetailVO> detailList;
        List<CompanyDetailVO> updateList = new List<CompanyDetailVO>();

        public CompanyInfo()
        {
            InitializeComponent();
        }

        private void CompanyInfo_Load(object sender, EventArgs e)
        {
            #region 기초세팅
            splitContainer1.SplitterDistance = 365;
            splitContainer3.SplitterDistance = 862;

            this.Name = "업체관리";

            //키입력 불가
            txt_Code.KeyPress += TextNoneKeyPress;
            txt_Name.KeyPress += TextNoneKeyPress;
            txt_CEO.KeyPress += TextNoneKeyPress;
            txt_Type.KeyPress += TextNoneKeyPress;

            #region 콤보박스 바인딩
            CompanyService service = new CompanyService();
            cbolist = service.GetComboBindingList();

            cbolist.Insert(0, new ComboCompVO { Common_Name = "전체", Comp_Type = "none" });

            cbo_Auto.Items.Add("전체");
            cbo_Auto.Items.Add("Y");
            cbo_Auto.Items.Add("N");
            cbo_State.Items.Add("전체");
            cbo_State.Items.Add("Y");
            cbo_State.Items.Add("N");
            cbo_itemState.Items.Add("Y");
            cbo_itemState.Items.Add("N");
            cbo_itemState.SelectedIndex = 0;

            cbo_Auto.SelectedIndex = cbo_State.SelectedIndex = 0;


            cbo_Type.DataSource = cbolist;

            cbo_Type.DisplayMember = "Common_Name";
            cbo_Type.ValueMember = "Comp_Type";
            #endregion

            #region dgv 세팅
            dgv_CompList.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_CompList, "Code", "Comp_Code", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_CompList, "업체명", "Comp_Name", 300);
            CommonUtil.AddGridTextColumn(dgv_CompList, "대표명", "Comp_CEO", 300);
            CommonUtil.AddGridTextColumn(dgv_CompList, "업종", "Common_Name");
            CommonUtil.AddGridTextColumn(dgv_CompList, "상태", "Comp_State");
            CommonUtil.AddGridTextColumn(dgv_CompList, "Type", "Comp_Type", visibility: false);

            CommonUtil.SetInitGridView(dgv_detail);
            CommonUtil.AddGridTextColumn(dgv_detail, "Code", "Comp_Code", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_detail, "ProdCode", "Prod_Code", visibility : false);
            CommonUtil.AddGridTextColumn(dgv_detail, "품목명", "Prod_Name");
            CommonUtil.AddGridTextColumn(dgv_detail, "단위", "Prod_Unit");
            CommonUtil.AddGridTextColumn(dgv_detail, "현재재고량", "totCount", 150);
            CommonUtil.AddGridTextColumn(dgv_detail, "안전재고량", "Prod_SafetyStock", 150);
            CommonUtil.AddGridTextColumn(dgv_detail, "최소주문량", "Prod_MinCount", 150);
            CommonUtil.AddGridTextColumn(dgv_detail, "단위당가격", "Prod_UnitPrice", 150);
            CommonUtil.AddGridTextColumn(dgv_detail, "이전가격", "Prod_OldUnitPrice");
            CommonUtil.AddGridTextColumn(dgv_detail, "상태", "item_State");
            CommonUtil.AddGridTextColumn(dgv_detail, "창고", "Prod_WhCode");
            



            #endregion

            nu_limit.Enabled = false;
            gb_detail.Enabled = false;

            CommonUtil.ControlAction<Panel, TextBox>(panel2, (txt) =>
            {
                txt.KeyPress += TextNoneKeyPress;
            });

            #endregion


        }

        private void TextNoneKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void chk_limit_CheckedChanged(object sender, EventArgs e)
        {
            nu_limit.Enabled = chk_limit.Checked;

            if (!chk_limit.Checked)
            {
                nu_limit.Value = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e) // search
        {
            string auto, state, type, limit;
            auto = state = type = limit = string.Empty;

            if (cbo_Auto.SelectedIndex > 0)
                auto = cbo_Auto.SelectedItem.ToString();

            if (cbo_State.SelectedIndex > 0)
                state = cbo_State.SelectedItem.ToString();

            if (cbo_Type.SelectedIndex > 0)
                type = cbo_Type.SelectedValue.ToString();

            if (chk_limit.Checked)
                limit = nu_limit.Value.ToString();

            CompanyService service = new CompanyService();
            compList = service.GetCompanyList(limit, auto, state, type);

            dgv_CompList.DataSource = compList;

            if(compList != null && compList.Count > 0)
            {
                schCtrl.Getdata(dgv_CompList);
                sortCtrl.Getdata(dgv_CompList);
                gb_detail.Enabled = true;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            CompanyInfoPopUp pop = new CompanyInfoPopUp();
            pop.ThisMode = CompanyInfoPopUp.Mode.New;
            pop.StartPosition = FormStartPosition.CenterParent;
            CompanyVO vo = null;

            if(pop.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("추가에 성공하였습니다.");
                vo = pop.VO;

                if (compList.Count > 0)
                {
                    compList.Add(vo);

                    dgv_CompList.DataSource = null;
                    dgv_CompList.DataSource = compList;
                }
            }

        }


        private void dgv_CompList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (updateList.Count > 0)
            //{
            //    DialogResult dr = MessageBox.Show("현재 선택되어있는 회사 품목정보에 수정기록이 있습니다 적용하시겠습니까?", "확인메세지", MessageBoxButtons.YesNoCancel);

            //    if(dr == DialogResult.Yes)
            //    {
            //        btm_AllSet.PerformClick();
            //        updateList.Clear();
            //    }
            //    else if(dr == DialogResult.No)
            //    {
            //        updateList.Clear();
            //    }
            //    else
            //    {
            //        return;
            //    }
            //}


            txt_CEO.Text = txt_Code.Text = txt_Name.Text = txt_Type.Text = string.Empty;

            if(e.RowIndex > -1)
            {
                txt_Code.Text = dgv_CompList["Comp_Code", e.RowIndex].Value.ToString();
                txt_Name.Text = dgv_CompList["Comp_Name", e.RowIndex].Value.ToString();
                txt_Type.Text = dgv_CompList["Common_Name", e.RowIndex].Value.ToString();

                if(dgv_CompList["Comp_CEO", e.RowIndex].Value != null)
                    txt_CEO.Text = dgv_CompList["Comp_CEO", e.RowIndex].Value.ToString();

                CompanyService service = new CompanyService();
                detailList = service.GetDetailInfo(txt_Code.Text);

                dgv_detail.DataSource = detailList;

            }
        }

        private void dgv_CompList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1)
            {
                if (txt_Code.Text.Length < 1)
                {
                    MessageBox.Show("수정할 목록을 선택해주세요");
                    return;
                }

                string code = txt_Code.Text;

                CompanyInfoPopUp pop = new CompanyInfoPopUp();
                pop.ThisMode = CompanyInfoPopUp.Mode.Old;
                pop.StartPosition = FormStartPosition.CenterParent;
                CompanyVO vo = null;

                compList.ForEach((comp) =>
                {
                    if (comp.Comp_Code == code)
                    {
                        vo = comp;
                    }
                });

                pop.VO = vo; // 기존정보 전달

                DialogResult dr = pop.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    MessageBox.Show("수정에 성공했습니다.");
                    vo = pop.VO; // 바뀐정보 받아옴

                    compList.ForEach((comp) =>
                    {
                        if (comp.Comp_Code == code)
                        {
                            comp = vo;
                        }
                    });

                    dgv_CompList.DataSource = null;
                    dgv_CompList.DataSource = compList;
                }
                else if(dr == DialogResult.None)
                {
                    MessageBox.Show("해당 회사를 비활성화하였습니다.");

                    compList.ForEach((comp) =>
                    {
                        if (comp.Comp_Code == code)
                        {
                            comp.Comp_State = "N";
                        }
                    });

                    dgv_CompList.DataSource = null;
                    dgv_CompList.DataSource = compList;

                }
            }
        }

        private void btn_ProdAdd_Click(object sender, EventArgs e)
        {
            ProductSearch sch = new ProductSearch();
            sch.ThisMode = ProductSearch.Mode.Multi;
            if(sch.ShowDialog() == DialogResult.OK)
            {
                List<ProductVO> addlist = sch.AddList;

                CompanyService service = new CompanyService();
                bool result = service.CompDetailAddProdList(addlist, txt_Code.Text);

                if(result)
                {
                    foreach(ProductVO add in addlist)
                    {
                        bool flag = true;
                        detailList.ForEach((ditem) =>
                        {
                            if (ditem.Prod_Code == add.Prod_Code)
                                flag = false;
                        });

                        if(flag)
                        {
                            CompanyDetailVO dvo = new CompanyDetailVO
                            {
                                Comp_Code = txt_Code.Text,
                                Prod_Code = add.Prod_Code,
                                Prod_Name = add.Prod_Name,
                                Prod_Unit = add.Prod_Unit,
                                Prod_MinCount = 0,
                                Prod_UnitPrice = 0,
                                Prod_OldUnitPrice = 0,
                                item_State = "Y",
                                Prod_WhCode = add.Prod_WhCode,
                                totCount = add.totcnt,
                                Prod_SafetyStock = add.Prod_SafetyStock
                            };

                            detailList.Add(dvo);
                        }
                    }

                    dgv_detail.DataSource = null;
                    dgv_detail.DataSource = detailList;

                }

            }
        }

        private void dgv_detail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txt_Prod_Code.Text = dgv_detail["Prod_Code", e.RowIndex].Value.ToString();
                txt_Prod_Name.Text = dgv_detail["Prod_Name", e.RowIndex].Value.ToString();
                txt_Prod_Unit.Text = dgv_detail["Prod_Unit", e.RowIndex].Value.ToString();
                txt_totCount.Text = dgv_detail["totCount", e.RowIndex].Value.ToString();
                txt_Prod_WhCode.Text = dgv_detail["Prod_WhCode", e.RowIndex].Value.ToString();
                txt_Prod_SafetyStock.Text = dgv_detail["Prod_SafetyStock", e.RowIndex].Value.ToString();
                txt_Prod_MinCount.Text = dgv_detail["Prod_MinCount", e.RowIndex].Value.ToString();
                txt_Prod_UnitPrice.Text = dgv_detail["Prod_UnitPrice", e.RowIndex].Value.ToString();

                if (dgv_detail["item_State", e.RowIndex].Value.ToString() == "Y")
                    cbo_itemState.SelectedIndex = 0;
                else
                    cbo_itemState.SelectedIndex = 1;
            }

        }

        private void btn_ProdUpdate_Click(object sender, EventArgs e)
        {
            CompanyDetailVO cpinfo = null;

            detailList.ForEach((prod) =>
            {
                if (prod.Prod_Code == txt_Prod_Code.Text)
                {
                    prod.Prod_MinCount = decimal.Parse(txt_Prod_MinCount.Text);
                    prod.Prod_OldUnitPrice = prod.Prod_UnitPrice;
                    prod.Prod_UnitPrice = int.Parse(txt_Prod_UnitPrice.Text);
                    prod.item_State = cbo_itemState.Text;

                    bool flag = true;

                    updateList.ForEach((udlist) =>
                    {
                        if (udlist.Prod_Code == prod.Prod_Code)
                        {
                            flag = false;
                            udlist = prod;
                        }
                    });

                    if (flag)
                        updateList.Add(prod);

                    cpinfo = prod;

                }

            });

            if(cpinfo != null)
            {
                CompanyService service = new CompanyService();
                bool result = service.UpdateCompInfo(cpinfo);
            }
            

            dgv_detail.DataSource = null;
            dgv_detail.DataSource = detailList;
        }

        private void btn_Xls_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            CommonExcel excel = new CommonExcel();
            excel.Cursor = this.Cursor;
            dlg.Filter = "Excel File(*.xls)|*.xls";
            dlg.Title = "엑셀파일로 내보내기";
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            DataTable dt = null;

            if (dgv_CompList.DataSource is List<CompanyVO>)
            {
                dt = ((List<CompanyVO>)dgv_CompList.DataSource).ConvertToDataTable();
            }

            if(dt != null)
            {
                dt.TableName = this.Name;
                string toltip = $@"Comp_Code: 업체코드
                            {System.Environment.NewLine}Comp_Name : 업체명
                            {System.Environment.NewLine}Comp_CEO : 업체대표
                            {System.Environment.NewLine}Common_Name : 업체타입명
                            {System.Environment.NewLine}Comp_Type : 업체타입코드
                            {System.Environment.NewLine}Comp_Auto : 자동출하여부
                            {System.Environment.NewLine}Comp_State : 업체사용여부";
                if (excel.ExportDataToExcel(dt, dlg.FileName, toltip))
                {
                    MessageBox.Show("엑셀파일에 저장하였습니다.");
                }
            }

        }
    }
}
