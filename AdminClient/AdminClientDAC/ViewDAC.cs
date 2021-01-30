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
    public class ViewDAC : IDisposable
    {
        SqlConnection conn;

        public ViewDAC()
        {
            conn = new SqlConnection();
            conn.ConnectionString = Connstring.conn;
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        #region View_EmpForm
        public List<View_EmpFormVO> View_EmpForm(string Emp_Code)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "select Form_Name,Grp_Name,Emp_Code,Form_Menu from View_EmpForm where Emp_Code = @Emp_Code"
                };

                sql.Parameters.AddWithValue("@Emp_Code", Emp_Code);


                using (SqlDataReader reader = sql.ExecuteReader())
                {
                    return Helper.DataReaderMapToList<View_EmpFormVO>(reader);
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
        }
        #endregion


        #region View_EmpForm
        public List<View_FavoritesVO> View_Favorites(string Emp_Code)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "select Form_Name,Grp_Name,Form_Menu from View_EmpFavorites where Emp_Code = @Emp_Code"
                };

                sql.Parameters.AddWithValue("@Emp_Code", Emp_Code);


                using (SqlDataReader reader = sql.ExecuteReader())
                {
                    return Helper.DataReaderMapToList<View_FavoritesVO>(reader);
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
        }
        #endregion
    }
}
