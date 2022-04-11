using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class FakturaRepository
    {

        public int HamtaKundIdPaOrderId(int id)
        {

            using (var context = new HatDbContext())
            {
                var order = context.Orders.Find(id);
                var customern = order.Customer;
                var index = order.Customer.Id;
                return index;
            }
        }
        public string HamtaAdressPaKundID(int id)
        {
            using (var context = new HatDbContext())
            {

                var customer = context.Customers.Find(id);
                var gatunr = customer.Address.StreetNumber;
                var zip = customer.Address.PostalCode;
                var stad = customer.Address.TownName;
                var adress = customer.Address.StreetName;
                return adress + " " + gatunr + ", " + zip + ", " + stad;
            }
        }

        public string HamtaForNamn (int id)
        {
            using (var context = new HatDbContext())
            {
                var customer = context.Customers.Find(id);
                var namn = customer.FirstName;
                return namn;

            }
        }
        public string HamtaEfterNamn(int id)
        {
            using (var context = new HatDbContext())
            {
                var customer = context.Customers.Find(id);
                var namn = customer.LastName;
                return namn;
            }
        }

        public int HamtaTotalSumma(int id)
        {
            using (var context = new HatDbContext())
            {
                var order = context.Orders.Find(id);
                var totalpris = order.TotalPrice;
                return totalpris;
            }
        }

        public Address HamtaAdressObjekt (int KundId)
        {
            using (var context = new HatDbContext())
            {
                var customer = context.Customers.Find(KundId);           
                var adress = customer.Address;
                return adress;
            }
        }
        public Order HamtaOrderObjekt(int OrderId)
        {
            using (var context = new HatDbContext())
            {
                var Order = context.Orders.Find(OrderId);
                return Order;
            }
        }






    }
}
