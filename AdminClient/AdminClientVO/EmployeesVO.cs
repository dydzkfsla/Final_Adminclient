using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
    public class EmployeesVO
    {
        public string Emp_Code { get; set; }
        public string Emp_Name { get; set; }
        public DateTime Emp_HireDate { get; set; }
        public DateTime Emp_RetireDate { get; set; }
        public string Emp_Phone { get; set; }
        public string Emp_Email { get; set; }
        public int Emp_PostCode { get; set; }
        public string Emp_Addr { get; set; }
        public string Emp_AddrDetail { get; set; }
        public string Emp_Pwd { get; set; }
    }
}
