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
    public partial class ListOfFinishedOrders : Form
    {
        public HatDbContext HatDbContext = new HatDbContext();
        public OrderControllerScottRobin orderControllerScottRobin = new OrderControllerScottRobin();
        public int orderID;
        public NewUI parent;
        public ListOfFinishedOrders()
        {
            InitializeComponent();
            FillFinishedOrders();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FillFinishedOrders()
        {
            listView1.Items.Clear();
            foreach (Order orders in orderControllerScottRobin.GetFinishedOrders()) {
                ListViewItem lvi = new ListViewItem(orders.Id.ToString());
                lvi.SubItems.Add(orders.TotalPrice.ToString());
                lvi.SubItems.Add(orders.Customer.FirstName.ToString() + " " + orders.Customer.LastName.ToString());
                lvi.SubItems.Add(orders.StartDate.ToString());
                lvi.SubItems.Add(orders.DateFinished.ToString());

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

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) {
                orderID = Convert.ToInt32(listView1.SelectedItems[0].Text);
            }

        }
    }
}
