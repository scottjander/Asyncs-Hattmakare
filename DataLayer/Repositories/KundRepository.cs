using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
     public class KundRepository
    {
     public int HamtaIndex (int id)
        {
            using (var context = new HatDbContext())
            {
                var customer = context.Customers.Find(id);
                var adress = customer.Address;
                var index =  customer.Address.Id;
                return index;
            }


        }
    }
}
