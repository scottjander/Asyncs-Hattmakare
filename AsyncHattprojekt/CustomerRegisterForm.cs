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
    public partial class CustomerRegisterForm : Form
    {
        private readonly KundController controller = new KundController();
        public CustomerRegisterForm()
        {
            InitializeComponent();
            foreach(var customer in controller.GetAllCustomers()) {
                ListViewItem customerToAdd = new ListViewItem(customer.Id.ToString());
                customerToAdd.SubItems.Add(customer.FirstName);
                customerToAdd.SubItems.Add(customer.LastName);
                customerToAdd.SubItems.Add(customer.Phone);
                customerToAdd.SubItems.Add(customer.Email);
                customerToAdd.SubItems.Add(customer.Address.TownName);
                customerToAdd.SubItems.Add(customer.Address.PostalCode);
                customerToAdd.SubItems.Add(customer.Address.StreetName);
                customerToAdd.SubItems.Add(customer.CustomerBonusPoints.ToString());
                listviewCust.Items.Add(customerToAdd);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
