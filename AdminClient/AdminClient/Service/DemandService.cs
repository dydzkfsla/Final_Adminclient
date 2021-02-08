using AdminClientDAC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient.Service
{
    class DemandService
    {
        internal DataTable GetDemandList(string sdate, string edate)
        {
            DemandDAC dac = new DemandDAC();
            DataTable dt = dac.GetDemandList(sdate, edate);
            dac.Dispose();
            return dt;
        }
    }
}
