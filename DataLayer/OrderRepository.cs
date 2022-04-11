using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer
{
    public class OrderRepository
    {
        public readonly HatDbContext _context = new HatDbContext();

        public void SaveOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public List<Customer> getallcustomers()
        {
           return _context.Customers.ToList();
        }
    }
}
