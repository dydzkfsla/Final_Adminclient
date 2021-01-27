using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientDAC
{
    public class ProductDAC : IDisposable
    {
        string strConn;
        SqlConnection conn;

        public ProductDAC()
        {
            strConn = "Server=whyfi8888.ddns.net,11433;Database=TEAM4;Uid=team4;Pwd=team4"; //나중에 암호화 복호화로 변경
            conn = new SqlConnection(strConn);
            conn.Open();
        }
        public void Dispose()
        {
            conn.Close();
        }
        public List<ComboProductVO> GetComboBindingList()
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select cm.Common_Code, cm.Common_Name, pd.Prod_Unit, pd.Prod_State 
	                                                                    from Product as pd, Common as cm
	                                                                    where pd.Prod_Category = cm.Common_Code";

                    List<ComboProductVO> list = Helper.DataReaderMapToList<ComboProductVO>(cmd.ExecuteReader());

                    return list;
                }
            }
            catch(Exception err)
            {
                return null;
            }
        }

        public bool DeleteProduct(string code) // 로그인완성시 변경자 입력추가
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update Product set Prod_State = 'N' where Prod_Code = @code";

                    cmd.Parameters.AddWithValue("@code", code);

                    int cnt = cmd.ExecuteNonQuery();

                    if (cnt > 0)
                        return true;
                    else
                        return false;

                }
            }
            catch(Exception err)
            {
                return false;
            }
        }

        public bool UpdateProduct(ProductVO vo) // 로그인 완성시 변경자 이름 추가
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update Product 
                                                                    set Prod_Name = @name, 
                                                                           Prod_Category = @cate, 
                                                                           Prod_WhCode = @wh, 
                                                                           Prod_State = @state, 
                                                                           Prod_SafetyStock = @stock, 
                                                                           Lst_Writer = @id, 
                                                                           Lst_WriteDate = getdate()
                                                                    where Prod_Code = @code";

                    cmd.Parameters.AddWithValue("@code", vo.Prod_Code);
                    cmd.Parameters.AddWithValue("@cate", vo.Prod_Category);
                    cmd.Parameters.AddWithValue("@name", vo.Prod_Name);
                    cmd.Parameters.AddWithValue("@wh", vo.Prod_WhCode);
                    cmd.Parameters.AddWithValue("@state", vo.Prod_State);
                    cmd.Parameters.AddWithValue("@stock", vo.Prod_SafetyStock);
                    cmd.Parameters.AddWithValue("@id", Global.employees.Emp_Code);

                    int cnt = cmd.ExecuteNonQuery();

                    if (cnt > 0)
                        return true;
                    else
                        return false;
                }
            }
            catch(Exception err)
            {
                return false;
            }
        }

        public List<ProductVO> GetProdList(string cate, string unit, string state, string limit)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select top(convert(int, @limit)) pd.Prod_Code, pd.Prod_Category, cm.Common_Name, pd.Prod_Name, pd.Prod_Unit, pd.Prod_State, pd.Prod_WhCode, pd.Prod_SafetyStock
	                                                                from Product as pd, Common as cm
	                                                                where pd.Prod_Category = cm.Common_Code
	                                                                	and pd.Prod_Category = isnull(@cate, pd.Prod_Category)
	                                                                	and pd.Prod_Unit = isnull(@unit, pd.Prod_Unit)
	                                                                	and pd.Prod_State = isnull(@state, pd.Prod_State)";

                    cmd.Parameters.AddWithValue("@limit", string.IsNullOrEmpty(limit) ? 99999 : (object)limit);
                    cmd.Parameters.AddWithValue("@cate", string.IsNullOrEmpty(cate) ? DBNull.Value : (object)cate);
                    cmd.Parameters.AddWithValue("@unit", string.IsNullOrEmpty(unit) ? DBNull.Value : (object)unit);
                    cmd.Parameters.AddWithValue("@state", string.IsNullOrEmpty(state) ? DBNull.Value : (object)state);


                    List<ProductVO> list = Helper.DataReaderMapToList<ProductVO>(cmd.ExecuteReader());
                    return list;
                }
            }
            catch(Exception err)
            {
                return null;
            }
        }
    }
}
