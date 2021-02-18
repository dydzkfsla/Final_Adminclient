using AdminClient.PopUp;
using AdminClient.Serch;
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
    public partial class BOM : AdminClient.BaseForm.EmpFormNoSerchTemp
    {
        List<ForwardBOM> forward = null;
        List<ReverseBOM> reverse = null;
        public BOM()
        {
            InitializeComponent();
        }

        private void BOM_Load(object sender, EventArgs e)
        {
            txt_Code.KeyPress += ProdCodeInput;

            cbo_choice.Items.Add("정전개");
            cbo_choice.Items.Add("역전개");
            cbo_choice.SelectedIndex = 0;

            cbo_state.Items.Add("Y");
            cbo_state.Items.Add("N");
            cbo_state.SelectedIndex = 0;
            dgv_bom.CellContentClick += dgv_BOMList_CellContentClick;
        }

        private void ProdCodeInput(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsNumber(e.KeyChar) || e.KeyChar == '_' || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(txt_Code.Text.Trim().Length < 1)
            {
                MessageBox.Show("품목코드를 입력해주세요");
                return;
            }

            BOMInfo info = new BOMInfo
            {
                Date = dtp_date.Value,
                ProdCode = txt_Code.Text,
                State = cbo_state.Text
            };

            BOMService service = new BOMService();
            if(cbo_choice.Text == "정전개")
            {
                reverse = null;

                dgv_bom.Columns.Clear();
                dgv_bom.SetGridColumn();
                CommonUtil.AddGridLinkColumn(dgv_bom, "전개", "전개");
                CommonUtil.AddGridTextColumn(dgv_bom, "BOM코드", "BOM_Code");
                CommonUtil.AddGridTextColumn(dgv_bom, "정보", "Info", 300);
                CommonUtil.AddGridTextColumn(dgv_bom, "카테고리", "Common_Name");
                CommonUtil.AddGridTextColumn(dgv_bom, "품목코드", "Prod_Code");
                CommonUtil.AddGridTextColumn(dgv_bom, "품목명", "childName");
                CommonUtil.AddGridTextColumn(dgv_bom, "상위품목", "BOM_P_ProdCode");
                CommonUtil.AddGridTextColumn(dgv_bom, "상위품목명", "parentName", 150);
                CommonUtil.AddGridTextColumn(dgv_bom, "소요량", "BOM_Count");
                CommonUtil.AddGridTextColumn(dgv_bom, "레벨", "level");
                CommonUtil.AddGridTextColumn(dgv_bom, "정리", "sortOrder");
                CommonUtil.AddGridTextColumn(dgv_bom, "시작일", "BOM_StartDate", Format: "yyyy-MM-dd");
                CommonUtil.AddGridTextColumn(dgv_bom, "종료일", "BOM_EndDate", Format: "yyyy-MM-dd");
                CommonUtil.AddGridTextColumn(dgv_bom, "사용여부", "BOM_State");
                CommonUtil.AddGridTextColumn(dgv_bom, "자동차감", "BOM_AutoDecrease");

                forward = service.GetForwardList(info);
                dgv_bom.DataSource = forward;

            }
            else if(cbo_choice.Text == "역전개")
            {
                ReverseBOM bm = new ReverseBOM();

                dgv_bom.Columns.Clear();
                dgv_bom.SetGridColumn();
                CommonUtil.AddGridTextColumn(dgv_bom, "BOM코드", "BOM_Code");
                CommonUtil.AddGridTextColumn(dgv_bom, "상위품목코드", "parentCode", 200);
                CommonUtil.AddGridTextColumn(dgv_bom, "상위품목명", "parentName", 150);
                CommonUtil.AddGridTextColumn(dgv_bom, "소요량", "BOM_Count");
                CommonUtil.AddGridTextColumn(dgv_bom, "사용여부", "BOM_State");
                CommonUtil.AddGridTextColumn(dgv_bom, "시작일", "BOM_StartDate", Format : "yyyy-MM-dd");
                CommonUtil.AddGridTextColumn(dgv_bom, "종료일", "BOM_EndDate", Format: "yyyy-MM-dd");

                forward = null;
                reverse = service.GetReverseList(info);
                dgv_bom.DataSource = reverse;
            }

        }

       


        private void btn_add_Click(object sender, EventArgs e)
        {
            BOMPopUp pop = new BOMPopUp();
            pop.StartPosition = FormStartPosition.CenterParent;

            if(pop.ShowDialog() == DialogResult.OK)
            {
                if(reverse != null)
                {
                    reverse.Add(new ReverseBOM
                    {
                        BOM_Code = pop.VO.BOM_Code,
                        childCode = pop.VO.BOM_ProdCode,
                        childName = pop.VO.childName,
                        parentCode = pop.VO.BOM_P_ProdCode,
                        parentName = pop.VO.parentName,
                        BOM_StartDate = pop.VO.BOM_StartDate,
                        BOM_EndDate = pop.VO.BOM_EndDate,
                        BOM_Count = pop.VO.BOM_Count,
                        BOM_State = pop.VO.BOM_State,
                        BOM_AutoDecrease = pop.VO.BOM_AutoDecrease,
                        BOM_Note = pop.VO.BOM_Note
                    });

                    dgv_bom.DataSource = null;
                    dgv_bom.DataSource = reverse;
                }
                else if(forward != null)
                {

                }
                else
                {
                    MessageBox.Show("BOM이 등록되었습니다 조회를 통해 확인해 주세요");
                }

            }
        }

        private void dgv_BOMList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_bom.DataSource is List<ForwardBOM> list)
            {
                if (dgv_bom[e.ColumnIndex, e.RowIndex].Value.ToString() == "접기")
                {
                    string ProducetID = dgv_bom["Prod_Code", e.RowIndex].Value.ToString();
                    dgv_bom.DataSource = list.Where(item =>
                    {
                        var Orders = item.sortOrder.Split('>');
                        var Last = Orders.Last();
                        if (Orders.Contains(ProducetID.ToString()) && Last != ProducetID.ToString())
                        {
                            return false;
                        }
                        return true;
                    }).ToList();
                    //dgv_BOMList.RefreshGridView();
                }
                else if (dgv_bom[e.ColumnIndex, e.RowIndex].Value.ToString() == "펼치기")
                {
                    string ProducetID = dgv_bom["Prod_Code", e.RowIndex].Value.ToString();
                    list = (List<ForwardBOM>)dgv_bom.DataSource;
                    var AddList = forward.Where(item =>
                    {
                        var Orders = item.sortOrder.Split('>');
                        var Last = Orders.Last();
                        if (Orders.Contains(ProducetID.ToString()) && Last != ProducetID.ToString())
                        {
                            return true;
                        }
                        return false;
                    }).ToList();

                    AddList.ForEach(item =>
                    {
                        list.Add(item);
                    });

                    dgv_bom.DataSource = list.OrderBy(item => item.sortOrder).ToList();
                    //dgv_BOMList.RefreshGridView();
                }
            }
        }

        private void dgv_BOMList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgv_bom.DataSource  is List<ForwardBOM> list)
            {
                foreach (DataGridViewRow row in dgv_bom.Rows)
                {
                    var ProductID = row.Cells["Prod_Code"].Value.ToString();
                    //현재 list에 자식인 것이 있으면
                    int count = list.Where(item => item.BOM_P_ProdCode == row.Cells["Prod_Code"].Value.ToString()).Count();
                    if (count > 0)
                    {
                        row.Cells["전개"].Value = "접기";
                        continue;
                    }
                    foreach (var item in forward)
                    {
                        var Orders = item.sortOrder.Split('>');
                        var Last = Orders.Last();
                        if (Orders.Contains(ProductID) && Last != ProductID)
                        {
                            row.Cells["전개"].Value = "펼치기";
                            continue;
                        }
                    }

                }
            }
        }

        private void dgv_bom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1)
            {
                if(e.RowIndex > -1)
                {
                    int code = Convert.ToInt32(dgv_bom["BOM_Code", e.RowIndex].Value);

                    BOMPopUp pop = new BOMPopUp();
                    pop.ThisMode = BOMPopUp.Mode.Old;

                    if (forward == null)
                    {
                        pop.ThisFR = BOMPopUp.FRmode.Reverse;
                        ReverseBOM rb = new ReverseBOM();
                        reverse.ForEach((bom) =>
                        {
                            if (bom.BOM_Code == code)
                                rb = bom;
                        });
                        pop.RVO = rb;

                    }
                    else if (reverse == null)
                    {
                        pop.ThisFR = BOMPopUp.FRmode.Forward;
                        ForwardBOM fb = new ForwardBOM();
                        forward.ForEach((bom) =>
                        {
                            if (bom.BOM_Code == code)
                                fb = bom;
                        });
                        pop.FVO = fb;
                    }

                    DialogResult dr = pop.ShowDialog();

                    

                }
            }

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
            if (dgv_bom.DataSource is List<ForwardBOM>)
            {
                dt = ((List<ForwardBOM>)dgv_bom.DataSource).ConvertToDataTable();
            }
            else
            {
                dt = ((List<ReverseBOM>)dgv_bom.DataSource).ConvertToDataTable();
            }
           
            dt.TableName = this.Name;
            string toltip = $@"code: 저장될 code값
                            {System.Environment.NewLine}name: 코드의 표현 값
                            {System.Environment.NewLine}category:  어느 그룹에 속하는지
                            {System.Environment.NewLine}pcode: 상위 부모가 있을경우 부모 code";
            if (excel.ExportDataToExcel(dt, dlg.FileName, toltip))
            {
                MessageBox.Show("엑셀파일에 저장하였습니다.");
            }

        }

        private void btn_ProdSearch_Click(object sender, EventArgs e)
        {
            ProductSearch pop = new ProductSearch();
            pop.ThisMode = ProductSearch.Mode.One;

            if(pop.ShowDialog() == DialogResult.OK)
            {
                txt_Code.Text = pop.AddList[0].Prod_Code;
            }

            
        }
    }
}
