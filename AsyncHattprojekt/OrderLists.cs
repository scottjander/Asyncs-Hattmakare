using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncHattprojekt
{
    public partial class OrderLists : Form
    {
        public OrderLists()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListOfCreatedOrders f = new ListOfCreatedOrders();
            f.ShowDialog();
            f = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {     
            this.Hide();
            ListOfStartedOrders f = new ListOfStartedOrders();
            f.ShowDialog();
            f = null;
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {       
            this.Hide();
            ListOfFinishedOrders f = new ListOfFinishedOrders();
            f.ShowDialog();
            f = null;
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
