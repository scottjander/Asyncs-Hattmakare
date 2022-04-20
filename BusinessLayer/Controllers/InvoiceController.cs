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

        public void CreateInvoiceFromSuppplier(DateTime dateTime, double sum)
        {
            invoiceRepository.CreateInvoiceFromSupplierSupplier(dateTime, sum);
        }

        public List<int> GetFiveLatestYears()
        {
            List<int> returnList = new List<int>();
            int currentYear = DateTime.Now.Year;
            for (int i = currentYear; i >= currentYear - 5; i--)
            {
                returnList.Add(i);
            }
            return returnList;

        }
    }

}
