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
        private HatDbContext hatDbContext = new HatDbContext();
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
                //DateTime tiden = DateTime.Now;
                //List<Hat> list = new List<Hat>();
                //var minorder = new Order()
                //{
                //    StartDate = tiden,
                //    DateFinished = tiden,
                //    Hats = list
                //};
                //var enHatt = new Hat() { Comment = "Gjorde två hatt", Price = 100 };
                //var tvaHatt = new SpecialHat() { Comment = "Gjorde specialhatt", Price = 570, AmountOfDecorations = 2 };
                //var hattLista = new List<Hat>();
                //var hattLista2 = new List<SpecialHat>();
                //hattLista.Add(enHatt);
                //hattLista2.Add(tvaHatt);
                //DateTime tiden = DateTime.Now;
                //var minOrder = new Order()
                //{
                //    Comment = "Joe",
                //    Customer = customer,
                //    Hats = hattLista,
                //    TotalPrice = hattLista.Sum(x => x.Price),
                //    StartDate = tiden,
                //    DateFinished = tiden
                //};
                //context.Customers.Add(customer);
                //context.Hats.Add(enHatt);
                //context.SpecialHats.Add(tvaHatt);
                //context.Orders.Add(minOrder);

                var silke = new Fabric()
                {
                    ItemName = "Silke",
                    Price = 200,
                    AmountInStock = 30,
                    Colour = "Black"
                };

                var filt = new Fabric()
                {
                    ItemName = "Filt",
                    Price = 100,
                    AmountInStock = 40,
                    Colour = "Blue"
                };

                var polyester = new Fabric()
                {
                    ItemName = "Polyester",
                    Price = 300,
                    AmountInStock = 50,
                    Colour = "Red"
                };

                context.Fabrics.Add(filt);
                context.Fabrics.Add(polyester);
                context.Fabrics.Add(silke);


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
                Phone = "07623424",
                Address = address
            };
            var order = new Order()
            {
                StartDate = DateTime.Now,
                DateFinished = DateTime.Now,
                Comment = "Test",
                TotalPrice = 799,
                Customer = customer
            };
            using (var context = new HatDbContext())
            {
                context.Addresses.Add(address);
                context.Customers.Add(customer);
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }

        public void FillHat()
        {
            var hat1 = new Hat()
            {
                Price = 150,
                size = 52,
                color = "Svart",
                itemName = "Doktorshatt"
            };
            var hat2 = new Hat()
            {
                Price = 150,
                size = 54,
                color = "Blå",
                itemName = "Doktorshatt"
            };
            var hat3 = new Hat()
            {
                Price = 150,
                size = 56,
                color = "Grön",
                itemName = "Doktorshatt"
            };
            var hat4 = new Hat()
            {
                Price = 150,
                size = 52,
                color = "Lila",
                itemName = "Doktorshatt"
            };
            var hat5 = new Hat()
            {
                Price = 150,
                size = 62,
                color = "Gul",
                itemName = "Doktorshatt"
            };
            var fabric1 = new Fabric()
            {
                ItemName = "Silke",
                Colour = "Svart",
                AmountInStock = 30,
                Price = 100
            };
            var fabric2 = new Fabric()
            {
                ItemName = "Sten",
                Colour = "Grå",
                AmountInStock = 20,
                Price = 500
            };
            var fabric3 = new Fabric()
            {
                ItemName = "Trä",
                Colour = "Vit",
                AmountInStock = 15,
                Price = 340
            };
            hatDbContext.Hats.Add(hat1);
            hatDbContext.Hats.Add(hat2);
            hatDbContext.Hats.Add(hat3);
            hatDbContext.Hats.Add(hat4);
            hatDbContext.Hats.Add(hat5);
            hatDbContext.Fabrics.Add(fabric1);
            hatDbContext.Fabrics.Add(fabric2);
            hatDbContext.Fabrics.Add(fabric3);
            hatDbContext.SaveChanges();
        }

        public void FillInvoices()
        {
            DateTime date1 = new DateTime(2021, 1, 1);
            DateTime date2 = new DateTime(2021, 2, 1);
            DateTime date3 = new DateTime(2022, 3, 1);
            DateTime date4 = new DateTime(2022, 4, 1);
            DateTime date5 = new DateTime(2022, 5, 1);
            var outInvoice1 = new Invoice()
            {
                SumToPay = 199.99,
                DateCreated = date1
            };
            var outInvoice2 = new Invoice()
            {
                SumToPay = 210.00,
                DateCreated = date2
            };
            var outInvoice3 = new Invoice()
            {
                SumToPay = 19.99,
                DateCreated = date3
            };
            var outInvoice4 = new Invoice()
            {
                SumToPay = 9.99,
                DateCreated = date4
            };
            var outInvoice5 = new Invoice()
            {
                SumToPay = 99.99,
                DateCreated = date5
            };
            var inInvoice1 = new InvoiceFromSupplier()
            {
                SumToPay = 199.99,
                DateCreated = date1
            };
            var inInvoice2 = new InvoiceFromSupplier()
            {
                SumToPay = 210.00,
                DateCreated = date2
            };
            var inInvoice3 = new InvoiceFromSupplier()
            {
                SumToPay = 19.99,
                DateCreated = date3
            };
            var inInvoice4 = new InvoiceFromSupplier()
            {
                SumToPay = 9.99,
                DateCreated = date4
            };
            var inInvoice5 = new InvoiceFromSupplier()
            {
                SumToPay = 99.99,
                DateCreated = date5
            };
            hatDbContext.Invoices.Add(outInvoice1);
            hatDbContext.Invoices.Add(outInvoice2);
            hatDbContext.Invoices.Add(outInvoice3);
            hatDbContext.Invoices.Add(outInvoice4);
            hatDbContext.Invoices.Add(outInvoice5);
            hatDbContext.InvoiceFromSuppliers.Add(inInvoice1);
            hatDbContext.InvoiceFromSuppliers.Add(inInvoice2);
            hatDbContext.InvoiceFromSuppliers.Add(inInvoice3);
            hatDbContext.InvoiceFromSuppliers.Add(inInvoice4);
            hatDbContext.InvoiceFromSuppliers.Add(inInvoice5);
            hatDbContext.SaveChanges();
        }
    }
}
