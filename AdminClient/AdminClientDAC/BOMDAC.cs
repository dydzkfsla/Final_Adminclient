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

        public bool DeleteBOM(int code)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update BOM set BOM_State = 'N', Lst_Writer = @empcode, Lst_WriteDate = getdate() where BOM_Code = @code";
                    cmd.Parameters.AddWithValue("@empcode", Global.employees.Emp_Code);
                    cmd.Parameters.AddWithValue("@code", code);

                    bool result = cmd.ExecuteNonQuery() > 0 ? true : false;

                    return result;
                }
            }
            catch(Exception err)
            {
                return false;
            }
        }

        public bool UpdateBOM(BOMVO vo)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update BOM 
                                                                        set BOM_P_ProdCode = @pProd, BOM_Count = @cnt, BOM_StartDate = @sdate, BOM_EndDate = @edate, 
                                                                               BOM_State = @state, BOM_AutoDecrease = @auto, BOM_Note = @note, 
                                                                               Lst_Writer = @empcode, Lst_WriteDate = getdate() 
                                                                        where BOM_Code = @code";

                    cmd.Parameters.AddWithValue("@pProd", vo.BOM_P_ProdCode);
                    cmd.Parameters.AddWithValue("@cnt", vo.BOM_Count);
                    cmd.Parameters.AddWithValue("@sdate", vo.BOM_StartDate);
                    cmd.Parameters.AddWithValue("@edate", vo.BOM_EndDate);
                    cmd.Parameters.AddWithValue("@state", vo.BOM_State);
                    cmd.Parameters.AddWithValue("@auto", vo.BOM_AutoDecrease);
                    cmd.Parameters.AddWithValue("@note", string.IsNullOrEmpty(vo.BOM_Note) ? DBNull.Value : (object)vo.BOM_Note);
                    cmd.Parameters.AddWithValue("@empcode", Global.employees.Emp_Code);
                    cmd.Parameters.AddWithValue("@code", vo.BOM_Code);

                    bool result = cmd.ExecuteNonQuery() > 0 ? true : false;

                    return result;
                }
            }
            catch(Exception err)
            {
                return false;
            }
        }

        public List<ReverseBOM> GetReverseList(BOMInfo info)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select child.*, pd.Prod_Name as parentName
	                                                                from( select b.BOM_Code, pd.Prod_Code as childCode, pd.Prod_Name as childName, b.BOM_P_ProdCode as parentCode, b.BOM_Count, b.BOM_StartDate, b.BOM_EndDate, b.BOM_State, b.BOM_AutoDecrease, b.BOM_Note
	                                                                				from BOM as b, Product as pd
	                                                                				where b.BOM_ProdCode = pd.Prod_Code
	                                                                					and b.BOM_ProdCode = @pcode) as child, Product as pd
	                                                                	where child.parentCode = pd.Prod_Code
	                                                                		and child.BOM_StartDate <= @date
	                                                                		and child.BOM_EndDate >= @date
	                                                                		and child.BOM_State = @state";

                    cmd.Parameters.AddWithValue("@pcode", info.ProdCode);
                    cmd.Parameters.AddWithValue("@date", info.Date);
                    cmd.Parameters.AddWithValue("@state", info.State);

                    List<ReverseBOM> list = Helper.DataReaderMapToList<ReverseBOM>(cmd.ExecuteReader());

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

        public int AddBOM(BOMVO bom)
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
                                                                                             @auto, @note, @empcode, getdate());
                                                                select @@IDENTITY;";

                    cmd.Parameters.AddWithValue("@code", bom.BOM_ProdCode);
                    cmd.Parameters.AddWithValue("@cnt", bom.BOM_Count);
                    cmd.Parameters.AddWithValue("@pcode", bom.BOM_P_ProdCode);
                    cmd.Parameters.AddWithValue("@sdate", bom.BOM_StartDate);
                    cmd.Parameters.AddWithValue("@edate", bom.BOM_EndDate);
                    cmd.Parameters.AddWithValue("@state", bom.BOM_State);
                    cmd.Parameters.AddWithValue("@auto", bom.BOM_AutoDecrease);
                    cmd.Parameters.AddWithValue("@note", bom.BOM_Note);
                    cmd.Parameters.AddWithValue("@empcode", Global.employees.Emp_Code);

                    int code = Convert.ToInt32(cmd.ExecuteScalar());

                    return code;
                }
            }
            catch(Exception err)
            {
                return -1;
            }
        }

    }
}
