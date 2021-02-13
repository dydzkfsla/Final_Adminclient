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
    public class ProductDAC : IDisposable
    {
        SqlConnection conn;
        LoggingUtility Info;
        public ProductDAC()
        {
            conn = new SqlConnection(Connstring.conn);
            conn.Open();
            Info = new LoggingUtility("ProductDACInFo", "ProductDACError", Level.All, 30);
            Info.InfoFolder = "C:\\FP\\Log\\ProductDAC\\Info";
            Info.ErrorFolder = "C:\\FP\\Log\\ProductDAC\\Error";
        }

        public void Dispose()
        {
            conn.Close();
        }

        /// <summary>
        /// 콤보바인딩용 데이터 불러오기
        /// </summary>
        /// <returns></returns>
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
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 콤보바인딩 목록 불러오는 중 오류 :" + err.Message, err);
                return null;
            }
        }

        public string AddProduct(ProductVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SP_NewProductAdd";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@cate", vo.Prod_Category);
                    cmd.Parameters.AddWithValue("@state", vo.Prod_State);
                    cmd.Parameters.AddWithValue("@safety", vo.Prod_SafetyStock);
                    cmd.Parameters.AddWithValue("@whcode", vo.Prod_WhCode);
                    cmd.Parameters.AddWithValue("@unit", vo.Prod_Unit);
                    cmd.Parameters.AddWithValue("@name", vo.Prod_Name);
                    cmd.Parameters.AddWithValue("@empcode", Global.employees.Emp_Code);
                    SqlParameter outcode = new SqlParameter("@pdcode", SqlDbType.VarChar, 7);
                    outcode.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outcode);

                    bool result = cmd.ExecuteNonQuery() > 0 ? true : false;
                    string code = string.Empty;

                    if (result)
                        code = outcode.Value.ToString();

                    return code;
                }
            }
            catch(Exception err)
            {
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 새 물품 정보 등록중 오류 :" + err.Message, err);
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
                    cmd.CommandText = @"update Product 
                                                                        set Prod_State = 'N', 
                                                                               Lst_Writer = @id, 
                                                                               Lst_WriteDate = getdate()
                                                                        where Prod_Code = @code";

                    cmd.Parameters.AddWithValue("@code", code);
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
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 기존 물품 비활성화 중 오류 :" + err.Message, err);
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
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 기존 물품 정보 수정중 오류 :" + err.Message, err);
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
                    cmd.CommandText = @"select top(convert(int, @limit)) pd.Prod_Code, pd.Prod_Category, cm.Common_Name, pd.Prod_Name, 
                                                                            pd.Prod_Unit, pd.Prod_State, pd.Prod_WhCode, pd.Prod_SafetyStock, wd.totcnt
	                                                                from Product as pd, Common as cm, (select Prod_Code, sum(WH_PsyCount) as totcnt from WareHouseDetail group by Prod_Code) as wd
	                                                                where pd.Prod_Category = cm.Common_Code
																		and pd.Prod_Code = wd.Prod_Code
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
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 물품 정보 불러오는중 오류 :" + err.Message, err);
                return null;
            }
        }
    }
}
