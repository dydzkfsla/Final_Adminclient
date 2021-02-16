using AdminClient.PopUp;
using AdminClient.Service;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                CommonUtil.AddGridTextColumn(dgv_bom, "BOM코드", "BOM_Code");
                CommonUtil.AddGridTextColumn(dgv_bom, "정보", "Info", 300);
                CommonUtil.AddGridTextColumn(dgv_bom, "카테고리", "Common_Name");
                CommonUtil.AddGridTextColumn(dgv_bom, "품목코드", "Prod_Code");
                CommonUtil.AddGridTextColumn(dgv_bom, "품목명", "childName");
                CommonUtil.AddGridTextColumn(dgv_bom, "상위품목", "BOM_P_ProdCode");
                CommonUtil.AddGridTextColumn(dgv_bom, "상위품목명", "parentName");
                CommonUtil.AddGridTextColumn(dgv_bom, "소요량", "BOM_Count");
                CommonUtil.AddGridTextColumn(dgv_bom, "레벨", "level");
                CommonUtil.AddGridTextColumn(dgv_bom, "정리", "sortOrder");
                CommonUtil.AddGridTextColumn(dgv_bom, "시작일", "BOM_StartDate");
                CommonUtil.AddGridTextColumn(dgv_bom, "종료일", "BOM_EndDate");
                CommonUtil.AddGridTextColumn(dgv_bom, "사용여부", "BOM_State");
                CommonUtil.AddGridTextColumn(dgv_bom, "자동차감", "BOM_AutoDecrease");

                forward = service.GetForwardList(info);
                dgv_bom.DataSource = forward;

            }
            else if(cbo_choice.Text == "역전개")
            {
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
            //SaveFileDialog dlg = new SaveFileDialog();
            //CommonExcel excel = new CommonExcel();
            //excel.Cursor = this.Cursor;
            //dlg.Filter = "Excel File(*.xls)|*.xls";
            //dlg.Title = "엑셀파일로 내보내기";
            //if (dlg.ShowDialog() != DialogResult.OK)
            //    return;
            // dgv_bom.DataSource;
            //dt.TableName = "code";
            //string toltip = $@"code: 저장될 code값
            //                {System.Environment.NewLine}name: 코드의 표현 값
            //                {System.Environment.NewLine}category:  어느 그룹에 속하는지
            //                {System.Environment.NewLine}pcode: 상위 부모가 있을경우 부모 code";
            //if (excel.ExportDataToE
            xcel(dt, dlg.FileName, toltip))
            //{
            //    MessageBox.Show("엑셀파일에 저장하였습니다.");
            //}
        }
    }
}
