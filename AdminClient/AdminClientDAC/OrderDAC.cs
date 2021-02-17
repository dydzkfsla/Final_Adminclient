using AdminClientVO;
using log4net.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientDAC
{
    public class OrderDAC : IDisposable
    {
        SqlConnection conn;
        LoggingUtility Info;
        public OrderDAC()
        {
            conn = new SqlConnection(Connstring.conn);
            conn.Open();
            Info = new LoggingUtility("OrderDACInFo", "OrderDACError", Level.All, 30);
            Info.InfoFolder = "C:\\FP\\Log\\OrderDAC\\Info";
            Info.ErrorFolder = "C:\\FP\\Log\\OrderDAC\\Error";
        }
        public void Dispose()
        {
            conn.Close();
        }

        #region Select

        /// <summary>
        /// 상세 발주정보 불러오기
        /// </summary>
        /// <param name="code">발주코드</param>
        /// <returns></returns>
        public List<OrderDetailVO> GetOdDetailList(string code)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select od.Comp_Code, od.Orders_Code, odd.OrdersDetail_Code, odd.Prod_Code, pd.Prod_Name, pd.Prod_Unit, odd.Orders_Count, cd.Prod_MinCount, 
                                                                            odd.Orders_ReceiveQuantity, odd.Orders_CancelQuantity, cm.Common_Name
	                                                                from Orders as od, CompanyDetail as cd, OrderDetail as odd, Product as pd, Common as cm
	                                                                where od.Comp_Code = cd.Comp_Code
	                                                                	and od.Orders_Code = odd.Orders_Code
	                                                                	and odd.Prod_Code = cd.Prod_Code
	                                                                	and odd.Prod_Code = pd.Prod_Code
																		and odd.Orders_State_Comm = cm.Common_Code
	                                                                	and od.Orders_Code = @code";

                    cmd.Parameters.AddWithValue("@code", code);

                    List<OrderDetailVO> list = Helper.DataReaderMapToList<OrderDetailVO>(cmd.ExecuteReader());

                    return list;

                }
            }
            catch (Exception err)
            {
                Info.WriteError($"실행자: {Global.employees.Emp_Name} 상세 발주정보 불러오기 오류 :" + err.Message, err);
                return null;
            }
        }

        /// <summary>
        /// 콤보박스 바인딩 정보 가져옴
        /// </summary>
        /// <returns></returns>
        public List<CombOrderVO> GetComboBindingList()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select Common_Code, Common_Name from Common where Common_Category = 'OrderState'";

                    List<CombOrderVO> list = Helper.DataReaderMapToList<CombOrderVO>(cmd.ExecuteReader());

                    return list;
                }

            }
            catch (Exception err)
            {
                Info.WriteError($"실행자: {Global.employees.Emp_Name} 콤보박스 바인딩 불러오기 오류 :" + err.Message, err);
                return null;
            }
        }

        /// <summary>
        /// 발주 정보 가져옴
        /// </summary>
        /// <param name="limit">검색제한</param>
        /// <param name="sdate">시작날짜</param>
        /// <param name="edate">끝날짜</param>
        /// <param name="state">발주상태</param>
        /// <returns></returns>
        public List<OrderVO> GetOrderList(string limit, string sdate, string edate, string state)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select top(convert(int, @limit)) od.Orders_Code, ci.Comp_Code, ci.Comp_Name, WH_Code, Orders_DueDate, Common_Name, Orders_Note
	                                                                from Orders as od, CompanyInfo as ci, Common as cm
	                                                                where od.Comp_Code = ci.Comp_Code
                                                                        and od.Order_State_Comm = cm.Common_Code
	                                                                	and od.Orders_DueDate >= @sdate
	                                                                	and od.Orders_DueDate <= @edate
                                                                        and od.Order_State_Comm = isnull(@state, od.Order_State_Comm)";

                    cmd.Parameters.AddWithValue("@limit", string.IsNullOrEmpty(limit) ? 10000 : (object)limit);
                    cmd.Parameters.AddWithValue("@sdate", Convert.ToDateTime(sdate));
                    cmd.Parameters.AddWithValue("@edate", Convert.ToDateTime(edate));
                    cmd.Parameters.AddWithValue("@state", string.IsNullOrEmpty(state) ? DBNull.Value : (object)state);

                    List<OrderVO> list = Helper.DataReaderMapToList<OrderVO>(cmd.ExecuteReader());

                    return list;
                }

            }
            catch (Exception err)
            {
                Info.WriteError($"실행자: {Global.employees.Emp_Name} 발주목록 불러오기 오류 :" + err.Message, err);
                return null;
            }
        }

        #endregion

        #region Insert

        /// <summary>
        /// 이미 추가된 발주건에 새로운 물품추가
        /// </summary>
        /// <param name="temp">상세발주정보</param>
        /// <returns></returns>
        public Dictionary<int, string> OrderAddNewProduct(List<OrderDetailVO> temp)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into OrderDetail(Orders_Code, Prod_Code, Orders_Count, Orders_ReceiveQuantity, Orders_CancelQuantity, Orders_State_Comm, Fst_Writer, Fst_WriteDate)
							                                                                 values(@ocode, @pcode, @ocnt, @rqcnt, @cqcnt, @state, @empcode, getdate());
                                                                select @@IDENTITY";

                    cmd.Transaction = trans;
                    try
                    {
                        for (int i = 0; i < temp.Count; i++)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@ocode", temp[i].Orders_Code);
                            cmd.Parameters.AddWithValue("@pcode", temp[i].Prod_Code);
                            cmd.Parameters.AddWithValue("@ocnt", temp[i].Orders_Count);
                            cmd.Parameters.AddWithValue("@rqcnt", temp[i].Orders_ReceiveQuantity);
                            cmd.Parameters.AddWithValue("@cqcnt", temp[i].Orders_CancelQuantity);
                            cmd.Parameters.AddWithValue("@state", temp[i].Common_Name);
                            cmd.Parameters.AddWithValue("@empcode", Global.employees.Emp_Code);

                            int odcode = Convert.ToInt32(cmd.ExecuteScalar());

                            if (odcode > 0)
                            {
                                dic.Add(odcode, temp[i].Prod_Code);
                            }
                        }

                        trans.Commit();
                        return dic;

                    }
                    catch
                    {
                        throw;
                    }
                }
            }
            catch (Exception err)
            {
                Info.WriteError($"실행자: {Global.employees.Emp_Name} 이미 추가된 발주건에서 새로운 물품 추가중 오류 :" + err.Message, err);
                trans.Rollback();
                return null;
            }
        }

        /// <summary>
        /// 새로운 발주 정보 추가
        /// </summary>
        /// <param name="ovo">발주정보</param>
        /// <param name="dvo">상세발주정보</param>
        /// <returns></returns>
        public bool AddOrderAndDetail(List<OrderVO> ovo, List<OrderDetailVO> dvo)
        {
            try
            {
                SqlTransaction trans = conn.BeginTransaction();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.Transaction = trans;

                    try
                    {
                        for (int i = 0; i < ovo.Count; i++)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = @"insert into Orders(Comp_Code, WH_Code, Orders_DueDate, Order_State_Comm, Orders_Note, Fst_Writer, Fst_WriteDate) 
                                                                                            values(@code, @wcode, @duedate, @state, @note, @empcode, getdate());
                                                                        select @@IDENTITY;";

                            cmd.Parameters.AddWithValue("@code", ovo[i].Comp_Code);
                            cmd.Parameters.AddWithValue("@wcode", ovo[i].WH_Code);
                            cmd.Parameters.AddWithValue("@duedate", ovo[i].Orders_DueDate);
                            cmd.Parameters.AddWithValue("@state", "OState1");
                            cmd.Parameters.AddWithValue("@note", ovo[i].Orders_Note);
                            cmd.Parameters.AddWithValue("@empcode", Global.employees.Emp_Code);

                            int lstIden = Convert.ToInt32(cmd.ExecuteScalar());

                            if (lstIden > 0)
                            {
                                dvo.ForEach((detail) =>
                                {
                                    if (ovo[i].Comp_Code == detail.Comp_Code)
                                    {
                                        cmd.Parameters.Clear();
                                        cmd.CommandText = @"insert into OrderDetail(Orders_Code, Prod_Code, Orders_Count, Orders_ReceiveQuantity, Orders_CancelQuantity, Orders_State_Comm, Fst_Writer, Fst_WriteDate)
							                                                                                  values(@odcode, @prod, @cnt, @rqcnt, @cqcnt, @state, @empcode, getdate())";

                                        cmd.Parameters.AddWithValue("@odcode", lstIden);
                                        cmd.Parameters.AddWithValue("@prod", detail.Prod_Code);
                                        cmd.Parameters.AddWithValue("@cnt", detail.Orders_Count);
                                        cmd.Parameters.AddWithValue("@rqcnt", detail.Orders_ReceiveQuantity);
                                        cmd.Parameters.AddWithValue("@cqcnt", detail.Orders_CancelQuantity);
                                        cmd.Parameters.AddWithValue("@state", "OState1");
                                        cmd.Parameters.AddWithValue("@empcode", Global.employees.Emp_Code);

                                        cmd.ExecuteNonQuery();
                                    }
                                });
                            }
                            else
                            {
                                trans.Rollback();
                                return false;
                            }
                        }

                        trans.Commit();
                        return true;
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }

                }
            }
            catch (Exception err)
            {
                Info.WriteError($"실행자: {Global.employees.Emp_Name} 새로운 발주건 입력중 오류 :" + err.Message, err);
                return false;
            }
        }

        #endregion

        #region Update

        /// <summary>
        /// 상세발주정보에 추가된 물품 취소수량 입력
        /// </summary>
        /// <param name="odcode"></param>
        /// <param name="cancel"></param>
        /// <returns></returns>
        public bool CancelCountUpdate(int code, int odcode, decimal cancel)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SP_OrderCancel";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.Parameters.AddWithValue("@cancel", cancel);
                    cmd.Parameters.AddWithValue("@odcode", odcode);
                    cmd.Parameters.AddWithValue("@empcode", Global.employees.Emp_Code);

                    return cmd.ExecuteNonQuery() > 0 ? true : false;

                }

            }
            catch (Exception err)
            {
                Info.WriteError($"실행자: {Global.employees.Emp_Name} 취소수량 입력 오류 :" + err.Message, err);
                return false;
            }
        }

        /// <summary>
        /// 선택된 발주건과 해당발주건의 모든 상세발주정보 입고완료상태로 바꿈, 불출정보에 입력, 창고에 물품 추가
        /// </summary>
        /// <param name="temp">상세발주정보</param>
        /// <returns></returns>
        public bool SetOrderFinish(List<OrderDetailVO> temp)
        {
            SqlTransaction trans = conn.BeginTransaction();

            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update Orders set Order_State_Comm = 'OState3' where Orders_Code = @code;";
                    cmd.Parameters.AddWithValue("@code", temp[0].Orders_Code);

                    cmd.Transaction = trans;

                    cmd.ExecuteNonQuery();

                    try
                    {
                        for (int i = 0; i < temp.Count; i++)
                        {
                            cmd.CommandText = @"SP_OrderDetailReceiveUpdate ";
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;

                            cmd.Parameters.Clear();

                            cmd.Parameters.AddWithValue("@rqcnt", temp[i].Orders_ReceiveQuantity);
                            cmd.Parameters.AddWithValue("@odcode", temp[i].OrdersDetail_Code);
                            cmd.Parameters.AddWithValue("@empcode", Global.employees.Emp_Code);

                            cmd.ExecuteNonQuery();

                            cmd.CommandText = "SP_UpdateDemandPlan";

                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@odpCode", temp[i].Prod_Code);
                            cmd.Parameters.AddWithValue("@odCnt", temp[i].Orders_ReceiveQuantity);
                            cmd.Parameters.AddWithValue("odDate", DateTime.Now.ToString("yyyy-MM-dd"));

                            cmd.ExecuteNonQuery();

                        }

                        trans.Commit();
                        return true;
                    }
                    catch
                    {
                        throw;
                    }

                }
            }
            catch (Exception err)
            {
                Info.WriteError($"실행자: {Global.employees.Emp_Name} 주문건에 대한 모든 상세주문정보 입고완료작업중 오류 :" + err.Message, err);
                trans.Rollback();
                return false;
            }
        }

        /// <summary>
        /// 상세발주에 추가된 물품의 부분입고Update, 불출정보입력, 창고에 물품추가
        /// </summary>
        /// <param name="detail">상세발주정보</param>
        /// <returns></returns>
        public bool ReceiveQnt(OrderDetailVO detail)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SP_OrderDetailReceiveUpdate";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@rqcnt", detail.Orders_ReceiveQuantity);
                    cmd.Parameters.AddWithValue("@odcode", detail.OrdersDetail_Code);
                    cmd.Parameters.AddWithValue("@empcode", Global.employees.Emp_Code);

                    bool result = cmd.ExecuteNonQuery() > 0 ? true : false;

                    if (result)
                    {
                        cmd.CommandText = "SP_UpdateDemandPlan";

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@odpCode", detail.Prod_Code);
                        cmd.Parameters.AddWithValue("@odCnt", detail.Orders_ReceiveQuantity);
                        cmd.Parameters.AddWithValue("odDate", DateTime.Now.ToString("yyyy-MM-dd"));

                        return cmd.ExecuteNonQuery() > 0 ? true : false;


                    }
                    else
                        return false;

                }
            }
            catch (Exception err)
            {
                Info.WriteError($"실행자: {Global.employees.Emp_Name} 부분입고 작업중 오류 :" + err.Message, err);
                return false;
            }
        }

        /// <summary>
        /// 주문수량을 변경
        /// </summary>
        /// <param name="oddcode">상세발주번호</param>
        /// <param name="cnt">변경할 수량</param>
        /// <returns></returns>
        public bool UpdateOrderCount(int oddcode, decimal cnt)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update OrderDetail set Orders_Count = @cnt where OrdersDetail_Code = @oddcode";

                    cmd.Parameters.AddWithValue("@oddcode", oddcode);
                    cmd.Parameters.AddWithValue("@cnt", cnt);

                    int rCnt = cmd.ExecuteNonQuery();

                    if (rCnt > 0)
                        return true;
                    else
                        return false;
                }

            }
            catch (Exception err)
            {
                Info.WriteError($"실행자: {Global.employees.Emp_Name} 주문수량 변경중 오류 :" + err.Message, err);
                return false;
            }
        }

        /// <summary>
        /// 발주신청전인 발주건을 발주완료상태로 변경
        /// </summary>
        /// <param name="code">발주번호</param>
        /// <returns></returns>
        public bool OrderApply(int code)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SP_OrderApply";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@code", code);

                    int cnt = cmd.ExecuteNonQuery();

                    if (cnt > 0)
                        return true;
                    else
                        return false;
                }

            }
            catch (Exception err)
            {
                Info.WriteError($"실행자: {Global.employees.Emp_Name} 발주신청작업중 오류 :" + err.Message, err);
                return false;
            }
        }


        #endregion

        #region Delete

        /// <summary>
        /// 발주 상세정보에 이미 추가되어있는 물품 삭제
        /// </summary>
        /// <param name="oddcode">상세발주번호</param>
        /// <returns></returns>
        public bool OrderDeleteProd(int oddcode)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"delete from OrderDetail where OrdersDetail_Code = @oddcode";

                    cmd.Parameters.AddWithValue("@oddcode", oddcode);

                    return cmd.ExecuteNonQuery() > 0 ? true : false;
                }
            }
            catch (Exception err)
            {
                Info.WriteError($"실행자: {Global.employees.Emp_Name} 상세발주정보 물품삭제 오류 :" + err.Message, err);
                return false;
            }
        }

        #endregion
    }
}
