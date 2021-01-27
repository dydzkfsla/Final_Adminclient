using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient.Service
{
    public class GroupInfoService
    {
        public List<GroupInfoVO> AllGroupInfoVO()
        {
            using (GroupInfoDAC DAC = new GroupInfoDAC()) 
            {
                 return DAC.AllGroupInfoVO();
            };
        }

        public bool InserGroupInfo(int GroupNo, string GroupName)
        {
            using (GroupInfoDAC DAC = new GroupInfoDAC())
            {
                return DAC.InserGroupInfo(GroupNo, GroupName);
            };
        }

        public bool DeleteGroupInfo(int GropNo)
        {
            using (GroupInfoDAC DAC = new GroupInfoDAC())
            {
                return DAC.DeleteGroupInfo(GropNo);
            };
        }

        public bool UpdateGroupInfo(int GropNo, string GropName)
        {
            using (GroupInfoDAC DAC = new GroupInfoDAC())
            {
                return DAC.UpdateGroupInfo(GropNo, GropName);
            };
        }


    }
}
