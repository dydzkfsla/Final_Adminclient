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
    public class InOutDAC
    {
        SqlConnection conn;
        LoggingUtility Info;
        public InOutDAC()
        {
            conn = new SqlConnection(Connstring.conn);
            conn.Open();
            Info = new LoggingUtility("InOutDACInFo", "InOutDACError", Level.All, 30);
            Info.InfoFolder = "C:\\FP\\Log\\InOutDAC\\Info";
            Info.ErrorFolder = "C:\\FP\\Log\\InOutDAC\\Error";
        }

        public List<CombInOutVO> GetComboList()
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select * 
	                                                                from (select Common_Code, Common_Name from Common where Common_Category = 'ProdCtgy') as Pcate
	                                                                full outer join (select Prod_Unit from Product group by Prod_Unit) as unit on Pcate.Common_Code = unit.Prod_Unit
	                                                                order by unit.Prod_Unit";

                    return Helper.DataReaderMapToList<CombInOutVO>(cmd.ExecuteReader());

                }
            }
            catch(Exception err)
            {
                Info.WriteError($"실행자: {Global.employees.Emp_Name} 콤보박스 바인딩 목록 불러오기 오류 :" + err.Message, err);
                return null;
            }
        }

        public List<InOutVO> GetInOutList(string limit, string keyword, string unit, string category, string inout)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select top(Convert(int, @limit)) wh.WH_Code, wh.WH_Type, wh.WH_TypeName, wh.WH_Name, pd.Prod_Code, pd.Prod_Name, cm.Common_Name as Prod_Category, cm.Common_Code as Category_Code, pd.Prod_Unit, wh.WHInOut_Count, wh.WHInOut_Type
	                                                                from (select wh.WH_Code, wh.WH_Type, cm.Common_Name as WH_TypeName, wh.WH_Name, wio.WHInOut_Type, wio.Prod_Code, wio.WHInOut_Count, wio.Fst_WriteDate as Date
	                                                                				from WareHouseInOut as wio, WareHouse as wh, Common as cm
	                                                                				where wio.WH_Code = wh.WH_Code
	                                                                					and wh.WH_Type = cm.Common_Code ) as wh, Product as pd, Common as cm
	                                                                where wh.Prod_Code = pd.Prod_Code
	                                                                	and pd.Prod_Category = cm.Common_Code
	                                                                	and cm.Common_Code = isnull(@category, cm.Common_Code)
	                                                                	and pd.Prod_Unit = isnull(@unit, pd.Prod_Unit)
	                                                                	and wh.WHInOut_Type = isnull(@inout, wh.WHInOut_Type)
	                                                                	and pd.Prod_Name like '%'+isnull(@keyword, '')+'%'";

                    cmd.Parameters.AddWithValue("@limit", string.IsNullOrEmpty(limit)? 10000 : (object)limit);
                    cmd.Parameters.AddWithValue("@category", string.IsNullOrEmpty(category) ? DBNull.Value : (object)category);
                    cmd.Parameters.AddWithValue("@unit", string.IsNullOrEmpty(unit) ? DBNull.Value : (object)unit);
                    cmd.Parameters.AddWithValue("@inout", string.IsNullOrEmpty(inout) ? DBNull.Value : (object)inout);
                    cmd.Parameters.AddWithValue("@keyword", string.IsNullOrEmpty(keyword) ? DBNull.Value : (object)keyword);

                    return Helper.DataReaderMapToList<InOutVO>(cmd.ExecuteReader());

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
