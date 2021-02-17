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
    public class CompanyDAC : IDisposable
    {
        SqlConnection conn;
        LoggingUtility Info;

        public CompanyDAC()
        {
            conn = new SqlConnection(Connstring.conn);
            conn.Open();
            Info = new LoggingUtility("CompanyDACInFo", "CompanyDACError", Level.All, 30);
            Info.InfoFolder = "C:\\FP\\Log\\CompanyDAC\\Info";
            Info.ErrorFolder = "C:\\FP\\Log\\CompanyDAC\\Error";
        }
        public void Dispose()
        {
            conn.Close();
        }

        /// <summary>
        /// 검색조건의 콤보박스에 바인딩 될 목록 가져오기
        /// </summary>
        /// <returns></returns>
        public List<ComboCompVO> GetComboBindingList()
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select Common_Code, Common_Name from Common where Common_Category = 'CompLst'";

                    List<ComboCompVO> list = Helper.DataReaderMapToList<ComboCompVO>(cmd.ExecuteReader());
                    return list;
                }

            }
            catch(Exception err)
            {
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 콤보박스 바인딩 목록 불러오기 오류 :" + err.Message, err);
                return null;
            }
        }

        /// <summary>
        /// 검색조건에 따른 회사 정보 가져오기
        /// </summary>
        /// <param name="limit">검색제한수</param>
        /// <param name="auto">자동출하여부</param>
        /// <param name="state">사용여부</param>
        /// <param name="type">회사타입</param>
        /// <returns></returns>
        public List<CompanyVO> GetCompanyList(string limit, string auto, string state, string type)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select top(convert(int, @limit)) ci.Comp_Code, ci.Comp_Name, ci.Comp_CEO, ci.Comp_Type, ci.Comp_Auto, ci.Comp_State, cm.Common_Name 
	                                                                from CompanyInfo as ci, Common as cm
	                                                                where ci.Comp_Type = cm.Common_Code
	                                                                	and ci.Comp_Auto = isnull(@auto, ci.Comp_Auto)
	                                                                	and ci.Comp_State = isnull(@state, ci.Comp_State)
	                                                                	and ci.Comp_Type = isnull(@type, ci.Comp_Type)";

                    cmd.Parameters.AddWithValue("@limit", string.IsNullOrEmpty(limit) ? 100000 : (object)limit);
                    cmd.Parameters.AddWithValue("@auto", string.IsNullOrEmpty(auto) ? DBNull.Value : (object)auto);
                    cmd.Parameters.AddWithValue("@state", string.IsNullOrEmpty(state) ? DBNull.Value : (object)state);
                    cmd.Parameters.AddWithValue("@type", string.IsNullOrEmpty(type) ? DBNull.Value : (object)type);

                    List<CompanyVO> list = Helper.DataReaderMapToList<CompanyVO>(cmd.ExecuteReader());

                    return list;

                }
            }
            catch(Exception err)
            {
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 회사목록 불러오기 오류 :" + err.Message, err);
                return null;
            }
        }

        public bool CompInfoDel(string compcode)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "update CompanyInfo set Comp_State = 'N' where Comp_Code = @code";

                    cmd.Parameters.AddWithValue("@code", compcode);

                    return cmd.ExecuteNonQuery() > 0 ? true : false;

                }
            }
            catch(Exception err)
            {
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 회사정보 비활성화 작업중 오류 :" + err.Message, err);
                return false;
            }
        }

        public bool UpdateCompInfo(CompanyDetailVO cpinfo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update CompanyDetail 
	                                                                set Prod_MinCount = @min, Prod_OldUnitPrice = Prod_UnitPrice, 
	                                                                	   Prod_UnitPrice = @price, Item_State = @state, 
	                                                                	   Lst_Writer = @empcode, Lst_WriteDate = getdate()
	                                                                where Comp_Code = @code 
	                                                                	and Prod_Code = @pdcode";

                    cmd.Parameters.AddWithValue("@min", cpinfo.Prod_MinCount);
                    cmd.Parameters.AddWithValue("@price", cpinfo.Prod_UnitPrice);
                    cmd.Parameters.AddWithValue("@state", cpinfo.item_State);
                    cmd.Parameters.AddWithValue("@empcode", Global.employees.Emp_Code);
                    cmd.Parameters.AddWithValue("@code", cpinfo.Comp_Code);
                    cmd.Parameters.AddWithValue("@pdcode", cpinfo.Prod_Code);

                    return cmd.ExecuteNonQuery() > 0 ? true : false;

                }
            }
            catch(Exception err)
            {
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 회사 물품 정보수정중 오류 :" + err.Message, err);
                return false;
            }
        }

        public bool SetUpdateList(List<CompanyDetailVO> updateList)
        {
            SqlTransaction trans = conn.BeginTransaction();

            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update CompanyDetail 
		                                                            set Prod_MinCount = @min, Prod_UnitPrice = @uprice, Prod_OldUnitPrice = @oldprice, Item_State = @state 
		                                                            where Comp_Code = @code and Prod_Code = @pcode";

                    cmd.Transaction = trans;

                    try
                    {
                        for(int i = 0; i<updateList.Count; i++)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@code", updateList[i].Comp_Code);
                            cmd.Parameters.AddWithValue("@pcode", updateList[i].Prod_Code);
                            cmd.Parameters.AddWithValue("@min", updateList[i].Prod_MinCount);
                            cmd.Parameters.AddWithValue("@uprice", updateList[i].Prod_UnitPrice);
                            cmd.Parameters.AddWithValue("@oldprice", updateList[i].Prod_OldUnitPrice);
                            cmd.Parameters.AddWithValue("@state", updateList[i].item_State);

                            cmd.ExecuteNonQuery();

                        }

                        trans.Commit();
                        return true;
                    }
                    catch 
                    {
                        throw;
                    }
                }
            }
            catch(Exception err)
            {
                trans.Rollback();
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 물품 정보 변경목록들 수정중 오류 :" + err.Message, err);
                return false;
            }
        }

        public bool CompDetailAddProdList(List<ProductVO> addlist, string code)
        {
            SqlTransaction trans = conn.BeginTransaction();

            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SP_CompDetailAddProduct";
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    cmd.Transaction = trans;

                    try
                    {
                        for (int i = 0; i < addlist.Count; i++)
                        {
                            cmd.Parameters.AddWithValue("@code", code);
                            cmd.Parameters.AddWithValue("@pcode", addlist[i].Prod_Code);
                            cmd.Parameters.AddWithValue("@unit", addlist[i].Prod_Unit);
                            cmd.Parameters.AddWithValue("@empcode", Global.employees.Emp_Code);

                            cmd.ExecuteNonQuery();

                            cmd.Parameters.Clear();
                        }
                        trans.Commit();
                        return true;

                    }
                    catch
                    {
                        throw;
                    }
                }
            }
            catch(Exception err)
            {
                trans.Rollback();
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 회사 디테일 물품 추가중 오류 :" + err.Message, err);
                return false;
            }
        }

        /// <summary>
        /// 선택된 회사의 취급물품 정보를 가져옴
        /// </summary>
        /// <param name="code">회사코드</param>
        /// <returns></returns>
        public List<CompanyDetailVO> GetDetailInfo(string code)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                     cmd.CommandText = @"select cd.Comp_Code, pd.Prod_Code, pd.Prod_Name, pd.Prod_Unit, cd.Prod_MinCount, 
                                                                             cd.Prod_UnitPrice, cd.Prod_OldUnitPrice, cd.Item_State, pd.Prod_WhCode, pd.Prod_SafetyStock, 
	                                                                         tot.totCount, isnull(pc.Check_Point, '없음') as Check_Point
	                                                                from CompanyDetail as cd
	                                                                inner join Product as pd on cd.Prod_Code = pd.Prod_Code
	                                                                inner join (select Prod_Code, sum(wd.WH_PsyCount) as totCount 
	                                                                						from WareHouseDetail as wd, WareHouse as wh
                                                                                            where wd.WH_Code = wh.WH_Code
								                                                                and wh.WH_Type not in ('WareH05', 'WareH06')
	                                                                						group by wd.Prod_Code) as tot on cd.Prod_Code = tot.Prod_Code
	                                                                left outer join ProductCheck as pc on cd.Prod_Code = pc.Prod_Code
	                                                                where cd.Comp_Code = @code";

                    cmd.Parameters.AddWithValue("@code", code);

                    List<CompanyDetailVO> list = Helper.DataReaderMapToList<CompanyDetailVO>(cmd.ExecuteReader());

                    return list;
                }
            }
            catch(Exception err)
            {
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 회사 디테일 목록 불러오기 오류 :" + err.Message, err);
                return null;
            }
        }

        #region PopUp

        /// <summary>
        /// CompanyPopUp 콤보박스의 회사타입 바인딩
        /// </summary>
        /// <returns></returns>
        public List<CompanyPopUpVO> GetCompanyTypeList_Popup()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select Common_Code, Common_Name from Common where Common_Category = 'CompLst' and len(Common_Pcode) > 0";

                    List<CompanyPopUpVO> list = Helper.DataReaderMapToList<CompanyPopUpVO>(cmd.ExecuteReader());

                    return list;
                }
            }
            catch(Exception err)
            {
                Info.WriteError($"실행자:{Global.employees.Emp_Name} POP 콤보박스 바인딩 불러오기 오류 :" + err.Message, err);
                return null;
            } 
        }

        /// <summary>
        /// 새 회사정보 입력 , 프로시저이용
        /// </summary>
        /// <param name="userID">입력자</param>
        /// <param name="vo">회사정보</param>
        /// <returns></returns>
        public string AddCompany(string userID, CompanyVO vo)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_NewCompanyAdd";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@uid", userID);
                    cmd.Parameters.AddWithValue("@name", vo.Comp_Name);
                    cmd.Parameters.AddWithValue("@type", vo.Comp_Type);
                    cmd.Parameters.AddWithValue("@state", vo.Comp_State);
                    cmd.Parameters.AddWithValue("@auto", vo.Comp_Auto);
                    cmd.Parameters.AddWithValue("@ceo", vo.Comp_CEO);
                    cmd.Parameters.Add("@result", SqlDbType.VarChar, 7);
                    cmd.Parameters["@result"].Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    string result = "";
                    result = cmd.Parameters["@result"].Value.ToString();

                    if (result.Length > 0)
                        return result;
                    else
                        return null;

                }
            }
            catch(Exception err)
            {
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 새 회사정보 입력중 오류 :" + err.Message, err);
                return null;
            }
        }

        /// <summary>
        /// 기존 회사정보 수정
        /// </summary>
        /// <param name="userID">입력자</param>
        /// <param name="vo">회사정보</param>
        /// <returns></returns>
        public bool UpdateCompany(string userID, CompanyVO vo)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update CompanyInfo 
	                                                                set Comp_Name = @name, Comp_Auto = @auto, Comp_State = @state, 
	                                                                	   Comp_Type = @type, Comp_CEO = @ceo
	                                                                where Comp_Code = @code";

                    cmd.Parameters.AddWithValue("@name", vo.Comp_Name);
                    cmd.Parameters.AddWithValue("@auto", vo.Comp_Auto);
                    cmd.Parameters.AddWithValue("@state", vo.Comp_State);
                    cmd.Parameters.AddWithValue("@type", vo.Comp_Type);
                    cmd.Parameters.AddWithValue("@ceo", string.IsNullOrEmpty(vo.Comp_CEO)? DBNull.Value : (object)vo.Comp_CEO);
                    cmd.Parameters.AddWithValue("@code", vo.Comp_Code);

                    int cnt = cmd.ExecuteNonQuery();

                    if (cnt > 0)
                        return true;
                    else
                        return false;
                }

            }
            catch(Exception err)
            {
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 회사정보 수정중 오류 :" + err.Message, err);
                return false;
            }
        }

        #endregion
    }
}
