﻿using AdminClient.Service;
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
            dgv_Check.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_Check, "물품코드", "Prod_Code", 100);
            CommonUtil.AddGridTextColumn(dgv_Check, "물품이름", "Prod_Name", 100);
            CommonUtil.AddGridTextColumn(dgv_Check, "검사 타입", "Check_Type", 100);
            CommonUtil.AddGridTextColumn(dgv_Check, "검사 장비", "Check_System", 100);
            CommonUtil.AddGridTextColumn(dgv_Check, "검사 위치", "Check_Point", 100);
            CommonUtil.AddGridTextColumn(dgv_Check, "검사 항목", "Check_Item", 100);
            CommonUtil.AddGridTextColumn(dgv_Check, "검사 규격", "Check_Standard", 2100);
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
            ProductCheckPopUp ProductCheckPopUp = new ProductCheckPopUp();
            if(ProductCheckPopUp.ShowDialog() == DialogResult.OK)
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
                ProductCheckPopUp ProductCheckPopUp = new ProductCheckPopUp(item);
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
    }
}
