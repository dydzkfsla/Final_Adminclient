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
                     cmd.CommandText = @"select Comp_Code, cd.Prod_Code, pd.Prod_Name, Prod_UnitCount, cd.Prod_Unit, Prod_UnitPrice, Prod_OldUnitPrice, 
		                                                                 	 Convert(varchar, Comp_StartDate, 23) as Comp_StartDate, Convert(varchar, Comp_EndDate, 23) as Comp_EndDate, 
		                                                                	 Item_State, Comp_Div
		                                                                from CompanyDetail as cd, Product as pd
		                                                                where cd.Prod_Code = pd.Prod_Code
		                                                                	 and cd.Comp_Code = @code";

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
        public bool AddCompany(string userID, CompanyVO vo)
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

                    int cnt = cmd.ExecuteNonQuery();

                    if (cnt > 0)
                        return true;
                    else
                        return false;

                }
            }
            catch(Exception err)
            {
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 새 회사정보 입력중 오류 :" + err.Message, err);
                return false;
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
