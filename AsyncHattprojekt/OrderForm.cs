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
    public partial class OrderForm : Form
    {
        private readonly OrderControllerScottRobin controller = new OrderControllerScottRobin();
        private readonly OrderRepository repository = new OrderRepository();
        public OrderForm()
        {
            InitializeComponent();

            List<Customer> customers = repository.getallcustomers();
            comboBox1.DataSource = customers;
            comboBox1.DisplayMember = "DisplayName";


        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            var comment = txtBoxComment.Text;
            var Customer  = (Customer) comboBox1.SelectedItem;

            if (Customer != null)
            {
                controller.CreateOrder(comment, Customer);
            }

        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (comboBox1.SelectedItem == null) return;
        //    var customer = (Customer)comboBox1.SelectedItem;
        //}
    }
}
