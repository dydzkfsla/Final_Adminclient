using AdminClientVO;
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
    public class WareHouseDAC : IDisposable
    {
        SqlConnection conn;
        LoggingUtility Info;
        public WareHouseDAC()
        {
            conn = new SqlConnection(Connstring.conn);
            conn.Open();
            Info = new LoggingUtility("WareHouseDACInFo", "WareHouseDACError", Level.All, 30);
            Info.InfoFolder = "C:\\FP\\Log\\WareHouseDAC\\Info";
            Info.ErrorFolder = "C:\\FP\\Log\\WareHouseDAC\\Error";
        }
        public void Dispose()
        {
            conn.Close();
        }

        public List<WareHouseVO> GetWareHouseList(string limit, string type, string state)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select tot.WH_Code, tot.WH_Name, tot.WH_Type, tot.Common_Name, tot.WH_State
	                                                                from ( select ROW_NUMBER() over(order by wh.WH_Code) as rownum, wh.WH_Code, wh.WH_Name, wh.WH_Type, cm.Common_Name, wh.WH_State 
	                                                                				from WareHouse as wh, Common cm 
	                                                                				where wh.WH_Type = cm.Common_Code) as tot
	                                                                where tot.rownum <= isnull(@limit, 10000)
	                                                                	and tot.WH_Type = isnull(@type, tot.WH_Type)
	                                                                	and tot.WH_State = isnull(@state, tot.WH_State)";

                    cmd.Parameters.AddWithValue("@limit", string.IsNullOrEmpty(limit) ? DBNull.Value : (object)limit);
                    cmd.Parameters.AddWithValue("@type", string.IsNullOrEmpty(type) ? DBNull.Value : (object)type);
                    cmd.Parameters.AddWithValue("@state", string.IsNullOrEmpty(state) ? DBNull.Value : (object)state);

                    List<WareHouseVO> list = Helper.DataReaderMapToList<WareHouseVO>(cmd.ExecuteReader());

                    return list;
                }
            }
            catch(Exception err)
            {
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 창고 목록 불러오기 오류 :" + err.Message, err);
                return null;
            }
        }

        public List<WhDetailVO> GetDetailList(string code)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select wd.WH_Code, cm.Common_Name, wd.Prod_Code, pd.Prod_Name, pd.Prod_Unit, wd.WH_PsyCount, wd.WH_LogCount, pd.Prod_SafetyStock
	                                                                from WareHouseDetail as wd, Product as pd , Common as cm
	                                                                where wd.Prod_Code = pd.Prod_Code
	                                                                	and pd.Prod_Category = cm.Common_Code
	                                                                	and wd.WH_Code = @code";

                    cmd.Parameters.AddWithValue("@code", string.IsNullOrEmpty(code) ? DBNull.Value : (object)code);

                    List<WhDetailVO> list = Helper.DataReaderMapToList<WhDetailVO>(cmd.ExecuteReader());

                    return list;
                }
            }
            catch(Exception err)
            {
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 창고 상세 목록 불러오기 오류 :" + err.Message, err);
                return null;
            }
        }

        public List<ComboWhVO> GetComboBindingList()
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select Common_Code, Common_Name from Common where Common_Category = 'WHList'";

                    List<ComboWhVO> list = Helper.DataReaderMapToList<ComboWhVO>(cmd.ExecuteReader());

                    return list;
                }
            }
            catch(Exception err)
            {
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 콤보박스 바인딩 목록 불러오기 오류 :" + err.Message, err);
                return null;
            }
        }


        #region POPUP
        public bool UpdateWareHouse(WareHouseVO vo)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update WareHouse 
                                                                    set WH_Name = @name, WH_Type = @type, WH_State = @state, Lst_Writer = @id, Lst_WriteDate = getdate() 
                                                                    where WH_Code = @code";

                    cmd.Parameters.AddWithValue("@name", vo.WH_Name);
                    cmd.Parameters.AddWithValue("@code", vo.WH_Code);
                    cmd.Parameters.AddWithValue("@type", vo.WH_Type);
                    cmd.Parameters.AddWithValue("@state", vo.WH_State);
                    cmd.Parameters.AddWithValue("@id", Global.employees.Emp_Code);

                    bool result = cmd.ExecuteNonQuery() > 0 ? true : false;

                    return result;
                }
            }
            catch(Exception err)
            {
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 창고정보 수정 오류 :" + err.Message, err);
                return false;
            }
        }
        public string AddWareHouse(WareHouseVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_NewWareHouseAdd";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@name", vo.WH_Name);
                    cmd.Parameters.AddWithValue("@type", vo.WH_Type);
                    cmd.Parameters.AddWithValue("@state", vo.WH_State);
                    cmd.Parameters.AddWithValue("@empcode", Global.employees.Emp_Code);
                    SqlParameter outcode = new SqlParameter("@whcode", SqlDbType.VarChar, 7);
                    outcode.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outcode);

                    bool result = cmd.ExecuteNonQuery() > 0 ? true : false;
                    string code = string.Empty;

                    if (result)
                        code = outcode.Value.ToString();

                    return code;
                }
            }
            catch (Exception err)
            {
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 창고 목록 추가중 오류 :" + err.Message, err);
                return string.Empty;
            }
        }

        public bool DeleteWareHouse(string code)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update WareHouse set WH_State = 'N' where WH_Code = @code";
                    cmd.Parameters.AddWithValue("@code", code);

                    bool result = cmd.ExecuteNonQuery() > 0 ? true : false;

                    return result;
                }
            }
            catch(Exception err)
            {
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 창고 비활성화중 오류 :" + err.Message, err);
                return false;
            }

        }

        #endregion

    }
}
