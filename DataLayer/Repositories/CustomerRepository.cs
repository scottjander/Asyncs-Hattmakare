using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class CustomerRepository
    {
        public readonly HatDbContext _context;
        public CustomerRepository()
        {
            _context = new HatDbContext();
        }

        public void UpdateCustomerBonusPoints(int customerId, int bonusPoints)
        {
            var customer = _context.Customers.FirstOrDefault(cust => cust.Id == customerId);
            customer.CustomerBonusPoints = bonusPoints;
            _context.SaveChanges();
        }

        public int GetAmountOfOrdersThisYear(int customerId)
        {
            int currentYear = DateTime.Now.Year;
            var orders = from order in _context.Orders where order.Customer.Id == customerId select order;
            var ordersThisYear = from order in orders where order.StartDate.Year == currentYear select order;
            int orderCount = ordersThisYear.Count();
            return orderCount;
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        public Customer GetCustomerOnID(int id)
        {
            return _context.Customers.FirstOrDefault(x => x.Id == id);
        }
    }
}
