using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Controllers;
using DataLayer.Models;

namespace AsyncHattprojekt
{
    public partial class TaxesSummary : Form
    {
        private InvoiceController invoiceController = new InvoiceController();
        public TaxesSummary()
        {
            InitializeComponent();
        }

        public void FillIncommingInvoices()
        {
            //listView1.Items.Clear();
            //foreach (Invoice invoice in invoiceController.GetAllInvoices()) {
            //    ListViewItem lvi = new ListViewItem(invoiceToString());
            //    lvi.SubItems.Add(fabric.ItemName);
            //    lvi.SubItems.Add(fabric.Colour);
            //    lvi.SubItems.Add(fabric.AmountInStock.ToString());
            //    listView1.Items.Add(lvi);
            //}
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
