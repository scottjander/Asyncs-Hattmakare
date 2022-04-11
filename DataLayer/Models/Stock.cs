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
        public string ItemName { get; set; }
        public double Price { get; set; }
        public double AmountInStock { get; set; }
        public string Colour { get; set; }
    }


    public class FabricStock : Stock
    {

      
    }
}
