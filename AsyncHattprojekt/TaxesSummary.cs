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
            FillInvoicesFromSuppliers();
            FillInvoies();
        }

        public void FillInvoies()
        {
            listView1.Items.Clear();
            double totalAmount = 0;
            foreach (Invoice invoice in invoiceController.GetAllInvoices()) {
                totalAmount += invoice.SumToPay;
                ListViewItem lvi = new ListViewItem(invoice.DateCreated.ToString());
                lvi.SubItems.Add(invoice.SumToPay.ToString());
                listView1.Items.Add(lvi);
            }
            txtBoxTotalAmountOut.Text = totalAmount.ToString() + "kr";
            txtBoxTaxAmountOut.Text = (totalAmount * 0.25).ToString() + "kr";

        }
        public void FillInvoicesFromSuppliers()
        {
            listView1.Items.Clear();
            double totalAmount = 0;
            foreach (InvoiceFromSupplier invoice in invoiceController.GetAllInvoicesFromSuppliers()) {
                totalAmount += invoice.SumToPay;
                ListViewItem lvi = new ListViewItem(invoice.DateCreated.ToString());
                lvi.SubItems.Add(invoice.SumToPay.ToString());
                listView2.Items.Add(lvi);
            }
            txtBoxTotalAmountIn.Text = totalAmount.ToString() + "kr";
            txtBoxTaxAmountIn.Text = (totalAmount * 0.25).ToString() + "kr";

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
