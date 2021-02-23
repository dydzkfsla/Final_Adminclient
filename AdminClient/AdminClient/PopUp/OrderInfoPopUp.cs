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

namespace AdminClient.PopUp
{
    public partial class OrderInfoPopUp : AdminClient.BaseForm.EmpFormTemp
    {
        List<CompanyVO> complist;
        List<CompanyDetailVO> detailList;
        List<CompanyDetailVO> addList = new List<CompanyDetailVO>();
        List<OrderDetailVO> odlist = new List<OrderDetailVO>();
        List<OrderVO> odVO;

        public List<OrderVO> OrderInfo { get { return odVO; } set { odVO = value; } }
        public List<OrderDetailVO> DetailInfo { get { return odlist; } set { odlist = value; } }

        public OrderInfoPopUp()
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
            lbl_Title.Text = "발주신청목록 등록";
            txt_OrderCnt.KeyPress += UtilEvent.TextBoxIsDigitAndOneDot;
            txt_OrderCode.KeyPress += NoneKeyPress;
            txt_ProdName.KeyPress += NoneKeyPress;
            txt_WHcode.KeyPress += NoneKeyPress;
            txt_check.KeyPress += NoneKeyPress;
            txt_OrderCode.Text = "자동입력";
            txt_OrderCnt.Text = "0";

            dgv_Comp.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_Comp, "Comp_Code", "Comp_Code", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_Comp, "업체명", "Comp_Name");

            dgv_Prod.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_Prod, "품목코드", "Prod_Code", visibility : false);
            CommonUtil.AddGridTextColumn(dgv_Prod, "품목명", "Prod_Name");
            CommonUtil.AddGridTextColumn(dgv_Prod, "창고코드", "Prod_WhCode", visibility : false);
            CommonUtil.AddGridTextColumn(dgv_Prod, "최소", "Prod_MinCount", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_Prod, "안전재고량", "Prod_SafetyStock", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_Prod, "총재고량", "totCount", visibility: false);

            dgv_AddList.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_AddList, "품목코드", "Prod_Code", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_AddList, "품목명", "Prod_Name");
            CommonUtil.AddGridTextColumn(dgv_AddList, "창고코드", "Prod_WhCode", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_AddList, "최소", "Prod_MinCount", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_AddList, "안전재고량", "Prod_SafetyStock", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_AddList, "총재고량", "totCount", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_AddList, "체크사항", "Check_Point", visibility: false);

            //CompanyDetailVO vo = new CompanyDetailVO();
            //vo.wh

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
                        if(dr.Cells["Prod_Code"].Value.ToString() == item.Prod_Code)
                        {

                            bool flag = true;

                            addList.ForEach((add) =>
                            {
                                if (add.Prod_Code == item.Prod_Code)
                                    flag = false;
                            });

                            if (flag)
                            {
                                addList.Add(item);
                                odlist.Add(new OrderDetailVO
                                {
                                    Comp_Code = item.Comp_Code, 
                                    Prod_Code = item.Prod_Code, 
                                    Prod_Name = item.Prod_Name, 
                                    Prod_Unit = item.Prod_Unit, 
                                    Orders_Count = 0, 
                                    Orders_ReceiveQuantity = 0,
                                    Orders_CancelQuantity = 0,
                                    Common_Name = "OState1"
                                });
                            }
                        }
                    });

                }
                dr.Cells[0].Value = false;
            }

            dgv_AddList.DataSource = null;
            dgv_AddList.DataSource = addList;

        }

        private void btn_Out_Click(object sender, EventArgs e)
        {
            List<CompanyDetailVO> temp = new List<CompanyDetailVO>();
            List<OrderDetailVO> odtemp = new List<OrderDetailVO>();

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

                odlist.ForEach((od) =>
                {
                    if (deleteitem.Prod_Code == od.Prod_Code)
                        odtemp.Add(od);
                });
            });

            odtemp.ForEach((oditem) =>
            {
                odlist.Remove(oditem);
            });

            dgv_AddList.DataSource = null;
            dgv_AddList.DataSource = addList;

        }

        private void dgv_AddList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                txt_ProdName.Text = dgv_AddList["Prod_Name", e.RowIndex].Value.ToString();
                txt_ProdName.Tag = dgv_AddList["Prod_Code", e.RowIndex].Value.ToString();
                txt_WHcode.Text = dgv_AddList["Prod_WhCode", e.RowIndex].Value.ToString();
                txt_check.Text = dgv_AddList["Check_Point", e.RowIndex].Value.ToString();

                odlist.ForEach((item) => 
                {
                    if (item.Prod_Code == dgv_AddList["Prod_Code", e.RowIndex].Value.ToString())
                        txt_OrderCnt.Text = item.Orders_Count.ToString();
                });

            }
        }

        private void btn_Set_Click(object sender, EventArgs e)
        {
            if (txt_OrderCnt.Text.Length < 1)
            {
                MessageBox.Show("숫자를 입력해주세요");
                return;
            }

            odlist.ForEach((item) =>
            {
                if (item.Prod_Code == txt_ProdName.Tag.ToString())
                {
                    bool flag = true;

                    detailList.ForEach((ditem) =>
                    {
                        if (ditem.Prod_MinCount > decimal.Parse(txt_OrderCnt.Text))
                        {
                            MessageBox.Show("최소주문수량보다 적은 수량은 입력할 수 없습니다.");
                            flag = false;
                        }

                    });

                    if (flag)
                        item.Orders_Count = decimal.Parse(txt_OrderCnt.Text);
                }
            });
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            if(odlist.Count < 1)
            {
                MessageBox.Show("발주신청할 품목을 등록해주세요");
                return;
            }

            bool flag = true;
            odlist.ForEach((item) =>
            {
                if (item.Orders_Count == 0)
                    flag = false;
            });

            if(flag)
            {
                bool result = OrderSQL(odlist);

                if (result)
                {
                    MessageBox.Show("발주 신청을 완료했습니다");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("발주 신청중 오류가 발생했습니다.");

            }
            else
            {
                DialogResult dr = MessageBox.Show("주문수량이 0인 제품이 있습니다. 해당 품목들을 제외하고 신청하시겠습니까?", "정보확인", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    List<OrderDetailVO> temp = new List<OrderDetailVO>();

                    odlist.ForEach((item) =>
                    {
                        if (item.Orders_Count > 0)
                            temp.Add(item);
                    });

                    bool result = OrderSQL(temp);

                    if(result)
                    {
                        MessageBox.Show("발주 신청을 완료했습니다");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                        MessageBox.Show("발주 신청중 오류가 발생했습니다.");
                }
                else
                {
                    return;
                }

            }
        }

        private bool OrderSQL(List<OrderDetailVO> dvo)
        {
            odVO = (from od in dvo
                   join add in addList on od.Comp_Code equals add.Comp_Code
                   group od by new { add.Comp_Code } into grp
                   select new OrderVO
                   {
                       Comp_Code = grp.Key.Comp_Code,
                       WH_Code = "WH_0501"
                   }).ToList();

            odVO.ForEach((od) =>
            {
                od.Orders_DueDate = dtp_DueDate.Value;
                od.Orders_Note = txt_Note.Text;
            });

            OrderService service = new OrderService();
            bool result = service.AddOrderAndDetail(odVO, dvo);

            return result;
        }
    }
}
