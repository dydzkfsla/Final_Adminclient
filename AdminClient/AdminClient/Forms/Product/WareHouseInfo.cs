﻿using AdminClient.PopUp;
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
	public partial class WareHouseInfo : AdminClient.BaseForm.FormSerchListThreeSplitTemp
	{
        List<ComboWhVO> cbolist;
        List<WareHouseVO> WHList;
        List<WhDetailVO> WDList;

		public WareHouseInfo()
		{
			InitializeComponent();
		}

        private void WareHouseInfo_Load(object sender, EventArgs e)
        {
			gb_detail.Enabled = gb_detailItem.Enabled = false;
            nu_limit.Enabled = false;

            #region 콤보박스 세팅
            WareHouseService service = new WareHouseService();
            cbolist = service.GetComboBindingList();

            cbo_Type.DataSource = cbolist;
            cbo_Type.DisplayMember = "Common_Name";
            cbo_Type.ValueMember = "Common_Code";

            cbo_State.Items.Add("전체");
            cbo_State.Items.Add("Y");
            cbo_State.Items.Add("N");
            cbo_State.SelectedIndex = 0;

            #endregion

            #region dgv셋팅
            dgv_WhList.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_WhList, "창고코드", "WH_Code", textAlign : DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_WhList, "창고이름", "WH_Name");
            CommonUtil.AddGridTextColumn(dgv_WhList, "Type", "WH_Type", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_WhList, "창고유형", "Common_Name", textAlign: DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_WhList, "창고상태", "WH_State", textAlign: DataGridViewContentAlignment.MiddleCenter);

            dgv_WhDetailList.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_WhDetailList, "물품카테고리", "Common_Name", 150, textAlign: DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_WhDetailList, "물품코드", "Prod_Code");
            CommonUtil.AddGridTextColumn(dgv_WhDetailList, "물품이름", "Prod_Name", 150);
            CommonUtil.AddGridTextColumn(dgv_WhDetailList, "단위", "Prod_Unit");
            CommonUtil.AddGridTextColumn(dgv_WhDetailList, "보유개수", "WH_Count");
            CommonUtil.AddGridTextColumn(dgv_WhDetailList, "안전개수", "Prod_SafetyStock");
            #endregion

            txt_Code.KeyPress += NoneKeyPress;
            txt_Type.KeyPress += NoneKeyPress;
            txt_State.KeyPress += NoneKeyPress;
        }

        private void NoneKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string limit, type, state;
            limit = type = state = string.Empty;

            if (chk_limit.Checked)
                limit = nu_limit.Value.ToString();

            if (cbo_Type.SelectedIndex > 0)
                type = cbo_Type.SelectedValue.ToString();

            if (cbo_State.SelectedIndex > 0)
                state = cbo_State.SelectedItem.ToString();

            WareHouseService service = new WareHouseService();
            WHList = service.GetWareHouseList(limit, type, state);

            dgv_WhList.DataSource = WHList;

            gb_detail.Enabled = true;

            if(WHList.Count > 0)
            {
                schCtrl.Getdata(dgv_WhList);
                sortCtrl.Getdata(dgv_WhList);
            }
        }

        private void chk_limit_CheckedChanged(object sender, EventArgs e)
        {
            nu_limit.Enabled = chk_limit.Checked;
        }

        private void dgv_WhList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                txt_Code.Text = txt_State.Text = txt_Type.Text = "";

                txt_Code.Text = dgv_WhList["WH_Code", e.RowIndex].Value.ToString();
                txt_State.Text = dgv_WhList["WH_State", e.RowIndex].Value.ToString();
                txt_Type.Text = dgv_WhList["Common_Name", e.RowIndex].Value.ToString();

                WareHouseService service = new WareHouseService();
                WDList = service.GetDetailList(txt_Code.Text);

                dgv_WhDetailList.DataSource = WDList;

                if (WDList.Count > 0)
                {
                    gb_detailItem.Enabled = true;
                    schCtrlDetail.Getdata(dgv_WhDetailList);
                    sortCtrlDetail.Getdata(dgv_WhDetailList);
                }
                else
                    gb_detailItem.Enabled = false;

            }
        }

        private void dgv_WhList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if(e.ColumnIndex == 1)
            {
                WareHouseVO vo = new WareHouseVO
                {
                    WH_Code = dgv_WhList["WH_Code", e.RowIndex].Value.ToString(),
                    WH_Name = dgv_WhList["WH_Name", e.RowIndex].Value == null? "test": dgv_WhList["WH_Name", e.RowIndex].Value.ToString(),
                    WH_Type = dgv_WhList["WH_Type", e.RowIndex].Value.ToString(),
                    WH_State = dgv_WhList["WH_State", e.RowIndex].Value.ToString()
                };

                WareHousePopUp pop = new WareHousePopUp();
                pop.ThisMode = WareHousePopUp.Mode.Old;
                pop.CombList = cbolist;
                pop.VO = vo;
                pop.StartPosition = FormStartPosition.CenterParent;
                //int x = Cursor.Position.X;
                //int y = Cursor.Position.Y;

                //pop.Location = new Point(x, y);

                DialogResult popResult = pop.ShowDialog();

                if (popResult == DialogResult.OK)
                {
                    vo = pop.VO;

                    WHList.ForEach((wh) =>
                    {
                        if (wh.WH_Code == vo.WH_Code)
                        {
                            wh.WH_State = vo.WH_State;
                            wh.WH_Name = vo.WH_Name;
                            wh.Common_Name = vo.Common_Name;
                            wh.WH_Type = vo.WH_Type;
                        }
                    });

                    dgv_WhList.DataSource = null;
                    dgv_WhList.DataSource = WHList;

                }
                else if (popResult == DialogResult.None)
                {
                    WHList.ForEach((wh) =>
                    {
                        if (wh.WH_Code == txt_Code.Text)
                        {
                            wh.WH_State = "N";
                        }
                    });

                    dgv_WhList.DataSource = null;
                    dgv_WhList.DataSource = WHList;

                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            WareHousePopUp pop = new WareHousePopUp();
            pop.CombList = cbolist;
            pop.StartPosition = FormStartPosition.CenterParent;

            if(pop.ShowDialog() == DialogResult.OK)
            {
                WareHouseVO vo = pop.VO;

                WHList.Add(vo);

                dgv_WhList.DataSource = null;
                dgv_WhList.DataSource = WHList;
            }
        }
    }
}
