using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient.Service
{
    public class GroupFormConnService
    {
        public List<GroupFormConnVO> GetAllGroupFormConnVO()
        {
            using (GroupFormConnDAC DAC = new GroupFormConnDAC())
            {
                return DAC.GetAllGroupFormConnVO();
            }
        }


        public bool InsertGroupFormConn(int GropNo, string FromName)
        {
            using (GroupFormConnDAC DAC = new GroupFormConnDAC())
            {
                return DAC.InsertGroupFormConn(GropNo, FromName);
            }
        }


        public bool DeleteGroupFormConn(int GropNo, string FromName)
        {
            using (GroupFormConnDAC DAC = new GroupFormConnDAC())
            {
                return DAC.DeleteGroupFormConn(GropNo, FromName);
            }
        }
    }
}
