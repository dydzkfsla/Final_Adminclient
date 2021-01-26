using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientDAC
{
    public class FormInfoDAC : IDisposable
    {
        SqlConnection conn;

        public FormInfoDAC()
        {
            conn = new SqlConnection(Connstring.conn);
            conn.Open();
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

        public void Dispose()
        {
            conn.Dispose();
        }
    }
}
