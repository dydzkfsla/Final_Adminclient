using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient.Service
{
    public class TeamInfoService
    {
        public List<TeamInfoVO> AllTeamInfoVO()
        {
            using (TeamInfoDAC DAC = new TeamInfoDAC())
            {
                return DAC.AllTeamInfoVO();
            };
        }

        public bool InserTeamInfo(string Team_Code, string Team_Name,string Team_Chief,string Team_Part)
        {
            using (TeamInfoDAC DAC = new TeamInfoDAC())
            {
                return DAC.InserTeamInfo(Team_Code, Team_Name, Team_Chief, Team_Part);
            };
        }

        public bool DeleteTeamInfo(string Team_Code)
        {
            using (TeamInfoDAC DAC = new TeamInfoDAC())
            {
                return DAC.DeleteTeamInfo(Team_Code);
            };
        }

        public bool UpdateTeamInfo(string Team_Code, string Team_Name, string Team_Chief, string Team_Part)
        {
            using (TeamInfoDAC DAC = new TeamInfoDAC())
            {
                return DAC.UpdateTeamInfo(Team_Code, Team_Name, Team_Chief, Team_Part);
            };
        }
    }
}
