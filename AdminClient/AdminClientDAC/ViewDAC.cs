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

        public List<View_FormConnGroupVO> View_FormConnGroup() 
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "select Form_Menu, Form_Name, Grp_No from View_FormConnGroup"
                };


                using (SqlDataReader reader = sql.ExecuteReader())
                {
                    return Helper.DataReaderMapToList<View_FormConnGroupVO>(reader);
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }

        }


        #region View_EmpForm
        public List<View_EmpFormVO> View_EmpForm(string Emp_Code)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "select Form_Name,Grp_Name,Emp_Code,Form_Menu, Form_Insert, Form_Select, Form_Update, Form_Delete from View_EmpForm where Emp_Code = @Emp_Code"
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

        #region View_Favorites
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

        #region View_EmpForm
        public List<View_ProductNameAndCheckVO> View_ProductNameAndCheck(string Code)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = $"select {Code} Prod_Code, Prod_Name, Check_Type, Check_System, Check_Point, Check_Item, Check_Standard from View_ProductNameAndCheck"
                };


                using (SqlDataReader reader = sql.ExecuteReader())
                {
                    return Helper.DataReaderMapToList<View_ProductNameAndCheckVO>(reader);
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
