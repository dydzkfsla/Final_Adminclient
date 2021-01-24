using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
    public class CommonVO
    {
        public string Common_Code { get; set; }
        public string Common_Name { get; set; }
        public string Common_Category { get; set; }
        public string Common_Pcode { get; set; }
    }

    public class ComboCommonVO // 폼로드시 기본 바인딩될 목록
    {
        public string Common_Category { get; set; }
        public string Common_Name { get; set; }
    }
}
