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
        internal List<ComboBORVO> GetComboBindingList()
        {
            BORDAC dac = new BORDAC();
            List<ComboBORVO> list = dac.GetComboBindingList();
            dac.Dispose();
            return list;
        }

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
    }
}
