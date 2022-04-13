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

        public ListOfCreatedOrders()
        {
            InitializeComponent();
            FillCreatedOrders();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FillCreatedOrders()
        {
            listView1.Items.Clear();
            foreach (Order orders in orderControllerScottRobin.GetCreatedOrders()) {



                ListViewItem lvi = new ListViewItem(orders.Id.ToString());
                lvi.SubItems.Add(orders.TotalPrice.ToString());
                lvi.SubItems.Add(orders.Customer.ToString());
                lvi.SubItems.Add(orders.Comment.ToString());
                listView1.Items.Add(lvi);






            }
        }
    }
}
