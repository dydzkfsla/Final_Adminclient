using log4net.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientDAC
{
    public class ProductCheckDAC : IDisposable
    {
		SqlConnection conn;
		LoggingUtility Info;

		public ProductCheckDAC()
		{
			conn = new SqlConnection(Connstring.conn);
			conn.Open();
			Info = new LoggingUtility("ProductCheckDACInfo", "ProductCheckDACError", Level.All, 30);
			Info.InfoFolder = "C:\\FP\\Log\\ProductCheckDAC\\Info";
			Info.ErrorFolder = "C:\\FP\\Log\\ProductCheckDAC\\Error";
		}

		public bool InsertProductCheck(string Prod_Code,string Check_Type, string Check_System, string Check_Point, string Check_Item, string Check_Standard)
        {
			SqlCommand sql = new SqlCommand()
			{
				Connection = conn,
				CommandText = @"insert into ProductCheck(Prod_Code, Check_Type, Check_System, Check_Point, Check_Item, Check_Standard, Fst_Writer)
				values(@Prod_Code, @Check_Type, @Check_System, @Check_Point, @Check_Item, @Check_Standard, @Fst_Writer)"
			};
			sql.Parameters.AddWithValue("@Prod_Code", Prod_Code);
			sql.Parameters.AddWithValue("@Check_Type", Check_Type);
			sql.Parameters.AddWithValue("@Check_System", Check_System);
			sql.Parameters.AddWithValue("@Check_Point", Check_Point);
			sql.Parameters.AddWithValue("@Check_Item", Check_Item);
			sql.Parameters.AddWithValue("@Check_Standard", Check_Standard);
			sql.Parameters.AddWithValue("@Fst_Writer", Global.employees.Emp_Code);

			return sql.ExecuteNonQuery() > 0;
		}

		public bool UpdateProductCheck(string Prod_Code, string Check_Type, string Check_System, string Check_Point, string Check_Item, string Check_Standard)
		{
			SqlCommand sql = new SqlCommand()
			{
				Connection = conn,
				CommandText = @"Update ProductCheck set Check_System = @Check_System, 
								Check_Point = @Check_Point, 
								Check_Item = @Check_Item, 
								Check_Standard = @Check_Standard, 
								Lst_Writer = @Fst_Writer,
								Lst_WriteDate = getdate()
								where Prod_Code = @Prod_Code and Check_Type = @Check_Type"
				//(Prod_Code, Check_Type
			};
			sql.Parameters.AddWithValue("@Prod_Code", Prod_Code);
			sql.Parameters.AddWithValue("@Check_Type", Check_Type);
			sql.Parameters.AddWithValue("@Check_System", Check_System);
			sql.Parameters.AddWithValue("@Check_Point", Check_Point);
			sql.Parameters.AddWithValue("@Check_Item", Check_Item);
			sql.Parameters.AddWithValue("@Check_Standard", Check_Standard);
			sql.Parameters.AddWithValue("@Fst_Writer", Global.employees.Emp_Code);

			return sql.ExecuteNonQuery() > 0;
		}

		public bool DeleteProductCheck(string Prod_Code, string Check_Type)
		{
			SqlCommand sql = new SqlCommand()
			{
				Connection = conn,
				CommandText = @"Delete from ProductCheck 
								where Prod_Code = @Prod_Code and Check_Type = @Check_Type"
				//(Prod_Code, Check_Type
			};
			sql.Parameters.AddWithValue("@Prod_Code", Prod_Code);
			sql.Parameters.AddWithValue("@Check_Type", Check_Type);

			return sql.ExecuteNonQuery() > 0;
		}



		public void Dispose()
        {
			conn.Close();
			Info.CloseRoller();

		}
    }
}
