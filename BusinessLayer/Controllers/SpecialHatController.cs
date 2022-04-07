using DataLayer.Models;
using DataLayer.Models.Enums;
using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Controllers
{
    public class SpecialHatController
    {
        private SpecialHatRepository SpecialHatRepository;
        private StockRepository StockRepository;
        public SpecialHatController()
        {
            SpecialHatRepository = new SpecialHatRepository();

            StockRepository = new StockRepository();
        }

        public void AddSpecialHat(string name, FabricStock fabric,double fabricLength ,int decoration, int size, string comment, int orderId, string fileName)
        {
            var price = CalculatePrice(fabric, fabricLength, decoration);
            var imagePath= SaveHatPicture(fileName);
            var newHat = new SpecialHat()
            {
                Name = name,
                Price = price,
                Comment = comment,
                AmountOfDecorations = decoration,
                ImagePath = imagePath
            };
            
            SpecialHatRepository.addSpecialHat(newHat, orderId);
        }

        private double CalculatePrice(FabricStock fabric, double fabricLength, int decoration)
        {
            var price = (double)Price.BasePrice;

            price += fabric.Price * fabricLength;
            price += decoration * (double)Price.DecorationPrice;

            return price;
        }

        public List<FabricStock> GetFabric()
        {
            var fabricList = StockRepository.GetAllFabric();



            return fabricList;
        }

        public string SaveHatPicture(string filename)
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            string folderPath = currentDirectory.Substring(0, currentDirectory.Length - 26) + "DataLayer\\Images";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            File.Copy(filename, Path.Combine(folderPath, Path.GetFileName(filename)),
                true);
            return folderPath + "\\" + filename;
        }

    }
}
