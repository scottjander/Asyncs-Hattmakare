using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DateFinished { get; set; }
        public string Comment { get; set; }
        public double TotalPrice { get; set; }
        public ICollection<Hat> Hats { get; set; }
        public Customer Customer { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}
