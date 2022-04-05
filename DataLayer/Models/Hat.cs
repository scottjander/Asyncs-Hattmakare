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
        public bool MadeToOrder { get; set; }
        public int Price { get; set; }
        public string Comment { get; set; }
        //public int ExtraTillägg? ifall vi sa att alla tillägg kostar lika mycket?
    }
}
