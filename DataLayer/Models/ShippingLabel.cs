using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class ShippingLabel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public Address Address { get; set; }
        public double Weight { get; set; }
    }
}
