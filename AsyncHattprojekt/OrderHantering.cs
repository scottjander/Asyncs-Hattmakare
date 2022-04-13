using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Models;

namespace AsyncHattprojekt
{
    public partial class OrderHantering : Form
    {
        public OrderHantering(/* Customer customer, Order order*/)
        {
            InitializeComponent();
            cbStatusEnum.DataSource = Enum.GetValues(typeof(OrderStatus));
        }

        private void lblMail_Click(object sender, EventArgs e)
        {

        }

        private void OrderHantering_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
