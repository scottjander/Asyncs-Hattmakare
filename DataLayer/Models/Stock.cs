using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models.Enums;

namespace DataLayer.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public ICollection<Hat> hats { get; set; }
    }


    public class FabricStock : Stock
    {

    }
}
