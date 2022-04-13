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

        public OrderHantering(int Id)
        {
            InitializeComponent();
            cbStatusEnum.DataSource = Enum.GetValues(typeof(OrderStatus));
            var order = controller.getOrderOnId(Id);

            var customer = order.Customer;
            var address = customer.Address;
            lblName.Text = customer.DisplayName;
            lblPhone.Text = customer.Phone;
            lblMail.Text = customer.Email;
            lblAddress.Text = address.StreetName;
            lblTownPost.Text = address.PostalCode + " " + address.TownName;
            richTxtBoxComment.Text = order.Comment;
        }

        private void lblMail_Click(object sender, EventArgs e)
        {

        }

        private void OrderHantering_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //skicka in för att ändra i order
            OrderStatus enumValue = (OrderStatus)cbStatusEnum.SelectedItem;
        }
    }
}
