using AdminClient.Service;
using AdminClient.PopUp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AdminClientVO;

namespace AdminClient.Forms
{
	public partial class ProductCheckInfo : AdminClient.BaseForm.FormSerchListTemp
	{
		public ProductCheckInfo()
		{
			InitializeComponent();
		}


        private void ProductCheckInfo_Load(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 365;
            nu_limit.Enabled = false;
            gb_detail.Enabled = false;

            dgv_Check.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_Check, "품목코드", "Prod_Code", 100);
            CommonUtil.AddGridTextColumn(dgv_Check, "품목이름", "Prod_Name", 200);
            CommonUtil.AddGridTextColumn(dgv_Check, "검사 타입", "Check_Type", 100);
            CommonUtil.AddGridTextColumn(dgv_Check, "검사 장비", "Check_System", 100);
            CommonUtil.AddGridTextColumn(dgv_Check, "검사 위치", "Check_Point", 100);
            CommonUtil.AddGridTextColumn(dgv_Check, "검사 항목", "Check_Item", 100);
            CommonUtil.AddGridTextColumn(dgv_Check, "검사 규격", "Check_Standard", 200);
        }

        #region 버튼 검색
        private void btn_search_Click(object sender, EventArgs e)
        {
            string code = string.Empty;
            if (chk_limit.Checked)
            {
                code = "Top " + Convert.ToInt32(nu_limit.Value).ToString();
            }

            ViewService service = new ViewService();
            dgv_Check.DataSource = service.View_ProductNameAndCheck(code);

            if (((List<View_ProductNameAndCheckVO>)dgv_Check.DataSource).Count > 0)
            {
                gb_detail.Enabled = true;
                searchControl.Getdata(dgv_Check);
                sortControl.Getdata(dgv_Check);
            }
            else
            {
                gb_detail.Enabled = false;
            }
        }
        #endregion

        #region 등록 버튼
        private void btn_add_Click(object sender, EventArgs e)
        {
            ProductCheckInfoPopUp ProductCheckPopUp = new ProductCheckInfoPopUp();
            ProductCheckPopUp.StartPosition = FormStartPosition.CenterParent;
            if (ProductCheckPopUp.ShowDialog() == DialogResult.OK)
            {
                if(dgv_Check.DataSource is List<View_ProductNameAndCheckVO>)
                {
                    var List = (List<View_ProductNameAndCheckVO>)dgv_Check.DataSource;
                    List.Add(ProductCheckPopUp.vo);
                    dgv_Check.DataSource = null;
                    dgv_Check.DataSource = List;
                }
            }
        }
        #endregion

        #region 컨텐츠 클릭
        private void dgv_Check_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (dgv_Check.Columns[e.ColumnIndex].Name == "Edit")
            {
                var item = (View_ProductNameAndCheckVO)dgv_Check.Rows[e.RowIndex].DataBoundItem;
                ProductCheckInfoPopUp ProductCheckPopUp = new ProductCheckInfoPopUp(item);
                DialogResult result = ProductCheckPopUp.ShowDialog();
                if (result == DialogResult.OK)  //추가
                {
                    if (dgv_Check.DataSource is List<View_ProductNameAndCheckVO>)
                    {
                        var List = (List<View_ProductNameAndCheckVO>)dgv_Check.DataSource;
                        List.Add(ProductCheckPopUp.vo);
                        dgv_Check.DataSource = null;
                        dgv_Check.DataSource = List;
                    }
                }
                else if (result == DialogResult.Yes)//수정
                {
                    if (dgv_Check.DataSource is List<View_ProductNameAndCheckVO>)
                    {
                        var List = (List<View_ProductNameAndCheckVO>)dgv_Check.DataSource;
                        var vo = List.Find(x=> x.Check_Type == ProductCheckPopUp.vo.Check_Type && x.Prod_Code == ProductCheckPopUp.vo.Prod_Code);
                        if (vo == null)
                            return;
                        vo.Check_Item = ProductCheckPopUp.vo.Check_Item;
                        vo.Check_Point = ProductCheckPopUp.vo.Check_Point;
                        vo.Check_Standard = ProductCheckPopUp.vo.Check_Standard;
                        vo.Check_System = ProductCheckPopUp.vo.Check_System;
                        dgv_Check.DataSource = null;
                        dgv_Check.DataSource = List;
                    }
                }
                else if (result == DialogResult.No)//삭제
                {
                    if (dgv_Check.DataSource is List<View_ProductNameAndCheckVO>)
                    {
                        var List = (List<View_ProductNameAndCheckVO>)dgv_Check.DataSource;
                        var vo = List.Find(x => x.Check_Type == ProductCheckPopUp.vo.Check_Type && x.Prod_Code == ProductCheckPopUp.vo.Prod_Code);
                        if (vo == null)
                            return;
                        List.Remove(vo);
                        dgv_Check.DataSource = null;
                        dgv_Check.DataSource = List;
                    }
                }

            }
        }
        #endregion

        private void chk_limit_CheckedChanged(object sender, EventArgs e)
        {
            nu_limit.Enabled = chk_limit.Checked;

            if (!chk_limit.Checked)
            {
                nu_limit.Value = 0;
            }
        }
        private void btn_Xls_Click(object sender, EventArgs e)
        {
            if (dgv_Check.DataSource == null)
                return;
            SaveFileDialog dlg = new SaveFileDialog();
            CommonExcel excel = new CommonExcel();
            excel.Cursor = this.Cursor;
            dlg.Filter = "Excel File(*.xls)|*.xls";
            dlg.Title = "엑셀파일로 내보내기";
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            DataTable dt = null;
            dt = ((List<View_ProductNameAndCheckVO>)dgv_Check.DataSource).ConvertToDataTable();

            dt.TableName = this.Name;
            string toltip = $@"Prod_Code: 품목코드
                            {System.Environment.NewLine}Prod_Name: 품목이름
                            {System.Environment.NewLine}Check_Type:  검사 타입 
                            {System.Environment.NewLine}Check_System: 검사 장비 
                            {System.Environment.NewLine}Check_Point: 검사 위치 
                            {System.Environment.NewLine}Check_Item: 검사 항목 
                            {System.Environment.NewLine}Check_Standard: 검사 규격";
            if (excel.ExportDataToExcel(dt, dlg.FileName, toltip))
            {
                MessageBox.Show("엑셀파일에 저장하였습니다.");
            }
        }

		private void chk_limit_CheckedChanged_1(object sender, EventArgs e)
		{
            nu_limit.Enabled = chk_limit.Checked;

            if (!chk_limit.Checked)
            {
                nu_limit.Value = 0;
            }
        }
	}
}
