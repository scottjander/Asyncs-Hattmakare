using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
   public class Hat
    {

        public int Id { get; set; }
        public double Price { get; set; }
        public string Comment { get; set; } 
        public int size { get; set; }
        public string color    { get; set; }
        public string itemName { get; set; }
        public Order order { get; set; }
    }
   public class SpecialHat
   {
       public int Id { get; set; }
       public double Price { get; set; }
       public string Comment { get; set; }
       public int AmountOfDecorations { get; set; }
       public string ImagePath { get; set; }
       public string Name { get; set; }
       public Order Order { get; set; }

    }
}
