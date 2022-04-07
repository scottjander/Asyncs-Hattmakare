using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer.Models;

namespace AsyncHattprojekt
{
    public partial class RegKund : Form
    {
        public CustomerController customerController = new CustomerController();

        public RegKund()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void RegistreraBtn_Click(object sender, EventArgs e)
        {
            var nyAddress = new Address() { StreetName = AdrNamTxd.Text, StreetNumber = AdrNmrTxd.Text, TownName = StadTxd.Text, PostalCode = PostNmrTxd.Text};

            customerController.RegisterCustomer(FirstNameTxd.Text, LastNameTxd.Text, PhoneTxd.Text, EmailTxd.Text, nyAddress, CommentTxt.Text);
            // string firstName, string lastName, int phone, string email, Address address, string comment
        }
    }
}
