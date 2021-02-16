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
    public class StockInfoDAC : IDisposable
    {
        SqlConnection conn;
        LoggingUtility Info;
        public StockInfoDAC()
        {
            conn = new SqlConnection(Connstring.conn);
            conn.Open();
            Info = new LoggingUtility("StockInfoDACInFo", "StockInfoDACError", Level.All, 30);
            Info.InfoFolder = "C:\\FP\\Log\\StockInfoDAC\\Info";
            Info.ErrorFolder = "C:\\FP\\Log\\StockInfoDAC\\Error";
        }
        public void Dispose()
        {
            conn.Close();
        }

        /// <summary>
        /// 콤보박ㄱ스 바인딩 아이템들
        /// </summary>
        /// <returns></returns>
        public List<ComboStockVO> GetComboBindingList()
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select pd.Prod_Category, cm.Common_Name, pd.Prod_Unit
	                                                                from Product as pd, Common as cm
	                                                                where pd.Prod_Category = cm.Common_Code";

                    List<ComboStockVO> list = Helper.DataReaderMapToList<ComboStockVO>(cmd.ExecuteReader());

                    return list;
                }
            }
            catch(Exception err)
            {
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 콤보박스 바인딩 불러오기 오류 :" + err.Message, err);
                return null;
            }
        }

        /// <summary>
        /// 검색목록 가져오기
        /// </summary>
        /// <param name="limit">검색제한</param>
        /// <param name="type">창고타입</param>
        /// <param name="unit">물품단위(갯수, 무게 등등)</param>
        /// <returns></returns>
        public List<StockInfoVO> GetStockList(string limit, string type, string unit)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select * from (
                                                                    select row_number() over(order by w.WH_Code) as rownum, w.WH_Code, w.WH_Type, c.Common_Name, w.Prod_Category, w.Common_Name as ProdType, w.Prod_Unit, w.WH_PsyCount, w.Prod_SafetyStock, w.Prod_Code, w.Prod_Name 
                                                                    	from (select wh.WH_Code, wh.WH_Type, pd.Prod_Code, pd.Prod_Category, cm.Common_Name, pd.Prod_Unit, wd.WH_PsyCount, pd.Prod_SafetyStock, pd.Prod_Name
                                                                    					from WareHouse as wh, WareHouseDetail as wd, Product as pd, Common as cm
                                                                    					where wh.WH_Code = wd.WH_Code
                                                                    						and wd.Prod_Code = pd.Prod_Code
                                                                    						and pd.Prod_Category = cm.Common_Code) as w, Common as c
                                                                    				where w.WH_Type = c.Common_Code) as tot
                                                                    	where tot.rownum <= isnull(@limit, 999999)
                                                                    		and tot.Prod_Category = isnull(@type, tot.Prod_Category)
                                                                    		and tot.Prod_Unit = isnull(@unit, tot.Prod_Unit)";

                    cmd.Parameters.AddWithValue("@limit", string.IsNullOrEmpty(limit) ? DBNull.Value : (object)limit);
                    cmd.Parameters.AddWithValue("@type", string.IsNullOrEmpty(type) ? DBNull.Value : (object)type);
                    cmd.Parameters.AddWithValue("@unit", string.IsNullOrEmpty(unit) ? DBNull.Value : (object)unit);

                    List<StockInfoVO> list = Helper.DataReaderMapToList<StockInfoVO>(cmd.ExecuteReader());

                    return list;
                }
            }
            catch(Exception err)
            {
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 콤보박스 바인딩 불러오기 오류 :" + err.Message, err);
                return null;
            }
        }

    }
}
