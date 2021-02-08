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
    public class BORDAC : IDisposable
    {
        SqlConnection conn;
        LoggingUtility Info;
        public BORDAC()
        {
            conn = new SqlConnection(Connstring.conn);
            conn.Open();
            Info = new LoggingUtility("BORDACInFo", "BORDACError", Level.All, 30);
            Info.InfoFolder = "C:\\FP\\Log\\BORDAC\\Info";
            Info.ErrorFolder = "C:\\FP\\Log\\BORDAC\\Error";
        }

        public int AddBOR(BORVO vo)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into BOR(Prod_Code, Pcs_Code, Fac_Code, Tact_Time, BOR_Priority, 
                                                                                            BOR_DelayTime, BOR_State, BOR_Note, Fst_Writer, Fst_WriteDate)
				                                                                values(@prod, @pcs, @fac, @tact, @prio, @delay, 
                                                                                             @state, @note, @empcode, getdate());
                                                                select @@IDENTITY;";

                    cmd.Parameters.AddWithValue("@prod", vo.Prod_Code);
                    cmd.Parameters.AddWithValue("@pcs", vo.Pcs_Code);
                    cmd.Parameters.AddWithValue("@fac", vo.Fac_Code);
                    cmd.Parameters.AddWithValue("@tact", vo.Tact_Time);
                    cmd.Parameters.AddWithValue("@prio", vo.BOR_Priority);
                    cmd.Parameters.AddWithValue("@delay", vo.BOR_DelayTime);
                    cmd.Parameters.AddWithValue("@state", vo.BOR_State);
                    cmd.Parameters.AddWithValue("@note", vo.BOR_Note);
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

        public List<CombBORVO> GetCboBindingList()
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select fc.Fac_Code, fc.Fac_Name, p.Pcs_Code, p.Pcs_Name
	                                                                from Facility as fc
	                                                                full outer join ProcessInfo as p on fc.Fac_Code = p.Pcs_Code";

                    List<CombBORVO> list = Helper.DataReaderMapToList<CombBORVO>(cmd.ExecuteReader());

                    return list;
                }
            }
            catch(Exception err)
            {
                return null;
            }
        }

        public bool DeleteBOR(int code)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update BOR 
                                                                        set BOR_State = 'N', Lst_Writer = @empcode, Lst_WriteDate = getdate() 
                                                                        where BOR_Code = @code";

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

        public bool UpdateBOR(BORVO vo)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update BOR 
                                                                        set Prod_Code = @pcode, Pcs_Code = @pcs, Fac_Code = @fac, 
                                                                               Tact_Time = @tact, BOR_Priority = @pri, BOR_DelayTime = @dtime, 
                                                                               BOR_State = @state, BOR_Note = @note, Lst_Writer = @empcode, Lst_WriteDate = getdate() 
                                                                        where BOR_Code = @code";

                    cmd.Parameters.AddWithValue("@pcode", vo.Prod_Code);
                    cmd.Parameters.AddWithValue("@pcs", vo.Pcs_Code);
                    cmd.Parameters.AddWithValue("@fac", vo.Fac_Code);
                    cmd.Parameters.AddWithValue("@tact", vo.Tact_Time);
                    cmd.Parameters.AddWithValue("@pri", vo.BOR_Priority);
                    cmd.Parameters.AddWithValue("@dtime", vo.BOR_DelayTime);
                    cmd.Parameters.AddWithValue("@state", vo.BOR_State);
                    cmd.Parameters.AddWithValue("@note", string.IsNullOrEmpty(vo.BOR_Note) ? DBNull.Value : (object)vo.BOR_Note);
                    cmd.Parameters.AddWithValue("@empcode", Global.employees.Emp_Code);
                    cmd.Parameters.AddWithValue("@code", vo.BOR_Code);

                    bool result = cmd.ExecuteNonQuery() > 0 ? true : false;

                    return result;

                }

            }
            catch(Exception err)
            {
                return false;
            }
        }

        public List<BORVO> GetBORList(BORVO vo)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select b.BOR_Code, b.Prod_Code, pd.Prod_Name, b.Pcs_Code, pcs.Pcs_Name, b.Fac_Code, fac.Fac_Name, 
                                                                            b.Tact_Time, b.BOR_Priority, b.BOR_DelayTime, b.BOR_State
	                                                                from BOR as b, Product as pd, ProcessInfo as pcs, Facility as fac
	                                                                where b.Prod_Code = pd.Prod_Code
	                                                                	and b.Pcs_Code = pcs.Pcs_Code
	                                                                	and b.Fac_Code = fac.Fac_Code
	                                                                	and b.Prod_Code = isnull(@prod, b.Prod_Code)
	                                                                	and b.Pcs_Code = isnull(@pcs, b.Pcs_Code)
	                                                                	and	b.Fac_Code = isnull(@fac, b.Fac_Code)
                                                                        and b.BOR_State = isnull(@state, b.BOR_State)
                                                                    order by b.Prod_Code, b.Bor_Priority";

                    cmd.Parameters.AddWithValue("@prod", string.IsNullOrEmpty(vo.Prod_Code)? DBNull.Value : (object)vo.Prod_Code);
                    cmd.Parameters.AddWithValue("@pcs", string.IsNullOrEmpty(vo.Pcs_Code) ? DBNull.Value : (object)vo.Pcs_Code);
                    cmd.Parameters.AddWithValue("@fac", string.IsNullOrEmpty(vo.Fac_Code) ? DBNull.Value : (object)vo.Fac_Code);
                    cmd.Parameters.AddWithValue("@state", string.IsNullOrEmpty(vo.BOR_State) ? DBNull.Value : (object)vo.BOR_State);

                    List<BORVO> list = Helper.DataReaderMapToList<BORVO>(cmd.ExecuteReader());

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
