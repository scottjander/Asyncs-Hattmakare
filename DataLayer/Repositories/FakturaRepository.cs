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
        public readonly HatDbContext context;
        public FakturaRepository()
        {
            context = new HatDbContext();
        }
        public int HamtaKundIdPaOrderId(int id)
        {

            
                var order = context.Orders.Find(id);
                var customern = order.Customer;
                var index = order.Customer.Id;
                return index;
            
        }
        public string HamtaAdressPaKundID(int id)
        {


            var order = context.Orders.Find(id);
            var customer = order.Customer;
            var gatunr = customer.Address.StreetNumber;
                var zip = customer.Address.PostalCode;
                var stad = customer.Address.TownName;
                var adress = customer.Address.StreetName;
                return adress + " " + gatunr + ", " + zip + ", " + stad;
            
        }

        public string HamtaForNamn (int id)
        {
            var order = context.Orders.Find(id);
            var customer = order.Customer;
            var namn = customer.FirstName;
            return namn;
       


        }
        public string HamtaEfterNamn(int id)
        {
            var order = context.Orders.Find(id);
            var customer = order.Customer;
                var namn = customer.LastName;
                return namn;
            
        }

        public double HamtaTotalSumma(int id)
        {
            
                var order = context.Orders.Find(id);
                var totalpris = order.TotalPrice;
                return totalpris;
            
        }

        public Address HamtaAdressObjekt (int KundId)
        {
            
                var customer = context.Customers.Find(KundId);           
                var adress = customer.Address;
                return adress;
            
        }
        public Order HamtaOrderObjekt(int OrderId)
        {

                var Order = context.Orders.Find(OrderId);
                return Order;
            
        }

        public void SkapaFaktura(Address adress, Order order, double summa, bool betald)
        {
           
                var nyfaktura = new Invoice() { SumToPay = summa, IsPaid = betald, DateCreated = DateTime.Now, InvoiceAddress = adress, Order = order };
                context.Invoices.Add(nyfaktura);
                context.SaveChanges();
            
        }




    }
}
