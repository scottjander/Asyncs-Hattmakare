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
        private readonly Serializer _serializer = new Serializer();
        public TaxesSummary()
        {
            InitializeComponent();
            FillAvalibleYears();
            FillInvoicesFromSuppliers(cbYears.Text);
            FillInvoies(cbYears.Text);
            
        }

        public void FillInvoies(string filteredYear)
        {
            listView1.Items.Clear();
            int selectedYear = Convert.ToInt32(filteredYear);
            double totalAmount = 0;
            foreach (Invoice invoice in invoiceController.GetAllInvoices()) {
                if (invoice.DateCreated.Year != selectedYear) {
                    continue;
                }

                totalAmount += invoice.SumToPay;
                ListViewItem lvi = new ListViewItem(invoice.DateCreated.ToString());
                lvi.SubItems.Add(invoice.SumToPay.ToString());
                listView1.Items.Add(lvi);
            }
            txtBoxTotalAmountOut.Text = totalAmount.ToString() + "kr";
            txtBoxTaxAmountOut.Text = (totalAmount * 0.25).ToString() + "kr";

        }
        public void FillInvoicesFromSuppliers(string filteredYear)
        {
            listView2.Items.Clear();
            int selectedYear = Convert.ToInt32(filteredYear);
            double totalAmount = 0;
            foreach (InvoiceFromSupplier invoice in invoiceController.GetAllInvoicesFromSuppliers()) {
                if (invoice.DateCreated.Year != selectedYear) {
                    continue;
                }
                totalAmount += invoice.SumToPay;
                ListViewItem lvi = new ListViewItem(invoice.DateCreated.ToString());
                lvi.SubItems.Add(invoice.SumToPay.ToString());
                listView2.Items.Add(lvi);
            }
            txtBoxTotalAmountIn.Text = totalAmount.ToString() + "kr";
            txtBoxTaxAmountIn.Text = (totalAmount * 0.25).ToString() + "kr";

        }

        public void FillAvalibleYears()
        {
            cbYears.DataSource = invoiceController.GetFiveLatestYears();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillInvoicesFromSuppliers(cbYears.Text);
            FillInvoies(cbYears.Text);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            int year = Int32.Parse(cbYears.SelectedItem.ToString());
           _serializer.SerializeTaxes(year);
            


        }
    }
}
