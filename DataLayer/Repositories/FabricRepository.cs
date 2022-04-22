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

        public List<Fabric> GetAllFabric()
        {

            return _context.Fabrics.ToList();
        }
        public void DecreaseAmountInStorage(double amountToDecrease, Fabric fabric)
        {
            if (fabric != null)
            {
                fabric.AmountInStock -= amountToDecrease;
                _context.SaveChanges();
            }
        }
        public void IncreaseAmountInStorage(double amountToIncrease, int fabricid)
        {
            var currentFabric = GetFabricOnId(fabricid);
            currentFabric.AmountInStock += amountToIncrease;
            _context.SaveChanges();
        }

        public Fabric GetFabricOnId(int id)
        {
            return _context.Fabrics.FirstOrDefault(fabric => fabric.Id == id);
        }
    }

}
