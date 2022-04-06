using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataLayer
{
    public class AnvandareRepository
    {

        public List<string> GetAllNames()
        {
           using (var context = new HatDbContext())
            {
               
            }
        }


    }
}
