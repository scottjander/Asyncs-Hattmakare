using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DataLayer;
using DataLayer.Models;

namespace BusinessLayer.Controllers
{
    public class Serializer
    {
        private readonly HatDbContext _context = new HatDbContext();
        private readonly InvoiceController _invoices = new InvoiceController();
        public void SerializeTaxes(int year)
        {
            var invoices = _invoices.GetAllInvoices().Where(x=> x.DateCreated.Year == year);
            var invoicesToPayArray = _invoices.GetAllInvoicesFromSuppliers().Where(x => x.DateCreated.Year == year);
            double totalSummaIn = 0;
            double totalSummaUt = 0;

            OrdinaryInvoiceToSerialize[] invoiceArray = new OrdinaryInvoiceToSerialize[invoices.Count()];
            InvoiceToPayToSerialize[] invoiceToPayArray = new InvoiceToPayToSerialize[invoicesToPayArray.Count()];

            int i = 0;
            foreach (var invoice in invoices)
            {
                invoiceArray[i++] = new OrdinaryInvoiceToSerialize()
                {
                    SumToPay = invoice.SumToPay
                };
                totalSummaIn += invoice.SumToPay;

            }

            i = 0;
            foreach (var invoice in invoicesToPayArray)
            {
                invoiceToPayArray[i++] = new InvoiceToPayToSerialize()
                {
                    SumToPay = invoice.SumToPay
                };
                totalSummaUt += invoice.SumToPay;

            }

            InvoicesToSerializeFinal SerializedItem = new InvoicesToSerializeFinal()
            {
                InvoiceFromSupplier = invoiceToPayArray,
                Invoices = invoiceArray,
                TotalSummaIn = totalSummaIn,
                TotalSummaUt = totalSummaUt,
                Vinst = totalSummaIn - totalSummaUt

            };
             XmlSerializer serializer = new XmlSerializer(typeof(InvoicesToSerializeFinal));

             using (FileStream fs = new FileStream("XMLFiles\\" + DateTime.Now.ToString("mmddyyyyhhmmss"), FileMode.Create))
            {
                serializer.Serialize(fs, SerializedItem);
                fs.Close();
            }
            


        }

    }
}
