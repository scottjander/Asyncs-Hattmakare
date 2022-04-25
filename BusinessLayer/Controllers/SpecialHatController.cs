using DataLayer.Models;
using DataLayer.Models.Enums;
using DataLayer.Repositories;
using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer.Controllers
{
    public class SpecialHatController
    {
        private HatRepository HatRepository;
        private SpecialHatRepository SpecialHatRepository;
        private FabricRepository FabricRepository;
        public SpecialHatController()
        {
            SpecialHatRepository = new SpecialHatRepository();
            FabricRepository = new FabricRepository();
            HatRepository = new HatRepository(SpecialHatRepository.GetContext());
        }

        public void AddSpecialHat(string name, Fabric fabric,double fabricLength ,int decoration, int size, string comment, int orderId, string filePath , string fileName)
        {

            if (fabric == null)
            {
                MessageBox.Show("Välj tyg");
                return;
            }


            if (fabric.AmountInStock < fabricLength)
                {
                    //gör validering
                    return;
                }
            


            FabricRepository.DecreaseAmountInStorage(fabricLength, fabric);
                var price = CalculatePrice(fabric, fabricLength, decoration);
                var imagePath = SpecialHatRepository.SaveHatPicture(filePath, fileName);
                var newHat = new SpecialHat()
                {
                    Name = name,
                    Price = price,
                    Comment = comment,
                    AmountOfDecorations = decoration,
                    ImagePath = imagePath,

                };
                newHat.Order = SpecialHatRepository.GetOrderOnId(orderId);
                SpecialHatRepository.addSpecialHat(newHat, orderId);
            


        }

        private double CalculatePrice(Fabric fabric, double fabricLength, int decoration)
        {
            var price = (double)Price.BasePrice;
            price += fabric.Price * fabricLength;
            price += decoration * (double)Price.DecorationPrice;
            return price;
        }

        public List<Fabric> GetAllFabrics()
        {
            return FabricRepository.GetAllFabric();
        }

        public Fabric GetFabricOnId(int id)
        {
            return FabricRepository.GetFabricOnId(id);
        }
        public List<SpecialHat> GetSpecialHatsOnOrderId(int id)
        {
            return SpecialHatRepository.GetHatsOnOrderId(id);
        }

        public List<Hat> GetHatsOnOrderId(int id)
        {
            return HatRepository.GetHatsOnOrderId(id);
        }

    }
}
