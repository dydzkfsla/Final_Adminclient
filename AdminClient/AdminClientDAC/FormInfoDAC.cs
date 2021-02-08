using AdminClientVO;
using log4net.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientDAC
{
    public class FormInfoDAC : IDisposable
    {
        SqlConnection conn;
        LoggingUtility Info;

        public FormInfoDAC()
        {
            conn = new SqlConnection(Connstring.conn);
            conn.Open();
            Info = new LoggingUtility("FormInfoDACInFo", "FormErorrDACInFo",  Level.All, 30);
            Info.InfoFolder = "C:\\FP\\Log\\FormInfoDAC\\Info";
            Info.ErrorFolder = "C:\\FP\\Log\\FormInfoDAC\\Error";
        }

        #region select

        /// <summary>
        /// 모든 리스트 
        /// </summary>
        /// <returns></returns>
        public List<FormInfoVO> GetAllList()
        {
            SqlCommand sql = new SqlCommand
            {
                Connection = conn,
                CommandText = "select Form_Name, Form_Menu from Form_Info"
            };


            using (SqlDataReader reader = sql.ExecuteReader()) {
                return Helper.DataReaderMapToList<FormInfoVO>(reader);
            }
        }

        #endregion

        #region inset
        /// <summary>
        /// 입력
        /// </summary>
        /// <param name="FromName"></param>
        /// <param name="txtMenuName"></param>
        /// <returns></returns>
        public bool InsertFormInfo(string FromName, string txtMenuName)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "insert into Form_Info(Form_Name, Form_Menu, Fst_Writer, Fst_WriteDate) values(@Form_Name, @Form_Menu, @Fst_Writer, getdate())"
                };

                sql.Parameters.AddWithValue("@Form_Name", FromName);
                sql.Parameters.AddWithValue("@Form_Menu", txtMenuName);
                sql.Parameters.AddWithValue("@Fst_Writer", Global.employees.Emp_Code);
                bool Execut = sql.ExecuteNonQuery() > 0 ? true : false;

                if (Execut)
                {
                    Info.WriteInfo($"실행자:{Global.employees.Emp_Name} 폼 메뉴 입력 {FromName} : {txtMenuName}");
                }

                return Execut;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 폼 메뉴 입력중 오류 :" + err.Message, err);
                return false;
            }

        }

        #endregion

        #region Update
        /// <summary>
        /// 폼 선택하여 메뉴 이름 업데이트
        /// </summary>
        /// <param name="FromName"></param>
        /// <param name="txtMenuName"></param>
        /// <returns></returns>
        public bool UpdateFormInfo(string FromName, string txtMenuName)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = @"Update Form_Info 
                                    set Form_Menu = @Form_Menu,
                                    Lst_Writer = @Lst_Writer,
                                    Lst_WriteDate = getdate()
                                    where Form_Name = @Form_Name;"
                };

                sql.Parameters.AddWithValue("@Form_Name", FromName);
                sql.Parameters.AddWithValue("@Form_Menu", txtMenuName);
                sql.Parameters.AddWithValue("@Lst_Writer", Global.employees.Emp_Name);
                bool Execut = sql.ExecuteNonQuery() > 0 ? true : false;

                if (Execut)
                {
                    Info.WriteInfo($"실행자:{Global.employees.Emp_Name} 폼 메뉴 수정 {FromName} : {txtMenuName}");
                }

                return Execut;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 폼 메뉴 수정중 오류 :" + err.Message, err);
                return false;
            }
        }
        #endregion

        #region delete

        /// <summary>
        /// 폼메뉴 삭제
        /// </summary>
        /// <param name="FormName"></param>
        /// <returns></returns>
        public bool DeleteFormInfo(string FormName)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = @"delete from Form_Info
                where Form_Name = @Form_Name;"
                };
                sql.Parameters.AddWithValue("@Form_Name", FormName);


                bool Execut = sql.ExecuteNonQuery() > 0 ? true : false;

                if (Execut)
                {
                    Info.WriteInfo($"실행자:{Global.employees.Emp_Name} 폼 메뉴 삭제 {FormName}");
                }

                return Execut;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                Info.WriteError($"실행자:{Global.employees.Emp_Name} 폼 메뉴 삭제중 오류 {FormName} :" + err.Message, err);
                return false;
            }
        }

        #endregion

        public void Dispose()
        {
            Info.CloseRoller();
            conn.Dispose();
        }
    }
}
