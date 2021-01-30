using AdminClientDAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient.Service
{
    public class FavoritesService
    {
        public bool InserFavorites(string Emp_Code, string Form_Name)
        {
            using (FavoritesDAC DAC = new FavoritesDAC())
            {
                return DAC.InserFavorites(Emp_Code, Form_Name);
            }
        }

        public bool DeleteFavorites(string Emp_Code, string Form_Name)
        {
            using (FavoritesDAC DAC = new FavoritesDAC())
            {
                return DAC.DeleteFavorites(Emp_Code, Form_Name);
            }
        }
    }
}
