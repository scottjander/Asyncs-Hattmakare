using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AnvandareController
    {
        public AnvandareRepository AnvandareRepository
        {
            get { return new AnvandareRepository(); }
        }

        public List<string> getAllEmployeeNames()
        {
            List<string> namn = AnvandareRepository.GetAllNames();
            return namn;


        }

        public void LaggTillAnstalld(string namn)
        {
            AnvandareRepository.SkapaNyAnvandare(namn);
        }


    }
}
