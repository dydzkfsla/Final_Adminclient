using AdminClientVO;
using log4net.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientDAC
{
	public class ComboBindingDAC : IDisposable
	{
		SqlConnection conn;
		LoggingUtility Info;
		public ComboBindingDAC()
		{
			conn = new SqlConnection(Connstring.conn);
			conn.Open();
			Info = new LoggingUtility("ComboBindingDACInFo", "ComboBindingDACError", Level.All, 30);
			Info.InfoFolder = "C:\\FP\\Log\\ComboBindingDAC\\Info";
			Info.ErrorFolder = "C:\\FP\\Log\\ComboBindingDAC\\Error";
		}
		public void Dispose()
		{
			conn.Close();
		}

		/// <summary>
		/// 콤보박스 바인딩을 위한 회사 코드와 이름 불러오기
		/// </summary>
		/// <returns> 회사코드, 이름 목록 List </returns>
		public List<ComboCompNameVO> BindingCompName()
		{
			try
			{
				using(SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = @"select Comp_Code, Comp_Name from CompanyInfo";

					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						return Helper.DataReaderMapToList<ComboCompNameVO>(reader);
					}
				}

			}
			catch (Exception err)
			{
				Info.WriteError($"실행자:{Global.employees.Emp_Name} 콤보박스 바인딩(CompName) 목록 불러오기 오류 :" + err.Message, err);
				return null;
			}
		}

		/// <summary>
		/// 콤보박스 바인딩을 위한 물품코드와 물품명 불러오기
		/// </summary>
		/// <returns>물품코드, 물품명 목록 List </returns>
		public List<ComboProdNameVO> BindingProdName()
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = @"select Prod_Code, Prod_Name from Product";

					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						return Helper.DataReaderMapToList<ComboProdNameVO>(reader);
					}
				}
				

			}
			catch (Exception err)
			{
				Info.WriteError($"실행자:{Global.employees.Emp_Name} 콤보박스 바인딩(CompName) 목록 불러오기 오류 :" + err.Message, err);
				return null;
			}
		}

	}
}
