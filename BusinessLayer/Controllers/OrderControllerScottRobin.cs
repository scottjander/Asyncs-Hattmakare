using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Models;
using DataLayer.Repositories;

namespace BusinessLayer.Controllers
{
    public class OrderControllerScottRobin
    {
        private readonly OrderRepository repository = new OrderRepository();
        public HatDbContext _context { get; set; }
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

        //public List<Order> Get()
        // {
        //    var returnList = new List<Order>();
        //    var forbiddenListSize = new List<int>();
        //    var forbiddenListColor = new List<string>();
        //    foreach (var order in OrderRepository.GetAllOrders())
        //    {
        //        if (forbiddenListSize.Contains(hat.size) && forbiddenListColor.Contains(hat.color))
        //        {
        //            continue;
        //        }
        //        returnList.Add(order);
        //        forbiddenListSize.Add(order.TotalPrice);
        //    }
        //    return returnList;

        //}

        public List<Order> GetCreatedOrders()
        {
            var returnCreatedOrders = new List<Order>();
            foreach (var o in repository.GetAllCreatedOrders())
            {
                returnCreatedOrders.Add(o);
            }
            return returnCreatedOrders;
        }

        public List<Order> GetStartedOrders()
        {
            var returnCreatedOrders = new List<Order>();
            foreach (var o in repository.GetAllStartedOrders())
            {
                returnCreatedOrders.Add(o);
            }
            return returnCreatedOrders;
        }

        public List<Order> GetFinishedOrders()
        {
            var returnCreatedOrders = new List<Order>();
            foreach (var o in repository.GetAllFinishedOrders())
            {
                returnCreatedOrders.Add(o);
            }
            return returnCreatedOrders;
        }



    }
}
