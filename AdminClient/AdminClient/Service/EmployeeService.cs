using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminClientDAC;
using AdminClientVO;

namespace AdminClient.Service
{
	public class EmployeeService : IDisposable
	{
		EmployeeDAC dac;
		public EmployeeService()
		{
			dac = new EmployeeDAC();
		}

		public EmployeesVO EmpLogin(string id, string pwd)
		{
			return dac.EmpLogin(id, pwd);
		}

		public void Dispose()
		{
			dac.Dispose();
		}
	}
}
