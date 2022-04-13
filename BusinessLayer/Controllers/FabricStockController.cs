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
    }
}
