using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class CustomsDeclaration
    {
        public int Id { get; set; }
        public ICollection<Hat> Hats { get; set; }

    }
}
