using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Repositories;

namespace BusinessLayer.Controllers
{
    public class KundController
    {
        public KundRepository KundRepository
        {
            get { return new KundRepository(); }
        }
    
        public int HamtaIndex(int id)
        {
            int index = KundRepository.HamtaIndex(id);
            return index;
        }





    }
}
