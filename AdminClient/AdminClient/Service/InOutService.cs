using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient.Service
{
    class InOutService
    {
        internal List<CombInOutVO> GetComboList()
        {
            InOutDAC dac = new InOutDAC();
            List<CombInOutVO> list = dac.GetComboList();
            dac.Dispose();
            return list;
        }

        internal List<InOutVO> GetInOutList(string limit, string keyword, string unit, string category, string inout)
        {
            InOutDAC dac = new InOutDAC();
            List<InOutVO> list = dac.GetInOutList(limit, keyword, unit, category, inout);
            dac.Dispose();
            return list;
        }
    }
}
