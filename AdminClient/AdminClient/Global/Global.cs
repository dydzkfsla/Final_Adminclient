using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient.Global
{
    public static class Global
    {
        private static EmployeesVO employees1 = new EmployeesVO { Emp_Code = "Emp0001", Emp_Name = "sa", Emp_Email = "sa", Emp_Addbutton = true, Emp_Updatebutton = true, Emp_Deletebutton = true };

        public static EmployeesVO employees { get => employees1; 
            set
            {
                employees1 = value;
                AdminClientDAC.Global.employees = value;
            }
        }

        public static List<View_EmpFormVO> Emp_Form { get; set; }
    }
}
