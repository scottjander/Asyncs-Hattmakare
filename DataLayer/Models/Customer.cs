using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }

        public int CustomerBonusPoints { get; set; }
        public string Comment { get; set; }
        public string DisplayName => FirstName + " " + LastName;
    }
}
