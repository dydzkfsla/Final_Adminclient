using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient.Service
{
    public class EmployeesService
    {
        public List<EmployeesTeamVO> SerchSelectEmployees(int LimitCount, string Team_Code
                                                            , string HireDateFrom, string HireDateTo
                                                            , string RetireDateFrom, string RetireDateTo)
        {
            using (EmployeesDAC DAC = new EmployeesDAC())
            {
                return DAC.SerchSelectEmployees(LimitCount, Team_Code, HireDateFrom, HireDateTo, RetireDateFrom, RetireDateTo);      
            }
        }

    }
}
