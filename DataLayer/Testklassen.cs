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
    }
}
