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
    public partial class OrderHantering : Form
    {
        private readonly OrderControllerScottRobin controller = new OrderControllerScottRobin();
        private Order order;
        private Customer customer;
        public OrderHantering(int Id)
        {
            InitializeComponent();
            cbStatusEnum.DataSource = Enum.GetValues(typeof(OrderStatus));
            order = controller.getOrderOnId(Id);
            customer = order.Customer;

            var address = customer.Address;
            lblName.Text = customer.DisplayName;
            lblPhone.Text = customer.Phone;
            lblMail.Text = customer.Email;
            lblAddress.Text = address.StreetName;
            lblTownPost.Text = address.PostalCode + " " + address.TownName;
            richTxtBoxComment.Text = order.Comment;
            cbStatusEnum.SelectedItem = order.OrderStatus;
        }

        private void lblMail_Click(object sender, EventArgs e)
        {

        }

        private void OrderHantering_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            order.Comment = richTxtBoxComment.Text;
            OrderStatus enumValue = (OrderStatus)cbStatusEnum.SelectedItem;
            controller.EditOrderStatus(order, enumValue);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FraktsedelForm f = new FraktsedelForm(customer, customer.Address);
            f.ShowDialog();
            f = null;
            this.Show();
        }
    }
}
