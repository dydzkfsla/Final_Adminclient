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

        public List<OrderDetailVO> GetOdDetailList(string code)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select od.Orders_Code, odd.OrdersDetail_Code, odd.Prod_Code, pd.Prod_Name, pd.Prod_Unit, odd.Orders_Count, 
                                                                            odd.Orders_ReceiveQuantity, odd.Orders_CancelQuantity, odd.Orders_State_Comm
	                                                                from Orders as od, OrderDetail as odd, Product as pd
	                                                                where od.Orders_Code = odd.Orders_Code
	                                                                	and odd.Prod_Code = pd.Prod_Code
	                                                                	and od.Orders_Code = @code";

                    cmd.Parameters.AddWithValue("@code", code);

                    List<OrderDetailVO> list = Helper.DataReaderMapToList<OrderDetailVO>(cmd.ExecuteReader());

                    return list;

                }
            }
            catch(Exception err)
            {
                return null;
            }
        }

        public List<OrderVO> GetOrderList(string limit, string sdate, string edate)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select top(convert(int, @limit)) od.Orders_Code, ci.Comp_Code, ci.Comp_Name, WH_Code, Orders_DueDate, Orders_Note
	                                                                from Orders as od, CompanyInfo as ci
	                                                                where od.Comp_Code = ci.Comp_Code
	                                                                	and od.Orders_DueDate >= @sdate
	                                                                	and od.Orders_DueDate <= @edate";

                    cmd.Parameters.AddWithValue("@limit", string.IsNullOrEmpty(limit) ? 10000 : (object)limit);
                    cmd.Parameters.AddWithValue("@sdate", Convert.ToDateTime(sdate));
                    cmd.Parameters.AddWithValue("@edate", Convert.ToDateTime(edate));

                    List<OrderVO> list = Helper.DataReaderMapToList<OrderVO>(cmd.ExecuteReader());

                    return list;
                }

            }
            catch(Exception err)
            {
                return null;
            }
        }
    }
}
