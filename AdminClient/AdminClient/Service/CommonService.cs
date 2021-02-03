using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient
{
    class CommonService
    {
        public List<ComboCommonVO> GetComboBindingList()
        {
            CommonDAC dac = new CommonDAC();
            List<ComboCommonVO> list = dac.GetComboBindingList();
            dac.Dispose();
            return list;
        }

        public List<CommonVO> GetCommonList(string limit, string category)
        {
            CommonDAC dac = new CommonDAC();
            List<CommonVO> list = dac.GetCommonList(limit, category);
            dac.Dispose();
            return list;
        }

        internal bool UpdateCommon(CommonVO vo)
        {
            CommonDAC dac = new CommonDAC();
            bool result = dac.UpdateCommon(vo);
            dac.Dispose();
            return result;
        }

        internal bool CommonAdd(CommonVO vo)
        {
            CommonDAC dac = new CommonDAC();
            bool result = dac.CommonAdd(vo);
            dac.Dispose();
            return result;
        }

        internal bool CommonDelete(string code)
        {
            CommonDAC dac = new CommonDAC();
            bool result = dac.CommonDelete(code);
            dac.Dispose();
            return result;
        }
    }
}
