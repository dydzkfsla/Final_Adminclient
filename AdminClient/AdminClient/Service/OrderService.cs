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
        internal List<OrderVO> GetOrderList(string limit, string sdate, string edate, string state)
        {
            OrderDAC dac = new OrderDAC();
            List<OrderVO> list = dac.GetOrderList(limit, sdate, edate, state);
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

        internal bool AddOrderAndDetail(List<OrderVO> ovo, List<OrderDetailVO> dvo)
        {
            OrderDAC dac = new OrderDAC();
            bool result = dac.AddOrderAndDetail(ovo, dvo);
            dac.Dispose();
            return result;
        }

        internal List<CombOrderVO> GetComboBindingList()
        {
            OrderDAC dac = new OrderDAC();
            List<CombOrderVO> list = dac.GetComboBindingList();
            dac.Dispose();
            return list;
        }

        internal Dictionary<int, string> OrderAddNewProduct(List<OrderDetailVO> temp)
        {
            OrderDAC dac = new OrderDAC();
            Dictionary<int, string> dic = dac.OrderAddNewProduct(temp);
            dac.Dispose();
            return dic;
        }

        internal bool OrderApply(int code)
        {
            OrderDAC dac = new OrderDAC();
            bool result = dac.OrderApply(code);
            dac.Dispose();
            return result;
        }

        internal bool UpdateOrderCount(int oddcode, decimal cnt)
        {
            OrderDAC dac = new OrderDAC();
            bool result = dac.UpdateOrderCount(oddcode, cnt);
            dac.Dispose();
            return result;
        }

        internal bool OrderDeleteProd(int oddcode)
        {
            OrderDAC dac = new OrderDAC();
            bool result = dac.OrderDeleteProd(oddcode);
            dac.Dispose();
            return result;
        }

        internal bool ReceiveQnt(OrderDetailVO detail)
        {
            OrderDAC dac = new OrderDAC();
            bool result = dac.ReceiveQnt(detail);
            dac.Dispose();
            return result;
        }

        internal bool SetOrderFinish(List<OrderDetailVO> temp)
        {
            OrderDAC dac = new OrderDAC();
            bool result = dac.SetOrderFinish(temp);
            dac.Dispose();
            return result;
        }

        internal bool CancelCountUpdate(int code, int odcode, decimal cancel)
        {
            OrderDAC dac = new OrderDAC();
            bool result = dac.CancelCountUpdate(code, odcode, cancel);
            dac.Dispose();
            return result;
        }
    }
}
