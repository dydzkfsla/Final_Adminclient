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

        internal DataTable GetDemandPlan(string from, string to)
        {
            DemandDAC dac = new DemandDAC();
            DataTable dt = dac.GetDemandPlan(from, to);
            dac.Dispose();
            return dt;
        }
    }
}
