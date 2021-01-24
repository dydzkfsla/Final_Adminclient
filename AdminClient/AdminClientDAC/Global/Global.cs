using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientDAC
{
    public static class Global
    {
        private static EmployeesVO employees1 = new EmployeesVO { Emp_Code = "aa", Emp_Name = "sa", Emp_Email = "sa" };

        public static EmployeesVO employees { get => employees1; set => employees1 = value; }

    }
}
