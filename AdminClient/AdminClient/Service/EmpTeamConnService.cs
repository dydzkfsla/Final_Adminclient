using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminClientDAC;
using AdminClientVO;

namespace AdminClient.Service
{
    public class EmpTeamConnService
    {
        public List<EmpTeamConnVO> GetAllEmpTeamConnVO()
        {
            using (EmpTeamConnDAC dac = new EmpTeamConnDAC())
            {
                return dac.GetAllEmpTeamConnVO();
            }
        }

        public List<EmpTeamConnVO> GetEmpTeamConnVO(string Emp_Code)
        {
            using (EmpTeamConnDAC dac = new EmpTeamConnDAC())
            {
                return dac.GetEmpTeamConnVO(Emp_Code);
            }
        }

        public bool InsetEmpTeamConn(string Emp_Code, string Team_Code)
        {
            using (EmpTeamConnDAC dac = new EmpTeamConnDAC())
            {
                return dac.InsetEmpTeamConn(Emp_Code, Team_Code);
            }
        }

        public bool DeleteEmpTeamConn(string Emp_Code, string Team_Code)
        {
            using (EmpTeamConnDAC dac = new EmpTeamConnDAC())
            {
                return dac.DeleteEmpTeamConn(Emp_Code, Team_Code);
            }
        }

        public bool DeleteEmpTeamConn(string Team_Code)
        {
            using (EmpTeamConnDAC dac = new EmpTeamConnDAC())
            {
                return dac.DeleteEmpTeamConn(Team_Code);
            }
        }
    }
}
