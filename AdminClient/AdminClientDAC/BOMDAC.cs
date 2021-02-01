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
    public class BOMDAC : IDisposable
    {
        SqlConnection conn;
        LoggingUtility Info;
        public BOMDAC()
        {
            conn = new SqlConnection(Connstring.conn);
            conn.Open();
            Info = new LoggingUtility("BOMDACInFo", "BOMDACError", Level.All, 30);
            Info.InfoFolder = "C:\\FP\\Log\\BOMDAC\\Info";
            Info.ErrorFolder = "C:\\FP\\Log\\BOMDAC\\Error";
        }

        public void Dispose()
        {
            conn.Close();
        }

        public List<UpLevelList> GetUpLevelItemList(ProductVO prodinfo)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_BOMGetUpLevelProductList";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@type", prodinfo.Prod_Category);
                    cmd.Parameters.AddWithValue("@prodcode", prodinfo.Prod_Code);

                    List<UpLevelList> list = Helper.DataReaderMapToList<UpLevelList>(cmd.ExecuteReader());

                    return list;

                }
            }
            catch(Exception err)
            {
                return null;
            }
        }

        public List<ForwardBOM> GetForwardList(BOMInfo info)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_GetBOMList";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pcode", info.ProdCode);
                    cmd.Parameters.AddWithValue("@date", info.Date);
                    cmd.Parameters.AddWithValue("@state", info.State);

                    List<ForwardBOM> list = Helper.DataReaderMapToList<ForwardBOM>(cmd.ExecuteReader());

                    return list;

                }
            }
            catch(Exception err)
            {
                return null;
            }
        }

        public bool AddBOM(BOMVO bom)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into BOM(BOM_ProdCode, BOM_Count, BOM_P_ProdCode, 
                                                                                              BOM_StartDate, BOM_EndDate, BOM_State, BOM_AutoDecrease, 
                                                                                              BOM_Note, Fst_Writer, Fst_WriteDate)
					                                                            values(@code, @cnt, @pcode, @sdate, @edate, @state, 
                                                                                             @auto, @note, @empcode, getdate())";

                    cmd.Parameters.AddWithValue("@code", bom.BOM_ProdCode);
                    cmd.Parameters.AddWithValue("@cnt", bom.BOM_Count);
                    cmd.Parameters.AddWithValue("@pcode", bom.BOM_P_ProdCode);
                    cmd.Parameters.AddWithValue("@sdate", bom.BOM_StartDate);
                    cmd.Parameters.AddWithValue("@edate", bom.BOM_EndDate);
                    cmd.Parameters.AddWithValue("@state", bom.BOM_State);
                    cmd.Parameters.AddWithValue("@auto", bom.BOM_AutoDecrease);
                    cmd.Parameters.AddWithValue("@note", bom.BOM_Note);
                    cmd.Parameters.AddWithValue("@empcode", Global.employees.Emp_Code);

                    bool result = cmd.ExecuteNonQuery() > 0 ? true : false;

                    return result;
                }
            }
            catch(Exception err)
            {
                return false;
            }
        }

    }
}
