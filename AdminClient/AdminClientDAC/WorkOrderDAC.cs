using AdminClientVO;
using log4net.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientDAC
{
    public class WorkOrderDAC
    {
        SqlConnection conn;
        LoggingUtility Info;
        public WorkOrderDAC()
        {
            conn = new SqlConnection(Connstring.conn);
            conn.Open();
            Info = new LoggingUtility("StockInfoDACInFo", "StockInfoDACError", Level.All, 30);
            Info.InfoFolder = "C:\\FP\\Log\\WorkOrderDAC\\Info";
            Info.ErrorFolder = "C:\\FP\\Log\\WorkOrderDAC\\Error";
        }

        public List<WorkOrderVO> GetWorkOrder(string limit, string wfrom, string wto, string dfrom, string dto)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select top(@limit) wo.WO_Code, wo.Prod_Code, pd.Prod_Name, cm.Common_Name as WO_State, wo.Fac_Code, fac.Fac_Name, wo.Team_Code, ti.Team_Name, wo.WO_EstimatedQuantity, wo.WO_OrderQuantity, m.DueDate, m.makeDate
	                                                                from WorkOrder as wo, MAKE as m, Common as cm, Product as pd, Facility as fac, Team_Info as ti
	                                                                where wo.WO_EstimatedEnd = m.makeDate
	                                                                	and wo.Prod_Code = m.Prod_Code
	                                                                	and wo.Fac_Code = m.Fac_Code
	                                                                	and wo.WO_State = cm.Common_Code
	                                                                	and wo.Fac_Code = fac.Fac_Code
	                                                                	and wo.Team_Code = ti.Team_Code
	                                                                	and wo.Prod_Code = pd.Prod_Code
	                                                                	and m.makeDate >= isnull(@wfrom, m.makeDate)
	                                                                	and m.makeDate <= isnull(@wto, m.makeDate)
	                                                                	and m.DueDate >= isnull(@dfrom, m.DueDate)
	                                                                	and m.DueDate <= isnull(@dto, m.DueDate)";

                    cmd.Parameters.AddWithValue("@limit", string.IsNullOrEmpty(limit) ? 1000 : (object)Convert.ToInt32(limit));
                    cmd.Parameters.AddWithValue("@wfrom", string.IsNullOrEmpty(wfrom) ? DBNull.Value : (object)Convert.ToInt32(wfrom));
                    cmd.Parameters.AddWithValue("@wto", string.IsNullOrEmpty(wto) ? DBNull.Value : (object)Convert.ToInt32(wto));
                    cmd.Parameters.AddWithValue("@dfrom", string.IsNullOrEmpty(dfrom) ? DBNull.Value : (object)Convert.ToInt32(dfrom));
                    cmd.Parameters.AddWithValue("@dto", string.IsNullOrEmpty(dto) ? DBNull.Value : (object)Convert.ToInt32(dto));

                    List<WorkOrderVO> list = Helper.DataReaderMapToList<WorkOrderVO>(cmd.ExecuteReader());

                    return list;

                }
            }
            catch(Exception err)
            {
                return null;
            }
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
