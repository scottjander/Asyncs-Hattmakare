using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Models;

namespace BusinessLayer.Controllers
{
    public class OrderControllerScottRobin
    {
        private readonly OrderRepository repository = new OrderRepository();
        public int CreateOrder(string comment, Customer customer)
        {
            var order = new Order()
            {
                Comment = comment, Customer = customer, StartDate = DateTime.Now,
                DateFinished = DateTime.Now.AddDays(21), OrderStatus = 0, TotalPrice = 0
            };
            repository.SaveOrder(order);
            return repository.GetLatestOrderId();
        }
        public List<Customer> GetAllCustomers()
        {
            return repository.getallcustomers();
        }

        public Order getOrderOnId(int Id)
        {
            return repository.GetOrderOnId(Id);
        }


    }
}
