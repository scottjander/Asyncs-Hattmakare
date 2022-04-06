using DataLayer.Models;
using DataLayer.Repository;
using System;
using System.Collections.Generic;
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

        public void CreateSpecialOrder(Order order)
        {
            //SpecialHatRepository.addSpecialHat();
        }

        public List<FabricStock> GetFabric()
        {
            var fabricList = StockRepository.GetAllFabric();



            return fabricList;
        }
    }
}
