using DataLayer.Models;
using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Controllers
{
    public class FabricStockController
    {
        public FabricRepository FabricRepository
        {
            get { return new FabricRepository(); }
        }

        public List<Fabric> GetAllFabric ()
        {
            List<Fabric> fabrics = FabricRepository.GetAllFabric();
            return fabrics;

        }




    }
}
