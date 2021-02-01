using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient.Service
{
    public class ViewService
    {
        public List<View_EmpFormVO> View_EmpForm(string Emp_Code)
        {
            using (ViewDAC DAC = new ViewDAC())
            {
                return DAC.View_EmpForm(Emp_Code);
            }
        }

        public List<View_FavoritesVO> View_Favorites(string Emp_Code)
        {
            using (ViewDAC DAC = new ViewDAC())
            {
                return DAC.View_Favorites(Emp_Code);
            }
        }
    }
}
