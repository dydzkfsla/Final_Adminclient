using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient.Service
{
    public class OrderService
    {
        internal List<OrderVO> GetOrderList(string limit, string sdate, string edate)
        {
            OrderDAC dac = new OrderDAC();
            List<OrderVO> list = dac.GetOrderList(limit, sdate, edate);
            dac.Dispose();
            return list;
        }

        internal List<OrderDetailVO> GetOdDetailList(string code)
        {
            OrderDAC dac = new OrderDAC();
            List<OrderDetailVO> list = dac.GetOdDetailList(code);
            dac.Dispose();
            return list;
        }
    }
}
