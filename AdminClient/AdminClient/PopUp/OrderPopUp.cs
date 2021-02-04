using AdminClient.Service;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminClient.PopUp
{
    public partial class OrderPopUp : AdminClient.BaseForm.EmpFormTemp
    {
        List<CompanyVO> complist;
        List<CompanyDetailVO> detailList;
        List<CompanyDetailVO> addList = new List<CompanyDetailVO>();
        public OrderPopUp()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(dtp_DueDate.Value < DateTime.Now)
            {
                MessageBox.Show("납기일은 전 날짜로 설정할 수 없습니다.");
                dtp_DueDate.Value = DateTime.Now;
            }
        }

        private void OrderPopUp_Load(object sender, EventArgs e)
        {
            txt_OrderCode.KeyPress += NoneKeyPress;
            txt_ProdName.KeyPress += NoneKeyPress;

            txt_check.KeyPress += NoneKeyPress;
            txt_OrderCode.Text = "자동입력";

            dgv_Comp.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_Comp, "Comp_Code", "Comp_Code", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_Comp, "회사명", "Comp_Name");

            dgv_Prod.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_Prod, "물품코드", "Prod_Code", visibility : false);
            CommonUtil.AddGridTextColumn(dgv_Prod, "물품명", "Prod_Name");
            CommonUtil.AddGridTextColumn(dgv_Prod, "창고코드", "Prod_WhCode", visibility : false);
            CommonUtil.AddGridTextColumn(dgv_Prod, "최소", "Prod_MinCount", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_Prod, "안전", "Prod_SafetyStock", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_Prod, "총재고", "totCount", visibility: false);

            dgv_AddList.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_AddList, "물품코드", "Prod_Code", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_AddList, "물품명", "Prod_Name");
            CommonUtil.AddGridTextColumn(dgv_AddList, "창고코드", "Prod_WhCode", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_AddList, "최소", "Prod_MinCount", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_AddList, "안전", "Prod_SafetyStock", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_AddList, "총재고", "totCount", visibility: false);

            //CompanyDetailVO vo = new CompanyDetailVO();
            //vo.totCount

            CompanyService service = new CompanyService();
            complist = service.GetCompanyList(null, null, null, "Comp002");
            
            dgv_Comp.DataSource = complist;
        }

        private void NoneKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dgv_Comp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CompanyService service = new CompanyService();
            detailList = service.GetDetailInfo(dgv_Comp["Comp_Code", e.RowIndex].Value.ToString());

            dgv_Prod.DataSource = detailList;

            foreach(DataGridViewRow dr in dgv_Prod.Rows)
            {
                if(Convert.ToDecimal(dr.Cells["totCount"].Value) < Convert.ToDecimal(dr.Cells["Prod_SafetyStock"].Value))
                {
                    dr.DefaultCellStyle.ForeColor = Color.Crimson;
                }
            }

        }

        private void btn_In_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow dr in dgv_Prod.Rows)
            {
                if(Convert.ToBoolean(dr.Cells[0].Value))
                {
                    detailList.ForEach((item) =>
                    {
                        bool flag = true;

                        addList.ForEach((additem) =>
                        {
                            if (item.Prod_Code == additem.Prod_Code)
                                flag = false;
                        });

                        if(flag)
                        {
                            if (item.Prod_Code == dr.Cells["Prod_Code"].Value.ToString())
                                addList.Add(item);
                        }
                    });

                } // if끝

                dr.Cells[0].Value = false;
            } // foreach 끝

            dgv_AddList.DataSource = null;
            dgv_AddList.DataSource = addList;

        }

        private void btn_Out_Click(object sender, EventArgs e)
        {
            List<CompanyDetailVO> temp = new List<CompanyDetailVO>();

            foreach (DataGridViewRow dr in dgv_AddList.Rows)
            {
                if(Convert.ToBoolean(dr.Cells[0].Value))
                {
                    addList.ForEach((additem) =>
                    {
                        if (additem.Prod_Code == dr.Cells["Prod_Code"].Value.ToString())
                            temp.Add(additem);
                    });
                }
            }

            temp.ForEach((deleteitem) =>
            {
                addList.Remove(deleteitem);
            });

            dgv_AddList.DataSource = null;
            dgv_AddList.DataSource = addList;

        }
    }
}
