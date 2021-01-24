using AdminClientVO;
using AdminClientDAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient.Service
{
    public class FormInfoService
    {
        public List<FormInfoVO> GetAllList()
        {
            using (FormInfoDAC DAC = new FormInfoDAC())
                return DAC.GetAllList();
        }

    }
}
