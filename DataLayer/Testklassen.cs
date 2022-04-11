using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer
{
    public class Testklassen
    {
        /*    public void testmetoden()
            {
                using (var context = new hatdbcontext())
                {
                    var customer = new customer()
                    {
                        customerbonuspoints = 0,
                        email = "meh",
                        firstname = "ferik",
                        lastname = "fawerman",
                         phone = 07623424
                    };
                    var enhatt = new hat() { comment = "gjorde två hatt", price = "100" };
                    var tvahatt = new specialhat() { comment = "gjorde specialhatt", price = "570", amountofdecorations = 2 };
                    var hattlista = new list<hat>();
                    hattlista.add(enhatt);
                    hattlista.add(tvahatt);
                    datetime tiden = datetime.now;
                    var minorder = new order()
                        { comment = "joe", customer = customer, hats = hattlista, totalprice = hattlista.sum(x => x.price), startdate = tiden, datefinished = tiden };
                    context.customers.add(customer);
                    context.hats.add(enhatt);
                    context.hats.add(tvahatt);
                    context.orders.add(minorder);
                    context.savechanges();

                }
            }*/
        public void testmetoden3()
        {
            using (var context = new HatDbContext())
            {
                //var stock = new stock();
                //context.stock.add(stock);
                //var customer = new customer()
                //{
                //    customerbonuspoints = 0,
                //    email = "meh",
                //    firstname = "ferik",
                //    lastname = "fawerman",
                //    // phone = 07623424
                //};
                ////var enhatt = new hat() {stock = stock};
                //// var tvahatt = new specialhat() { comment = "gjorde specialhatt", price = "570", amountofdecorations = 2 };
                //var hattlista = new list<hat>();
                //hattlista.add(enhatt);
                //// hattlista.add(tvahatt);
                //datetime tiden = datetime.now;
                DateTime tiden = DateTime.Now;
                List<Hat> list = new List<Hat>();
                var minorder = new Order()
                {
                    StartDate = tiden,
                    DateFinished = tiden,
                    Hats = list
                };

                //context.customers.add(customer);
                //context.hats.add(enhatt);
                // context.hats.add(tvahatt);
                context.Orders.Add(minorder);
                context.SaveChanges();

            }
        }

        public void dummydata()
        {

            var address = new Address()
            { StreetName = "Köpmangatan", StreetNumber = "13", PostalCode = "70210", TownName = "Örebro" };
            var customer = new Customer()
            {
                CustomerBonusPoints = 0,
                Email = "bobin@aziz.com",
                FirstName = "Robin",
                LastName = "Aziz",
                Phone = 07623424,
                Address = address
            };
            using (var context = new HatDbContext())
            {
                context.Addresses.Add(address);
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }


    }
}
