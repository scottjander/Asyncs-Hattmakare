using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer.Repositories
{
    public class InvoiceRepository
    {
        private readonly HatDbContext _context;

        public InvoiceRepository()
        {
            _context = new HatDbContext();
        }

        public List<Invoice> GetAllInvoices()
        {
            return _context.Invoices.ToList();
        }

        public List<InvoiceFromSupplier> GetAllInvoicesFromSuppliers()
        {
            return _context.InvoiceFromSuppliers.ToList();
        }

    }
}
