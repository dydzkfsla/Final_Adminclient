using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient.Service
{
    public class TeamForFormServer
    {
        public List<TeamForFormVO> GetAllTeamForForm()
        {
            using (TeamForFormDAC DAC = new TeamForFormDAC())
            {
                return DAC.GetAllTeamForForm();
            }
        }

        public bool UpdateTeamForForm(string TeamCode, string Form_Name, bool Chcked, string UpdateColum)
        {
            using (TeamForFormDAC DAC = new TeamForFormDAC())
            {
                return DAC.UpdateTeamForForm(TeamCode, Form_Name, Chcked, UpdateColum);
            }
        }
    }
}
