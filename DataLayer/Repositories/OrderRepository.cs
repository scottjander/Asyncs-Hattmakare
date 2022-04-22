using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer
{
    public class OrderRepository
    {
        public readonly HatDbContext _context = new HatDbContext();

        public OrderRepository(HatDbContext context)
        {
            _context = context;
        }

        public OrderRepository()
        {
            _context = new HatDbContext();
        }

        public Order GetOrderOnId(int id)
        {
            return _context.Orders.FirstOrDefault(o => o.Id == id); //går att förbättra
        }

        public void SaveOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public List<Customer> getallcustomers()
        {
           return _context.Customers.ToList();
        }

        public int GetLatestOrderId()
        {
            return _context.Orders.ToList().Max(o => o.Id);
        }

        public HatDbContext GetContext()
        {
            return _context;
        }

        public List<Order> GetAllCreatedOrders()
        {
             var query = from Orders in _context.Orders where Orders.OrderStatus == OrderStatus.Created select Orders;
             return query.ToList();
        }

        public List<Order> GetAllStartedOrders()
        {
             var query = from Orders in _context.Orders where Orders.OrderStatus == OrderStatus.Started select Orders;
             return query.ToList();
        }

        public List<Order> GetAllFinishedOrders()
        {
            var query = from Orders in _context.Orders where Orders.OrderStatus == OrderStatus.Finished select Orders;
            return query.ToList();
        }
        public void EditOrder(Order order)
        {
            _context.Orders.AddOrUpdate(order);
            _context.SaveChanges();
        }

        public void ApplyDiscount(Order order, double newPrice)
        {
            order.TotalPrice = newPrice;
            _context.SaveChanges();

        }


    }
}
