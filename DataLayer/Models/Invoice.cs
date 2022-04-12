using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public Address InvoiceAddress { get; set; }
        public double SumToPay { get; set; }
        public Order Order { get; set; }
        public bool IsPaid { get; set; }
        public DateTime DateCreated { get; set; }
    }

    public class InvoiceFromSupplier
    {
        public int Id { get; set; }
        public double SumToPay { get; set; }
        public DateTime DateCreated { get; set; }
    }

}
