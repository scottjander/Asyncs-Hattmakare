    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataLayer.Models
{
    public class InvoicesToSerializeFinal
    {
        [XmlElement(ElementName = "Utgående-Fakturor")]
        public OrdinaryInvoiceToSerialize[] Invoices { get; set; }
        [XmlElement(ElementName = "Inkommande-Fakturor")]
        public InvoiceToPayToSerialize[] InvoiceFromSupplier { get; set; }
        [XmlElement(ElementName = "Total-Summa-Ingående")]
        public double TotalSummaIn { get; set; }
        [XmlElement(ElementName = "Total-Summa-Utgående")]
        public double TotalSummaUt { get; set; }
        [XmlElement(ElementName = "Sammanställd-Summa")]
        public double Vinst { get; set; }
    }

    public class OrdinaryInvoiceToSerialize
    {
        public double SumToPay { get; set; }
        public DateTime InvoiceCreated { get; set; }
    }

    public class InvoiceToPayToSerialize
    {
        public double SumToPay { get; set; }
        public DateTime InvoiceCreated { get; set; }
    }

}
