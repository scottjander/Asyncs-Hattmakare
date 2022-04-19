using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer.Repositories
{
    public class HatRepository
    {
        private readonly HatDbContext _context ;

        public HatRepository()
        {
            _context = new HatDbContext();
        }

        public void AddHatsToStock(int amountToAdd, string itemName, double price, string comment, int size, string color )
        {
            for (var i = 0; i <= amountToAdd; i++)
            {
                var hat = new Hat()
                {
                    itemName = itemName,
                    Price = price,
                    Comment = comment,
                    size = size,
                    color = color,
                };
                _context.Hats.Add(hat);
            }

            _context.SaveChanges();
        }

        public List<Hat> GetAllHats()
        {
            return _context.Hats.ToList();
        }

        public List<Hat> GetAllAvailableHats()
        {
            var query = from Hat in _context.Hats where Hat.order == null select Hat;
            return query.ToList();

        }
        public Hat GetHatOnID(int ID)
        {
            return _context.Hats.FirstOrDefault(hat => hat.Id == ID);
        }

        public void DeleteHatsFromStock(int amountToDelete, string itemName, double price, string comment, int size, string color)
        {
            var query = from Hat in _context.Hats
                where Hat.itemName == itemName select Hat;
            var list = query.ToList();
            foreach (var item in list)
            {
                if (item.size != size || item.color != color || item.Price != price)
                {
                    list.Remove(item);
                }
            }
            var currentInStock = list.Count();
            if (currentInStock < amountToDelete)
            {
                Console.WriteLine("För lite i lagret");
                return;
            }

            for (var i = 0; i < amountToDelete; i++)
            {
                var hat = list[i];
                _context.Hats.Remove(hat);
            }


            _context.SaveChanges();
        }
        public void AddHatToOrder(int orderId,int hatID)
        {
            var order = getOrder(orderId);
            var hat = GetHatOnID(hatID);
            hat.order = order;
            order.TotalPrice += hat.Price;
            _context.SaveChanges();
        }
        public Order getOrder(int id)
        {
            return _context.Orders.FirstOrDefault(o => o.Id == id); //går att förbättra
        }
    }
}
