using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient.Service
{
    class BOMService
    {
        public List<UpLevelList> GetUpLevelItemList(ProductVO prodinfo)
        {
            BOMDAC dac = new BOMDAC();
            List<UpLevelList> list = dac.GetUpLevelItemList(prodinfo);
            dac.Dispose();
            return list;
        }

        internal int AddBOM(BOMVO bom)
        {
            BOMDAC dac = new BOMDAC();
            int code = dac.AddBOM(bom);
            dac.Dispose();
            return code;
        }

        internal List<ForwardBOM> GetForwardList(BOMInfo info)
        {
            BOMDAC dac = new BOMDAC();
            List<ForwardBOM> list = dac.GetForwardList(info);
            dac.Dispose();
            return list;
        }

        internal List<ReverseBOM> GetReverseList(BOMInfo info)
        {
            BOMDAC dac = new BOMDAC();
            List<ReverseBOM> list = dac.GetReverseList(info);
            dac.Dispose();
            return list;
        }

        internal bool UpdateBOM(BOMVO vo)
        {
            BOMDAC dac = new BOMDAC();
            bool result = dac.UpdateBOM(vo);
            dac.Dispose();
            return result;
        }

        internal bool DeleteBOM(int code)
        {
            BOMDAC dac = new BOMDAC();
            bool result = dac.DeleteBOM(code);
            dac.Dispose();
            return result;
        }
    }
}
