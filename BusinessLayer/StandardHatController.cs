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
            HatRepository.AddHatsToStock(10, "plommonHatt", 19.99, "vad", 25, "svart");
            HatRepository.AddHatsToStock(5, "HampusHatt", 12.99, "vad", 25, "gul");
            HatRepository.AddHatsToStock(9, "GilHatt", 15.99, "vad", 25, "lila");
        }

        public void deleteHats()
        {
            HatRepository.DeleteHatsFromStock(11, "plommonHatt", 19.99, "vad", 25, "svart");
            HatRepository.DeleteHatsFromStock(4, "HampusHatt", 12.99, "vad", 25, "gul");
            HatRepository.DeleteHatsFromStock(1, "GilHatt", 15.99, "vad", 25, "lila");

        }


        public void OrderStandardHat(double price, string comment)
        {
            var hat = new Hat()
            {
               Price = price,
               Comment = comment,

            };
            HatDbContext.Hats.Add(hat);
            HatDbContext.SaveChanges(); 
        }

        public List<Hat> GetUniqueHats()
        {
            var returnList = new List<Hat>();
            var forbiddenListSize = new List<int>();
            var forbiddenListColor = new List<string>();
            foreach (var hat in HatRepository.GetAllAvalibleHats())
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
    }
}
