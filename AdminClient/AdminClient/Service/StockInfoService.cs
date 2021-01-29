using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient.Service
{
    class StockInfoService
    {
        internal List<ComboStockVO> GetComboBindingList()
        {
            StockInfoDAC dac = new StockInfoDAC();
            List<ComboStockVO> list = dac.GetComboBindingList();
            dac.Dispose();
            return list;
        }

        internal List<StockInfoVO> GetStockList(string limit, string type, string unit)
        {
            StockInfoDAC dac = new StockInfoDAC();
            List<StockInfoVO> list = dac.GetStockList(limit, type, unit);
            dac.Dispose();
            return list;
        }
    }
}
