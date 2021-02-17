using AdminClient.PopUp;
using AdminClient.Serch;
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
    public partial class OrderInfo : AdminClient.BaseForm.FormSerchListThreeSplitTemp
    {
        List<OrderVO> odlist;
        List<OrderDetailVO> oddlist;
        public OrderInfo()
        {
            InitializeComponent();
        }

        #region 초기설정
        private void OrderInfo_Load(object sender, EventArgs e) //폼로드
        {
            splitContainer1.SplitterDistance = 365;
            splitContainer2.SplitterDistance = 310;
            splitContainer3.SplitterDistance = 900;
            txt_OdCode.KeyPress += NoneKeyPress;
            nu_limit.Enabled = gb_detail.Enabled = false;
            dtp_end.Value = DateTime.Now.AddDays(1);
            btn_ProdAdd.Visible = false;

            OrderService service = new OrderService();
            List<CombOrderVO> comblist = service.GetComboBindingList();

            cbo_State.DataSource = comblist;
            cbo_State.DisplayMember = "Common_Name";
            cbo_State.ValueMember = "Common_Code";

            gb_ProdInfo.Enabled = gb_odMenu.Enabled = false;

            dgv_Odlist.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_Odlist, "발주코드", "Orders_Code");
            CommonUtil.AddGridTextColumn(dgv_Odlist, "업체코드", "Comp_Code");
            CommonUtil.AddGridTextColumn(dgv_Odlist, "업체명", "Comp_Name");
            CommonUtil.AddGridTextColumn(dgv_Odlist, "납기일", "Orders_DueDate", Format : "yyyy-MM-dd");
            CommonUtil.AddGridTextColumn(dgv_Odlist, "발주상태", "Common_Name");

            dgv_oddList.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_oddList, "cCode", "Comp_Code", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_oddList, "oCode", "Orders_Code", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_oddList, "발주상세코드", "OrdersDetail_Code", 118, textAlign : DataGridViewContentAlignment.MiddleRight);
            CommonUtil.AddGridTextColumn(dgv_oddList, "품목코드", "Prod_Code", textAlign : DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_oddList, "품목명", "Prod_Name");
            CommonUtil.AddGridTextColumn(dgv_oddList, "단위", "Prod_Unit", 70, textAlign : DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_oddList, "최소주문량", "Prod_MinCount", 105);
            CommonUtil.AddGridTextColumn(dgv_oddList, "주문수량", "Orders_Count");
            CommonUtil.AddGridTextColumn(dgv_oddList, "입고수량", "Orders_ReceiveQuantity");
            CommonUtil.AddGridTextColumn(dgv_oddList, "취소수량", "Orders_CancelQuantity");
            CommonUtil.AddGridTextColumn(dgv_oddList, "발주상태", "Common_Name");
        }

        private void chk_limit_CheckedChanged(object sender, EventArgs e) // 검색제한
        {
            nu_limit.Enabled = chk_limit.Checked;

            if (!chk_limit.Checked)
            {
                nu_limit.Value = 0;
            }
        }

        #region 날짜설정
        private void rb_CheckedChange(object sender, EventArgs e)
        {
            dtp_start.Value = DateTime.Now;

            switch (((Control)sender).Name)
            {
                case "rb_Today":
                    dtp_end.Value = DateTime.Now.AddDays(1);
                    break;
                case "rb_OneWeek":
                    dtp_end.Value = DateTime.Now.AddDays(7);
                    break;
                case "rb_1Month":
                    dtp_end.Value = DateTime.Now.AddMonths(1);
                    break;
                case "rb_3Month":
                    dtp_end.Value = DateTime.Now.AddMonths(3);
                    break;
            }
        }

        private void dtp_start_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_start.Value >= dtp_end.Value)
            {
                dtp_start.Value = dtp_end.Value.AddDays(-1);
                epv_dtpvalue.SetError(dtp_end, "날짜 설정이 잘못되었습니다.");
                //MessageBox.Show("날짜 설정이 잘못되었습니다.");
            }
            else
                epv_dtpvalue.Clear();
        }

        private void dtp_end_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_end.Value <= dtp_start.Value)
            {
                dtp_end.Value = dtp_start.Value.AddDays(1);
                epv_dtpvalue.SetError(dtp_end, "날짜 설정이 잘못되었습니다.");
                //MessageBox.Show("날짜 설정이 잘못되었습니다.");
            }
            else
                epv_dtpvalue.Clear();
        }

        #endregion

        #endregion

        #region 버튼
        private void btn_search_Click(object sender, EventArgs e) //찾기버튼
        {
            string limit = string.Empty, sdate = dtp_start.Value.ToString("yyyy-MM-dd"), edate = dtp_end.Value.ToString("yyyy-MM-dd");
            string state = string.Empty;

            if (chk_limit.Checked)
                limit = nu_limit.Value.ToString();

            if (cbo_State.SelectedIndex > 0)
                state = cbo_State.SelectedValue.ToString();

            OrderService service = new OrderService();
            odlist = service.GetOrderList(limit, sdate, edate, state);

            dgv_Odlist.DataSource = odlist;

            if (odlist.Count > 0)
            {
                gb_detail.Enabled = true;
                schCtrl.Getdata(dgv_Odlist);
                sortCtrl.Getdata(dgv_Odlist);

            }
        }

        private void btn_add_Click(object sender, EventArgs e) // 등록버튼
        {
            OrderInfoPopUp pop = new OrderInfoPopUp();
            pop.StartPosition = FormStartPosition.CenterParent;
            DialogResult dr = pop.ShowDialog();

            if (dr == DialogResult.OK)
            {
                List<OrderVO> order = pop.OrderInfo;

                if (order.Count < 1)
                    return;

                order.ForEach((popinfo) =>
                {
                    if (odlist == null)
                        odlist = new List<OrderVO>();

                    odlist.Add(popinfo);
                });

                dgv_oddList.DataSource = null;
                dgv_Odlist.DataSource = null;
                dgv_Odlist.DataSource = odlist;

                btn_search.PerformClick();
            }

        }

        //이미 추가되어있는 주문건에 대해 새로운 품목 추가
        private void btn_ProdAdd_Click(object sender, EventArgs e)
        {
            List<ProductVO> prod = new List<ProductVO>();

            ProductSearch sch = new ProductSearch();
            sch.ThisMode = ProductSearch.Mode.Multi;
            sch.StartPosition = FormStartPosition.CenterParent;
            if (sch.ShowDialog() == DialogResult.OK)
            {
                prod = sch.AddList;

                List<ProductVO> prodtemp = new List<ProductVO>();
                prod.ForEach((add) =>
                {
                    oddlist.ForEach((already) =>
                    {
                        if (add.Prod_Code == already.Prod_Code)
                            prodtemp.Add(add);
                    });
                });

                prodtemp.ForEach((canclelist) =>
                {
                    prod.Remove(canclelist);
                });

                List<OrderDetailVO> temp = new List<OrderDetailVO>();

                prod.ForEach((list) =>
                {
                    temp.Add(new OrderDetailVO
                    {
                        Comp_Code = dgv_oddList["Comp_Code", 0].Value.ToString(),
                        Orders_Code = Convert.ToInt32(dgv_oddList["Orders_Code", 0].Value),
                        Prod_Code = list.Prod_Code,
                        Prod_Unit = list.Prod_Unit,
                        Prod_Name = list.Prod_Name,
                        Orders_Count = 0,
                        Orders_ReceiveQuantity = 0,
                        Orders_CancelQuantity = 0,
                        Common_Name = "발주신청대기"
                    });
                });

                OrderService service = new OrderService();
                Dictionary<int, string> dic = service.OrderAddNewProduct(temp);

                if (dic != null)
                {
                    foreach (KeyValuePair<int, string> add in dic)
                    {
                        temp.ForEach((item) =>
                        {
                            if (item.Prod_Code == add.Value)
                                item.OrdersDetail_Code = add.Key;
                        });
                    }

                    temp.ForEach((item) =>
                    {
                        oddlist.Add(item);
                    });

                    MessageBox.Show("품목이 추가되었습니다 주문수량을 반드시 수정해주세요");
                }

                dgv_oddList.DataSource = null;
                dgv_oddList.DataSource = oddlist;

            }
        }

        //이미 추가되어있는 주문건의 품목정보 수정
        private void btn_ProdUpdate_Click(object sender, EventArgs e)
        {
            OrderDetailVO temp = null;
            oddlist.ForEach((item) =>
            {
                if (item.Prod_Code == txt_ProdCode.Text)
                    temp = item;
            });

            if(temp == null)
            {
                MessageBox.Show("오류");
                return;
            }

            if(temp.Common_Name == "발주신청대기") // 발주신청전 일경우 주문수량수정
            {
                if (txt_OrderCnt.Text.Length < 1)
                {
                    MessageBox.Show("주문수량을 입력해주세요");
                    return;
                }

                decimal cnt = decimal.Parse(txt_OrderCnt.Text);
                int oddcode = 0;

                bool flag = true;
                oddlist.ForEach((item) =>
                {
                    if (item.Prod_Code == txt_ProdCode.Text)
                    {
                        oddcode = item.OrdersDetail_Code;
                        if (item.Prod_MinCount > cnt)
                            flag = false;
                    }
                });

                if (flag)
                {
                    OrderService service = new OrderService();
                    bool result = service.UpdateOrderCount(oddcode, cnt);

                    if (result)
                    {
                        oddlist.ForEach((item) =>
                        {
                            if (item.Prod_Code == txt_ProdCode.Text)
                                item.Orders_Count = cnt;
                        });

                        dgv_oddList.DataSource = null;
                        dgv_oddList.DataSource = oddlist;

                    }
                    else
                    {
                        MessageBox.Show("수정중 오류가 발생했습니다.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("최소 주문수량보다 낮은 값으로 설정할 수 없습니다.");
                    return;
                }
            }
            else if(temp.Common_Name == "발주신청완료") //발주신청후일경우에는 취소수량입력
            {
                decimal cancel = decimal.Parse(txt_CqCnt.Text);
                int odcode = temp.OrdersDetail_Code;
                int code = temp.Orders_Code;

                if(temp.Prod_MinCount > temp.Orders_Count - decimal.Parse(txt_CqCnt.Text))
                {
                    txt_CqCnt.Text = "0";
                    MessageBox.Show("최소수량보다 적게 설정할 수 없습니다.");
                    return;
                }

                OrderService service = new OrderService();
                bool result = service.CancelCountUpdate(code, odcode, cancel);

                if(result)
                {
                    oddlist.ForEach((item) =>
                    {
                        if (item.Prod_Code == txt_ProdCode.Text)
                            item.Orders_CancelQuantity = cancel;

                        if (item.Orders_Count == item.Orders_ReceiveQuantity + item.Orders_CancelQuantity)
                            item.Common_Name = "입고완료";
                    });

                    int odcnt = oddlist.Count;
                    int chkcnt = 0;

                    oddlist.ForEach((info) =>
                    {
                        if (info.Common_Name == "입고완료")
                            chkcnt += 1;
                    });

                    if(odcnt == chkcnt)
                    {
                        odlist.ForEach((odinfo) =>
                        {
                            if (odinfo.Orders_Code == temp.Orders_Code)
                                odinfo.Common_Name = "입고완료";
                        });
                    }

                    dgv_oddList.DataSource = null;
                    dgv_oddList.DataSource = oddlist;
                    dgv_Odlist.DataSource = null;
                    dgv_Odlist.DataSource = odlist;

                }

            }

        }

        private void btn_OdMenu_Click(object sender, EventArgs e) //선택된 주문건의 상태수정버튼
        {
            if (btn_OdMenu.Text == "발주확정")
            {
                bool flag = true;
                oddlist.ForEach((item) =>
                {
                    if (item.Orders_Count < item.Prod_MinCount)
                        flag = false;
                });

                if (flag)
                {
                    OrderService service = new OrderService();
                    bool result = service.OrderApply(int.Parse(txt_OdCode.Text));

                    if (result)
                    {
                        MessageBox.Show("발주신청이 완료되었습니다.");
                        odlist.ForEach((od) =>
                        {
                            if (od.Orders_Code == int.Parse(txt_OdCode.Text))
                                od.Common_Name = "발주신청완료";
                        });

                        oddlist.ForEach((odd) =>
                        {
                            odd.Common_Name = "발주신청완료";
                        });

                        dgv_Odlist.DataSource = null;
                        dgv_Odlist.DataSource = odlist;
                        dgv_oddList.DataSource = null;
                        dgv_oddList.DataSource = oddlist;
                    }
                    else
                    {
                        MessageBox.Show("발주신청중 오류가 발생했습니다.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("주문수량이 최수주문량보다 적은 품목이 있습니다. 수정해주세요");
                    return;
                }

            }
            else if (btn_OdMenu.Text == "입고확인")
            {
                if (MessageBox.Show("모든 품목을 입고완료상태로 바꾸시겠습니까?", "확인메세지", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int code = int.Parse(txt_OdCode.Text);

                    List<OrderDetailVO> temp = oddlist;

                    temp.ForEach((item) =>
                    {
                        item.Orders_ReceiveQuantity = item.Orders_Count - item.Orders_ReceiveQuantity - item.Orders_CancelQuantity;
                    });

                    OrderService service = new OrderService();
                    bool result = service.SetOrderFinish(temp);

                    if(result)
                    {
                        odlist.ForEach((od) =>
                        {
                            if (od.Orders_Code == code)
                                od.Common_Name = "입고완료";
                        });

                        oddlist.ForEach((odd) =>
                        {
                            odd.Common_Name = "입고완료";
                            odd.Orders_ReceiveQuantity = odd.Orders_Count;
                        });

                        dgv_Odlist.DataSource = null;
                        dgv_Odlist.DataSource = odlist;
                        dgv_oddList.DataSource = null;
                        dgv_oddList.DataSource = oddlist;

                        gb_ProdInfo.Enabled = gb_odMenu.Enabled = false;

                        MessageBox.Show("선택된 발주건의 상태가 입고확인으로 정상적으로 바뀌었습니다.");

                    }
                    else
                        MessageBox.Show("입고확인 작업중 오류가 발생했습니다.");


                }
            }
        }

        private void btn_ProdDelete_Click(object sender, EventArgs e)// 선택된 물품 주문건에서 삭제
        {
            if (MessageBox.Show("선택한 품목을 주문목록에서 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int oddcode = 0;
                bool result = false;
                oddlist.ForEach((item) =>
                {
                    if (item.Prod_Code == txt_ProdCode.Text)
                        oddcode = item.OrdersDetail_Code;
                });

                OrderService service = new OrderService();

                if(oddcode > 0)
                    result = service.OrderDeleteProd(oddcode);
                else
                    MessageBox.Show("오류");



            }

        }

        private void btn_ProdIN_Click(object sender, EventArgs e) // 부분입고
        {
            OrderDetailVO detail = null;

            oddlist.ForEach((item) =>
            {
                if (item.Prod_Code == txt_ProdCode.Text)
                    detail = item;
            });

            #region 유효성체크
            if (detail == null) // 유효성체크
            {
                MessageBox.Show("오류");
                return;
            }

            if(txt_RqCnt.Text.Length < 1) // 유효성체크
            {
                MessageBox.Show("입고수량을 입력해주세요");
                return;
            }
            

            if((detail.Orders_Count - detail.Orders_CancelQuantity)  < decimal.Parse(txt_RqCnt.Text)) // 총주문수량 - 취소수량 < 입력수량 (x)
            {
                MessageBox.Show("입고되지 않은 수량을 넘게 입력할 수 없습니다.");
                return;
            }
            #endregion

            detail.Orders_ReceiveQuantity = decimal.Parse(txt_RqCnt.Text);

            OrderService service = new OrderService();
            bool result = service.ReceiveQnt(detail);

            if(result)
            {
                oddlist.ForEach((item) =>
                {
                    if (item.Prod_Code == detail.Prod_Code)
                    {
                        item.Orders_ReceiveQuantity = detail.Orders_ReceiveQuantity + item.Orders_CancelQuantity;

                        if(item.Orders_Count == item.Orders_ReceiveQuantity)
                            item.Common_Name = "입고완료";
                    }
                        
                });

                int cnt = 0;

                oddlist.ForEach((item) =>
                {
                    if (item.Common_Name == "입고완료")
                        cnt += 1;
                });

                if(cnt == oddlist.Count)
                {
                    odlist.ForEach((od) =>
                    {
                        if (od.Orders_Code == detail.Orders_Code)
                            od.Common_Name = "입고완료";
                    });
                }

                dgv_Odlist.DataSource = null;
                dgv_Odlist.DataSource = odlist;
                dgv_oddList.DataSource = null;
                dgv_oddList.DataSource = oddlist;

                MessageBox.Show("정보가 수정되었습니다.");
            }
            else
                MessageBox.Show("수정중 오류발생");

        }

        #endregion

        #region dgv 클릭
        private void dgv_Odlist_CellClick(object sender, DataGridViewCellEventArgs e) // 주문상세정보보기
        {
            if (e.RowIndex > -1)
            {
                string code = dgv_Odlist["Orders_Code", e.RowIndex].Value.ToString();
                txt_OdCode.Text = code;

                OrderService service = new OrderService();
                oddlist = service.GetOdDetailList(code);

                dgv_oddList.DataSource = oddlist;

                gb_ProdInfo.Enabled = gb_odMenu.Enabled = true;

                if(dgv_Odlist["Common_Name", e.RowIndex].Value.ToString().Trim() == "발주신청대기")
                {
                    btn_OdMenu.Text = "발주확정";
                    btn_ProdUpdate.Text = "발주수량 수정";
                }
                else if(dgv_Odlist["Common_Name", e.RowIndex].Value.ToString() == "발주신청완료")
                {
                    btn_OdMenu.Text = "입고확인";
                    btn_ProdUpdate.Text = "취소수량 입력";
                }
                else
                    gb_ProdInfo.Enabled = gb_odMenu.Enabled = false;

            }
        }

        private void dgv_Odlist_CellContentClick(object sender, DataGridViewCellEventArgs e) //주문정보수정
        {
            if (e.ColumnIndex == 1)
            {
                if (e.RowIndex > -1)
                {

                }
            }
        }

        private void dgv_oddList_CellClick(object sender, DataGridViewCellEventArgs e) //상세주문 물품정보
        {
            if (e.RowIndex > -1)
            {
                if (dgv_oddList["Common_Name", e.RowIndex].Value.ToString().Trim() == "발주신청대기")
                {
                    gb_ProdInfo.Enabled = gb_odMenu.Enabled = true;
                    btn_OdMenu.Text = "발주확정";
                    btn_ProdUpdate.Text = "발주수량 수정";
                }
                else if (dgv_oddList["Common_Name", e.RowIndex].Value.ToString() == "발주신청완료")
                {
                    gb_ProdInfo.Enabled = gb_odMenu.Enabled = true;
                    btn_OdMenu.Text = "입고확인";
                    btn_ProdUpdate.Text = "취소수량 입력";
                }
                else
                    gb_ProdInfo.Enabled = gb_odMenu.Enabled = false;
                    

                txt_ProdCode.Text = dgv_oddList["Prod_Code", e.RowIndex].Value.ToString();
                txt_OrderCnt.Text = dgv_oddList["Orders_Count", e.RowIndex].Value.ToString();
                txt_RqCnt.Text = dgv_oddList["Orders_ReceiveQuantity", e.RowIndex].Value.ToString();
                txt_CqCnt.Text = dgv_oddList["Orders_CancelQuantity", e.RowIndex].Value.ToString();
                lbl_unit1.Text = lbl_unit2.Text = lbl_unit3.Text = dgv_oddList["Prod_Unit", e.RowIndex].Value.ToString();

                txt_ProdCode.KeyPress += NoneKeyPress;

                if (dgv_oddList["Common_Name", e.RowIndex].Value.ToString() == "발주신청대기")
                {
                    txt_OrderCnt.KeyPress -= NoneKeyPress;
                    txt_OrderCnt.KeyPress += UtilEvent.TextBoxIsDigitAndOneDot;
                    txt_RqCnt.KeyPress -= UtilEvent.TextBoxIsDigitAndOneDot;
                    txt_CqCnt.KeyPress -= UtilEvent.TextBoxIsDigitAndOneDot;
                    txt_RqCnt.KeyPress += NoneKeyPress;
                    txt_CqCnt.KeyPress += NoneKeyPress;
                    btn_ProdAdd.Enabled = btn_ProdUpdate.Enabled = btn_ProdDelete.Enabled = true;
                    btn_ProdIN.Enabled = false;
                }
                else if(dgv_oddList["Common_Name", e.RowIndex].Value.ToString() == "발주신청완료")
                {
                    txt_OrderCnt.KeyPress -= UtilEvent.TextBoxIsDigitAndOneDot;
                    txt_OrderCnt.KeyPress += NoneKeyPress;
                    txt_RqCnt.KeyPress -= NoneKeyPress;
                    txt_CqCnt.KeyPress -= NoneKeyPress;
                    txt_RqCnt.KeyPress += UtilEvent.TextBoxIsDigitAndOneDot;
                    txt_CqCnt.KeyPress += UtilEvent.TextBoxIsDigitAndOneDot;
                    btn_ProdAdd.Enabled = btn_ProdDelete.Enabled = false;
                    btn_ProdUpdate.Enabled = btn_ProdIN.Enabled = true;

                }
                else
                    gb_ProdInfo.Enabled = gb_odMenu.Enabled = false;
            }
        }

        #endregion

        #region KeyPressEvent
        private void NoneKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        #endregion

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

            if (dgv_Odlist.DataSource is List<OrderVO>)
            {
                dt = ((List<OrderVO>)dgv_Odlist.DataSource).ConvertToDataTable();
            }

            if (dt != null)
            {
                dt.TableName = this.Name;
                string toltip = $@"Orders_Code: 주문번호
                            {System.Environment.NewLine}Comp_Code : 업체코드
                            {System.Environment.NewLine}Comp_Name : 업체명
                            {System.Environment.NewLine}WH_Code : 창고코드
                            {System.Environment.NewLine}Orders_DueDate : 납기일
                            {System.Environment.NewLine}Common_Name : 발주상태
                            {System.Environment.NewLine}Orders_Note : 발주노트";
                if (excel.ExportDataToExcel(dt, dlg.FileName, toltip))
                {
                    MessageBox.Show("엑셀파일에 저장하였습니다.");
                }
            }

        }
    }
}
