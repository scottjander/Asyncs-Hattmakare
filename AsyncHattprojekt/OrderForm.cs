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
        private int orderID;
        public OrderForm(int orderId)
        {
            InitializeComponent();
            orderID = orderId;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateStandard_Click(object sender, EventArgs e)
        {
            StandardHatOrder standardHatOrder = new StandardHatOrder(orderID);
            standardHatOrder.Show();
        }

        private void btnCreateSpecial_Click(object sender, EventArgs e)
        {
            SpecialHatForm specialHatForm = new SpecialHatForm(orderID);
            specialHatForm.Show();
        }


        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (comboBox1.SelectedItem == null) return;
        //    var customer = (Customer)comboBox1.SelectedItem;
        //}
    }
}
