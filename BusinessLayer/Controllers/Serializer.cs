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
        public void SerializeTaxes()
        {
            var invoices = _invoices.GetAllInvoices();
            var invoicesToPayArray = _invoices.GetAllInvoicesFromSuppliers();
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

             using (FileStream fs = new FileStream("DataTestHittaMig.Xml", FileMode.Create))
            {
                serializer.Serialize(fs, SerializedItem);
                fs.Close();
            }
            

            //string currentDirectory = Directory.GetCurrentDirectory();

            //string folderPath = currentDirectory.Substring(0, currentDirectory.Length - 26) + "DataLayer\\XMLFiles";
            //if (!Directory.Exists(folderPath))
            //{
            //    Directory.CreateDirectory(folderPath);
            //}

        }

    }
}
