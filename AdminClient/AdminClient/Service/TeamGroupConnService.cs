using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient.Service
{
    public class TeamGroupConnService
    {
        public List<TeamGroupConnVO> GetAllTeamGroupConnVO()
        {
            using (TeamGroupConnDAC DAC = new TeamGroupConnDAC())
            {
                return DAC.GetAllTeamGroupConnVO();
            }
        }

        public bool InsertTeamGroupConn(string Team_Code, int Grp_No)
        {
            using (TeamGroupConnDAC DAC = new TeamGroupConnDAC())
            {
                return DAC.InsertTeamGroupConn(Team_Code, Grp_No);
            }
        }

        public bool DeleteTeamGroupConn(string Team_Code, int Grp_No)
        {
            using (TeamGroupConnDAC DAC = new TeamGroupConnDAC())
            {
                return DAC.DeleteTeamGroupConn(Team_Code, Grp_No);
            }
        }

        public bool DeleteFromTeamConn(string Team_Code)
        {
            using (TeamGroupConnDAC DAC = new TeamGroupConnDAC())
            {
                return DAC.DeleteFromTeamConn(Team_Code);
            }
        }
    }
}
