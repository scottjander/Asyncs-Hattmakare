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

        public void addSpecialHat(SpecialHat hat, int id)
        {
            _context.SpecialHats.Add(hat);
            _context.SaveChanges();
        }

        public Order getOrder(int id)
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

    }

}
