using log4net.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientDAC
{
    public class DemandDAC
    {
		SqlConnection conn;
		LoggingUtility Info;

		public DemandDAC()
		{
			conn = new SqlConnection(Connstring.conn);
			conn.Open();
			Info = new LoggingUtility("FacilityDACInfo", "FacilityDACError", Level.All, 30);
			Info.InfoFolder = "C:\\FP\\Log\\DemandDAC\\Info";
			Info.ErrorFolder = "C:\\FP\\Log\\DemandDAC\\Error";
		}

        public DataTable GetDemandList(string sdate, string edate)
        {
            try
            {
				string sql = "SP_GetDemandList";
				using(SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
					da.SelectCommand.CommandType = CommandType.StoredProcedure;
					da.SelectCommand.Parameters.AddWithValue("@sdate", sdate);
					da.SelectCommand.Parameters.AddWithValue("@edate", edate);

					DataTable dt = new DataTable();
					da.Fill(dt);

					return dt;
				}
            }
			catch(Exception err)
            {
				return null;
            }
        }

        public DataTable GetDemandPlan(string from, string to)
        {
            try
            {
				string sql = "SP_GetDemandPlanPivot";
				using(SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
					da.SelectCommand.CommandType = CommandType.StoredProcedure;
					da.SelectCommand.Parameters.AddWithValue("@fromInfo", from);
					da.SelectCommand.Parameters.AddWithValue("@toInfo", to);

					DataTable dt = new DataTable();
					da.Fill(dt);

					return dt;

				}
            }
			catch(Exception err)
            {
				return null;
            }
        }

        public void Dispose()
		{
			conn.Dispose();
		}

	}
}
