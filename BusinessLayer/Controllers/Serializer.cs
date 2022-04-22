using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            //Hämta alla fakturor baserat på årtal valt från comboboxen
            var invoices = _invoices.GetAllInvoices().Where(x=> x.DateCreated.Year == year);
            var invoicesToPayArray = _invoices.GetAllInvoicesFromSuppliers().Where(x => x.DateCreated.Year == year);
            double totalSummaIn = 0;
            double totalSummaUt = 0;

            //Vi kan inte serialisera våra vanliga Invoice-klasser då de har andra objekt refererade i sig, så här skapar vi arrayer med nya modeller
            OrdinaryInvoiceToSerialize[] invoiceArray = new OrdinaryInvoiceToSerialize[invoices.Count()];
            InvoiceToPayToSerialize[] invoiceToPayArray = new InvoiceToPayToSerialize[invoicesToPayArray.Count()];


            //Fyll arrayerna med objekt, + addera på totalsummain/ut.
            int i = 0;
            foreach (var invoice in invoices)
            {
                invoiceArray[i++] = new OrdinaryInvoiceToSerialize()
                {
                    SumToPay = invoice.SumToPay,
                    InvoiceCreated = invoice.DateCreated
                };
                totalSummaIn += invoice.SumToPay;

            }

            i = 0;
            foreach (var invoice in invoicesToPayArray)
            {
                invoiceToPayArray[i++] = new InvoiceToPayToSerialize()
                {
                    SumToPay = invoice.SumToPay,
                    InvoiceCreated = invoice.DateCreated
                };
                totalSummaUt += invoice.SumToPay;

            }

            //Skapa objektet som faktiskt serialiseras
            InvoicesToSerializeFinal SerializedItem = new InvoicesToSerializeFinal()
            {
                InvoiceFromSupplier = invoiceToPayArray,
                Invoices = invoiceArray,
                TotalSummaIn = totalSummaIn,
                TotalSummaUt = totalSummaUt,
                Vinst = totalSummaIn - totalSummaUt

            };

            //Serialisera och öppna filen.
             XmlSerializer serializer = new XmlSerializer(typeof(InvoicesToSerializeFinal));

             var filepath = DateTime.Now.ToString("mmddyyyyhhmmss") + ".xml";
             using (FileStream fs = new FileStream(filepath, FileMode.Create))
            {
                serializer.Serialize(fs, SerializedItem);
                fs.Close();

            }

            Process.Start(filepath);


        }

    }
}
