using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer.Models;

namespace AsyncHattprojekt
{
    public partial class FraktsedelForm : Form
    {
        private readonly ShippingLabelController controller = new ShippingLabelController();
        public FraktsedelForm()
        {
            InitializeComponent();
        }
        public FraktsedelForm(Customer customer, Address address)
        {
            InitializeComponent();
            controller.printDocument.PrintPage += new PrintPageEventHandler(controller.printDocument_PrintPage);

            lblName.Text = customer.FirstName + " " + customer.LastName;
            lblStreet.Text = address.StreetName + " " + address.StreetNumber;
            lblTown.Text = address.PostalCode + " " + address.TownName;
            pictureBox1.Image = controller.GenerateBarCode("placeholderstring");
            lblDate.Text = DateTime.Now.ToString();
        }


        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            controller.PrintLabel(this);
            this.Dispose();
        }
    }
}
