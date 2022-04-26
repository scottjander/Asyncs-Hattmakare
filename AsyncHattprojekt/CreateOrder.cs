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
using DataLayer;
using DataLayer.Models;

namespace AsyncHattprojekt
{
    public partial class CreateOrder : Form
    {
        private readonly OrderRepository repository = new OrderRepository();
        private readonly OrderControllerScottRobin controller = new OrderControllerScottRobin();
        public NewUI parent { get; set; }

        public CreateOrder()
        {
            InitializeComponent();
            List<Customer> customers = controller.GetAllCustomers();
            comboBox1.DataSource = customers;
            comboBox1.DisplayMember = "DisplayName";
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            RegKund f = new RegKund();
            f.parent = parent;
            f.ShowDialog();
            Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {

            try {

                string skapare = InitialPage.username;
                var comment = txtBoxComment.Text;
                var Customer = (Customer)comboBox1.SelectedItem;

            
                var orderID = controller.CreateOrder(comment, Customer, skapare);
                OrderForm orderForm = new OrderForm(orderID);
                string stringOrderID = orderID.ToString();
                string stringCustomer = Customer.FirstName + " " + Customer.LastName;
                parent.updateOrderAndCustomer(stringOrderID, stringCustomer);
                parent.activeOrderId = orderID;
                parent.OpenChildForm(new Home());                
                parent.UpdateOrder();
                //orderForm.Show();
                this.Close();

            }
            catch (Exception ex) {
                MessageBox.Show("Var god välj en kund.");
            }

        }
    }
}
