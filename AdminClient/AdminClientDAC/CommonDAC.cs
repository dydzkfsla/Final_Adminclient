using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientDAC
{
    public class CommonDAC : IDisposable
    {
        string strConn;
        SqlConnection conn;
        public CommonDAC()
        {
            strConn = "Server=whyfi8888.ddns.net,11433;Database=TEAM4;Uid=team4;Pwd=team4"; //나중에 암호화 복호화로 변경
            conn = new SqlConnection(strConn);
            conn.Open();
        }
        public void Dispose()
        {
            conn.Close();
        }


        public List<ComboCommonVO> GetComboBindingList()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select Common_Name, Common_Category from Common where len(Common_Pcode) < 1";

                    List<ComboCommonVO> list = Helper.DataReaderMapToList<ComboCommonVO>(cmd.ExecuteReader());
                    return list;
                }
            }
            catch(Exception err)
            {
                return null;
            }
        }

        public bool CommonAdd(CommonVO vo)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand()) // 이미 추가되어있는 코드인지 확인 필요, 입력자 로그인완성되면 추가
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into Common(Common_Code, Common_Name, Common_Category, Common_Pcode, Fst_Writer, Fst_WriteDate) 
                                                                                        values(@code, @name, @cate, @pcode, 'a', getdate());";

                    cmd.Parameters.AddWithValue("@code", vo.Common_Code);
                    cmd.Parameters.AddWithValue("@name", vo.Common_Name);
                    cmd.Parameters.AddWithValue("@cate", vo.Common_Category);
                    cmd.Parameters.AddWithValue("@pcode", string.IsNullOrEmpty(vo.Common_Pcode)? DBNull.Value : (object)vo.Common_Pcode);

                    int cnt = cmd.ExecuteNonQuery();

                    if (cnt > 0)
                        return true;
                    else
                        return false;
                }
            }
            catch(Exception err)
            {
                string errmsg = err.Message;
                return false;
            }
        }

        public bool CommonDelete(string code)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"delete from Common where Common_Code = @code";

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

        public bool UpdateCommon(string code, string cate, string name, string pcode) //Lst_Writer, Lst_WriteDate 로그인완료되면 추가
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update Common 
                                                                    set Common_Name = @name, Common_Category = @cate, Common_Pcode = @pcode 
                                                                    where Common_Code = @code";

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@cate", cate);
                    cmd.Parameters.AddWithValue("@pcode", string.IsNullOrEmpty(pcode) ? DBNull.Value : (object)pcode);
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

        public List<CommonVO> GetCommonList(string limit, string category)  //나중에 row로 바꿔볼예정
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select top(@limit) Common_Code, Common_Name, Common_Category, Common_Pcode 
	                                                            from Common 
	                                                            where len(Common_Pcode) > 0 
	                                                            	and  Common_Category = isnull(@cate, Common_Category);";

                    cmd.Parameters.AddWithValue("@limit", string.IsNullOrEmpty(limit) ? 999 : (object)(int.Parse(limit)));
                    cmd.Parameters.AddWithValue("@cate", string.IsNullOrEmpty(category) ? DBNull.Value : (object)category);

                    List<CommonVO> list = Helper.DataReaderMapToList<CommonVO>(cmd.ExecuteReader());
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
