using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientDAC
{
	public class FacilityDAC : IDisposable
	{
		SqlConnection conn;

		public FacilityDAC()
		{
			conn = new SqlConnection(Connstring.conn);
			conn.Open();
		}

		//public List<>

		public void Dispose()
		{
			conn.Dispose();
		}
	}
}
