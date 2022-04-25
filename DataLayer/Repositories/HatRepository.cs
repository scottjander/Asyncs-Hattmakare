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
        public HatRepository(HatDbContext context)
        {
            _context = context;
        }

        public void AddHatsToStock(int amountToAdd, string itemName, double price, string comment, int size, string color )
        {
            for (var i = 0; i < amountToAdd; i++)
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

        public List<string> GetAllAvailableColors()
        {
            var query = from Hat in _context.Hats select Hat.color;
            return query.ToList();
        }

        public List<int> GetAllAvailableSizes()
        {
            var query = from Hat in _context.Hats select Hat.size;
            return query.ToList();
        }

        public Hat GetHatOnID(int ID)
        {
            return _context.Hats.FirstOrDefault(hat => hat.Id == ID);
        }

        public void DeleteHatsFromStock(int amountToDelete, int size, string color)
        {
            var list = _context.Hats.ToList();
            var removelist = new List<Hat>();
            foreach (var hat in list)
            {
                removelist.Add(hat);
            }
            foreach (var item in list)
            {
                if (item.size != size || item.color != color)
                {
                    removelist.Remove(item);
                }
            }
            var currentInStock = removelist.Count();
            if (currentInStock < amountToDelete)
            {
                Console.WriteLine("För lite i lagret");
                return;
            }

            for (var i = 0; i < amountToDelete; i++)
            {
                var hat = removelist[i];
                _context.Hats.Remove(hat);
            }


            _context.SaveChanges();
        }

        public void ChangeHatPriceInStock(double newPrice)
        {
            var list = _context.Hats.ToList();
            foreach (var item in list)
            {
                    item.Price = newPrice;
            };
            
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
        public List<Hat> GetHatsOnOrderId(int id)
        {
            var listOfHats = from hat in _context.Hats where hat.order.Id == id select hat;
            return listOfHats.ToList();
        }
    }
}
