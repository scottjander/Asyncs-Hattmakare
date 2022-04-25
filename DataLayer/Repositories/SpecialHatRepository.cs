using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class SpecialHatRepository
    {
        private readonly HatDbContext _context;
        public SpecialHatRepository()
        {
            _context = new HatDbContext();
        }

        public void addSpecialHat(SpecialHat hat, int orderId)
        {
            var order = GetOrderOnId(orderId);
            _context.SpecialHats.Add(hat);
            order.TotalPrice += hat.Price;
            _context.SaveChanges();
        }

        public Order GetOrderOnId(int id)
        {
           return _context.Orders.FirstOrDefault(o => o.Id == id); //går att förbättra
        }

        public string SaveHatPicture(string filePath, string fileName)
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            string folderPath = currentDirectory.Substring(0, currentDirectory.Length - 26) + "DataLayer\\Images";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            File.Copy(filePath, Path.Combine(folderPath, Path.GetFileName(filePath)),
                true);
            return folderPath + "\\" + fileName;
        }
        public List<SpecialHat> GetHatsOnOrderId(int id)
        {
            var listOfHats = from hat in _context.SpecialHats where hat.Order.Id == id select hat;
            return listOfHats.ToList();
        }

        public HatDbContext GetContext()
        {
            return _context;
        }
    }

}
