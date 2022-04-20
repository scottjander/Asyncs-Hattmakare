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

        public void addHats()
        {
            HatRepository.AddHatsToStock(10, "plommonHatt", 19.99, null, 25, "svart");
            HatRepository.AddHatsToStock(5, "HampusHatt", 12.99, "vad", 25, "gul");
            HatRepository.AddHatsToStock(9, "GilHatt", 15.99, "vad", 25, "lila");
        }

        public void deleteHats()
        {
            HatRepository.DeleteHatsFromStock(11, "plommonHatt", 19.99, "vad", 25, "svart");
            HatRepository.DeleteHatsFromStock(4, "HampusHatt", 12.99, "vad", 25, "gul");
            HatRepository.DeleteHatsFromStock(1, "GilHatt", 15.99, "vad", 25, "lila");

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

        public int GetSizeOfHats(int size)
        {
            int count=0;
            foreach (var hat in HatRepository.GetAllAvailableHats())
            {
                if (hat.size == size)
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
