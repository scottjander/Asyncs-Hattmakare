using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using DataLayer;
using DataLayer.Repositories;

namespace BusinessLayer
{
    public class StandardHatController
    {
        public HatDbContext HatDbContext = new HatDbContext();
        //public CustomerRepository CustomerRepository;
        public HatRepository HatRepository;

        public StandardHatController()
        {
          //  CustomerRepository = new CustomerRepository();
          HatRepository = new HatRepository();
        }

        public void AddHats(int amountToAdd, int size, string color)
        {
            HatRepository.AddHatsToStock(amountToAdd, "Doktorshatt", 19.99, null, size, color);
        }

        public void DeleteHats(int amountToDelete, int size, string color)
        {
            HatRepository.DeleteHatsFromStock(amountToDelete, size, color);

        }

        public void ChangeHatPrice(double newPrice)
        {
            HatRepository.ChangeHatPriceInStock(newPrice);
        }


        public void OrderStandardHat(int orderID, int hatID)
        {

            HatRepository.AddHatToOrder(orderID, hatID);
        }

        public List<Hat> GetUniqueHats()
        {
            var returnList = new List<Hat>();
            var forbiddenListSize = new List<int>();
            var forbiddenListColor = new List<string>();
            foreach (var hat in HatRepository.GetAllAvailableHats())
            {
                if (forbiddenListSize.Contains(hat.size) && forbiddenListColor.Contains(hat.color))
                {
                    continue;
                }
                returnList.Add(hat);
                forbiddenListSize.Add(hat.size);
                forbiddenListColor.Add(hat.color);
            }
            return returnList;

        }

        public int GetAmountOfHats(int size, string color)
        {
            int count=0;
            foreach (var hat in HatRepository.GetAllAvailableHats())
            {
                if (hat.size == size && hat.color==color)
                {
                    count++;
                }
            }
            return count;
        }

        public List<string> GetUniqueColors()
        {
            var returnList=new List<string>();
            foreach (var color in HatRepository.GetAllAvailableColors())
            {
                if (returnList.Contains(color)) continue;
                returnList.Add(color);
            }

            return returnList;
        }

        public List<int> GetUniqueSizes()
        {
            var returnList = new List<int>();
            foreach (var size in HatRepository.GetAllAvailableSizes())
            {
                if (returnList.Contains(size)) continue;
                returnList.Add(size);
            }

            return returnList;
        }

    }
}
