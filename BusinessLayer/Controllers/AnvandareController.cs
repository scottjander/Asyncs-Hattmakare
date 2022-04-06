using DataLayer;
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




    }
}
