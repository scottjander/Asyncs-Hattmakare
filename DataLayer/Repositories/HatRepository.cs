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

        public List<Hat> GetAllAvalibleHats()
        {
            var query = from Hat in _context.Hats where Hat.Comment == null select Hat;
            return query.ToList();

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
    }
}
