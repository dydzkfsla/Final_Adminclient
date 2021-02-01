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

        internal bool AddBOM(BOMVO bom)
        {
            BOMDAC dac = new BOMDAC();
            bool result = dac.AddBOM(bom);
            dac.Dispose();
            return result;
        }

        internal List<ForwardBOM> GetForwardList(BOMInfo info)
        {
            BOMDAC dac = new BOMDAC();
            List<ForwardBOM> list = dac.GetForwardList(info);
            dac.Dispose();
            return list;
        }
    }
}
