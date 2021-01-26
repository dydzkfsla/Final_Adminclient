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

        public bool InsertFormInfo(string FromName, string txtMenuName)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "insert into Form_Info(Form_Name, Form_Menu, Fst_Writer) values(@Form_Name, @Form_Menu, @Fst_Writer)"
                };

                sql.Parameters.AddWithValue("@Form_Name", FromName);
                sql.Parameters.AddWithValue("@Form_Menu", txtMenuName);
                sql.Parameters.AddWithValue("@Fst_Writer", Global.employees.Emp_Name);
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

        public void Dispose()
        {
            conn.Dispose();
        }
    }
}
