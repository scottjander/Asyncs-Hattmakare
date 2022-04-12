using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using DataLayer.Repositories;

namespace BusinessLayer.Controllers
{
    public class InvoiceController
    {
        private InvoiceRepository invoiceRepository = new InvoiceRepository();

        public List<Invoice> GetAllInvoices()
        {
            return invoiceRepository.GetAllInvoices();
        }

        public List<InvoiceFromSupplier> GetAllInvoicesFromSuppliers()
        {
            return invoiceRepository.GetAllInvoicesFromSuppliers();
        }
    }
}
