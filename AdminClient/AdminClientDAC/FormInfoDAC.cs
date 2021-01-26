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
        LoggingUtility logging;
        public FormInfoDAC()
        {
            conn = new SqlConnection(Connstring.conn);
            conn.Open();
            logging = new LoggingUtility("FormInfoDac", Level.All, 30, "C:\\FP\\Log\\FormInfoDAC");
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
                    logging.WriteInfo($"실행자:{Global.employees.Emp_Name} 폼 메뉴 입력 {FromName} : {txtMenuName}");
                }

                return Execut;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                logging.WriteError($"실행자:{Global.employees.Emp_Name} 폼 메뉴 입력중 오류 :" + err.Message, err);
                return false;
            }

        }

        public void Dispose()
        {
            conn.Dispose();
        }
    }
}
