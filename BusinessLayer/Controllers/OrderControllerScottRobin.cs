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
        private readonly KundController customerController = new KundController();

        public int CreateOrder(string comment,Customer customer, string skapare)

        {
            var order = new Order()
            {             
                Comment = comment, Customer = customer, StartDate = DateTime.Now,
                DateFinished = DateTime.Now.AddDays(21), OrderStatus = 0, TotalPrice = 0,
                SkapareAvOrder = skapare
            };
            repository.SaveOrder(order);
            customerController.UpdateCustomerPoints(customer.Id);
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

        public Order getOrderOnId(int Id)
        {
            return repository.GetOrderOnId(Id);
        }

        public void EditOrderStatus(Order order, OrderStatus orderStatus)
        {
            order.OrderStatus = orderStatus;
            repository.EditOrder(order);
        }

        public double GetDiscount(int customerPoints)
        {
            switch (customerPoints)
            {
                case 0:
                    return 1;
                case 1:
                    return 0.95;
                case 2:
                    return 0.9;
                case 3: return 0.85;
                case 4: return 0.8;
                case 5: return 0.75;
                default: return 1;
            }
        }

        public void ApplyDiscount(Order order, double newPrice)
        {
            repository.ApplyDiscount(order, newPrice);
        }


    }
}
