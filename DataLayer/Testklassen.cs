using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer
{
    public class Testklassen
    {
        public void TestMetoden()
        {
            using (var context = new HatDbContext())
            {
                var customer = new Customer()
                {
                    CustomerBonusPoints = 0,
                    Email = "meh",
                    FirstName = "Ferik",
                    LastName = "Fawerman",
                    // Phone = 07623424
                };
                var enHatt = new Hat() { Comment = "Gjorde två hatt", Price = 100 };
                var tvaHatt = new SpecialHat() { Comment = "Gjorde specialhatt", Price = 570, AmountOfDecorations = 2 };
                var hattLista = new List<Hat>();
                hattLista.Add(enHatt);
                hattLista.Add(tvaHatt);
                DateTime tiden = DateTime.Now;
                var minOrder = new Order()
                    { Comment = "Joe", Customer = customer, Hats = hattLista, TotalPrice = hattLista.Sum(x => x.Price), StartDate = tiden, DateFinished = tiden };
                context.Customers.Add(customer);
                context.Hats.Add(enHatt);
                context.Hats.Add(tvaHatt);
                context.Orders.Add(minOrder);
                context.SaveChanges();

            }
        }
    }
}
