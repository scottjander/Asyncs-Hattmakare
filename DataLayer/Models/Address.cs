using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string TownName { get; set; }
        public string PostalCode { get; set; }
        public virtual Customer Customer { get; set; }  

    }
}
