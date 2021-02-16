using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient.Service
{
    class WorkOrderService
    {
        internal List<WorkOrderVO> GetWorkOrder(string limit, string wfrom, string wto, string dfrom, string dto)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            List<WorkOrderVO> list = dac.GetWorkOrder(limit, wfrom, wto, dfrom, dto);
            dac.Dispose();
            return list;
        }
    }
}
