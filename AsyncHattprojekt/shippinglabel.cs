using BusinessLayer;
using DataLayer.Models;
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

namespace AsyncHattprojekt
{
    public partial class shippinglabel : Form
    {
        private readonly ShippingLabelController controller = new ShippingLabelController();

        public shippinglabel(Customer customer, Address address)
        {
            InitializeComponent();
            controller.PrintDocument.PrintPage += new PrintPageEventHandler(controller.printDocument_PrintPage);

            lblName.Text = customer.FirstName + " " + customer.LastName;
            lblStreet.Text = address.StreetName + " " + address.StreetNumber;
            lblTown.Text = address.PostalCode + " " + address.TownName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            controller.PrintLabel(this);

        }
    }
}
