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
        private OrderRepository orderRepository = new OrderRepository();
        private int orderID;
        public OrderForm(int orderId)
        {
            InitializeComponent();
            orderID = orderId;
            UpdatePrice();
        }

        public void UpdatePrice()
        {
            var currentOrder = orderRepository.GetOrderOnId(orderID);
            lblTotalPrice.Text = currentOrder.TotalPrice.ToString() + ":-" ?? "0.00:-";
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateStandard_Click(object sender, EventArgs e)
        {
            StandardHatOrder standardHatOrder = new StandardHatOrder(orderID);
            standardHatOrder.Show();
            this.Close();
        }

        private void btnCreateSpecial_Click(object sender, EventArgs e)
        {
            //SpecialHatForm specialHatForm = new SpecialHatForm(orderID);
            //specialHatForm.Show();
        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }


        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (comboBox1.SelectedItem == null) return;
        //    var customer = (Customer)comboBox1.SelectedItem;
        //}
    }
}
