using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class FabricRepository
    {
        private readonly HatDbContext _context;
        public FabricRepository()
        {
            _context = new HatDbContext();
        }

        public List<FabricStock> GetAllFabric()
        {

            return _context.MaterialStock.ToList();
        }

        public void DecreaseAmountInStorage(double amountToDecrease, FabricStock fabric)
        {
            fabric.AmountInStock -= amountToDecrease;
            _context.SaveChanges();
        }
        public void IncreaseAmountInStorage(double amountToIncrease, FabricStock fabric)
        {
            fabric.AmountInStock += -amountToIncrease;
            _context.SaveChanges();
        }

        public FabricStock GetFabricOnId(int id)
        {
            return _context.MaterialStock.FirstOrDefault(fabric => fabric.Id == id);
        }
    }

}
