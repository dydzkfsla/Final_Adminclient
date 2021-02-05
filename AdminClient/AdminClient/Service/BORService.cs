using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient.Service
{
    public class BORService
    {
        internal int AddBOR(BORVO vo)
        {
            BORDAC dac = new BORDAC();
            int code = dac.AddBOR(vo);
            dac.Dispose();
            return code;
        }

        internal List<BORVO> GetBORList(BORVO vo)
        {
            BORDAC dac = new BORDAC();
            List<BORVO> list = dac.GetBORList(vo);
            dac.Dispose();
            return list;
        }

        internal bool UpdateBOR(BORVO vo)
        {
            BORDAC dac = new BORDAC();
            bool result = dac.UpdateBOR(vo);
            dac.Dispose();
            return result;
        }

        internal bool DeleteBOR(int code)
        {
            BORDAC dac = new BORDAC();
            bool result = dac.DeleteBOR(code);
            dac.Dispose();
            return result;
        }

        internal List<CombBORVO> GetCboBindingList()
        {
            BORDAC dac = new BORDAC();
            List<CombBORVO> list = dac.GetCboBindingList();
            dac.Dispose();
            return list;
        }
    }
}
