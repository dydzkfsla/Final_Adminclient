using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientDAC
{
    public class TeamForFormDAC : IDisposable
    {
        SqlConnection conn;
        public TeamForFormDAC()
        {
            conn = new SqlConnection();
            conn.ConnectionString = Connstring.conn;
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public List<TeamForFormVO> GetAllTeamForForm()
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = @"select [Team_Code]
                                            ,[Form_Name]
                                            ,[Form_Select]
                                            ,[Form_Insert]
                                            ,[Form_Update]
                                            ,[Form_Delete] 
                                            from TeamForForm"
                };

                using (SqlDataReader reader = sql.ExecuteReader())
                {
                    return Helper.DataReaderMapToList<TeamForFormVO>(reader);
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
        }

        public bool UpdateTeamForForm(string TeamCode, string Form_Name, bool Chcked , string UpdateColum)
        {
            try
            {
                
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = @"SP_InsertTeamForForm",
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                sql.Parameters.AddWithValue("@UpdateColum", UpdateColum);
                sql.Parameters.AddWithValue("@Updatedata", Chcked);
                sql.Parameters.AddWithValue("@TeamCode", TeamCode);
                sql.Parameters.AddWithValue("@Form_Name", Form_Name);
                return sql.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }
    }
}
