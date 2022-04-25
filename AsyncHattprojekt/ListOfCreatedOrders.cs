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
    public partial class ListOfCreatedOrders : Form
    {
        public HatDbContext HatDbContext = new HatDbContext();
        public OrderControllerScottRobin orderControllerScottRobin = new OrderControllerScottRobin();
        private int orderID;
        public NewUI parent;

        public ListOfCreatedOrders()
        {
            InitializeComponent();
            FillCreatedOrders();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) {
                orderID = Convert.ToInt32(listView1.SelectedItems[0].Text);
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FillCreatedOrders()
        {
            listView1.Items.Clear();
            foreach (Order orders in orderControllerScottRobin.GetCreatedOrders()) 
            {
                ListViewItem lvi = new ListViewItem(orders.Id.ToString());
                lvi.SubItems.Add(orders.TotalPrice.ToString());
                lvi.SubItems.Add(orders.Customer.FirstName.ToString() + " " + orders.Customer.LastName.ToString());
                lvi.SubItems.Add(orders.Comment.ToString());
                listView1.Items.Add(lvi);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) {
                var item = listView1.SelectedItems[0];
                this.Hide();
                OrderHantering form = new OrderHantering(orderID);
                parent.OpenChildForm(form);
            }
        }
    }
}
