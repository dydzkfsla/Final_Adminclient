using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient.Service
{
    class WareHouseService
    {
        internal List<ComboWhVO> GetComboBindingList()
        {
            WareHouseDAC dac = new WareHouseDAC();
            List<ComboWhVO> list = dac.GetComboBindingList();
            dac.Dispose();
            return list;
        }

        internal List<WareHouseVO> GetWareHouseList(string limit, string type, string state)
        {
            WareHouseDAC dac = new WareHouseDAC();
            List<WareHouseVO> list = dac.GetWareHouseList(limit, type, state);
            dac.Dispose();
            return list;
        }

        internal List<WhDetailVO> GetDetailList(string code)
        {
            WareHouseDAC dac = new WareHouseDAC();
            List<WhDetailVO> list = dac.GetDetailList(code);
            dac.Dispose();
            return list;
        }

        internal bool UpdateWareHouse(WareHouseVO vo)
        {
            WareHouseDAC dac = new WareHouseDAC();
            bool result = dac.UpdateWareHouse(vo);
            dac.Dispose();
            return result;
        }

        internal string AddWareHouse(WareHouseVO vo)
        {
            WareHouseDAC dac = new WareHouseDAC();
            string code = dac.AddWareHouse(vo);
            dac.Dispose();
            return code;
        }

        internal bool DeleteWareHouse(string code)
        {
            WareHouseDAC dac = new WareHouseDAC();
            bool result = dac.DeleteWareHouse(code);
            dac.Dispose();
            return result;
        }
    }
}
