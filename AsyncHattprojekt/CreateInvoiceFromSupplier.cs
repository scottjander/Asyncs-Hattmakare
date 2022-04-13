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

namespace AsyncHattprojekt
{
    public partial class CreateInvoiceFromSupplier : Form
    {

        private DateTime SelectedDateTime;

        private double InsertedSum = 0;

        private InvoiceController invoiceController = new InvoiceController();


        public CreateInvoiceFromSupplier()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SelectedDateTime = dateTimePicker.Value;            
        }

        private void txtSum_TextChanged(object sender, EventArgs e)
        {
            InsertedSum = Convert.ToDouble(txtSum.Text);
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            invoiceController.CreateInvoiceFromSuppplier(SelectedDateTime, InsertedSum);
            MessageBox.Show("Faktura sparad.");

        }
    }
}
