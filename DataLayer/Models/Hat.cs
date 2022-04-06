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
    }
   public class SpecialHat : Hat
   {
       public int AmountOfDecorations { get; set; }
       public string ImagePath { get; set; }
       public string Name { get; set; }

   }
}
