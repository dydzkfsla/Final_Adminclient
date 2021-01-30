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
    public class FavoritesDAC : IDisposable
    {
        SqlConnection conn;

        public FavoritesDAC()
        {
            conn = new SqlConnection();
            conn.ConnectionString = Connstring.conn;
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        #region insert
        public bool InserFavorites(string Emp_Code, string Form_Name)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "insert into Favorites(Emp_Code, Form_Name) values(@Emp_Code,@Form_Name)"
                };
                sql.Parameters.AddWithValue("@Emp_Code", Emp_Code);
                sql.Parameters.AddWithValue("@Form_Name", Form_Name);

                bool Execut = sql.ExecuteNonQuery() > 0 ? true : false;

                return Execut;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }
        #endregion

        #region Delete
        public bool DeleteFavorites(string Emp_Code, string Form_Name)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "Delete from Favorites where Emp_Code = @Emp_Code and Form_Name = @Form_Name"
                };
                sql.Parameters.AddWithValue("@Emp_Code", Emp_Code);
                sql.Parameters.AddWithValue("@Form_Name", Form_Name);

                bool Execut = sql.ExecuteNonQuery() > 0 ? true : false;

                return Execut;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }
        #endregion
    }
}
