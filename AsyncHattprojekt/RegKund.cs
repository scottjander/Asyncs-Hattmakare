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
using BusinessLayer.Controllers;
using DataLayer.Models;

namespace AsyncHattprojekt
{
    public partial class RegKund : Form
    {
        public CustomerController customerController = new CustomerController();
        private readonly OrderControllerScottRobin ordercontroller = new OrderControllerScottRobin();
        public NewUI parent;

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
            //Den här valideringen är fantastiskt ful och ineffektiv men det blev den snabba lösningen vi fick göra nu. Too bad!
            if (AdrNamTxd.Text != String.Empty && AdrNmrTxd.Text != String.Empty && StadTxd.Text != String.Empty && PostNmrTxd.Text != String.Empty) {
                var nyAddress = new Address() {
                    StreetName = AdrNamTxd.Text, StreetNumber = AdrNmrTxd.Text, TownName = StadTxd.Text,
                    PostalCode = PostNmrTxd.Text
                };


                if (FirstNameTxd.Text != String.Empty && LastNameTxd.Text != String.Empty &&
                    PhoneTxd.Text != String.Empty && EmailTxd.Text != String.Empty) {
                   var Customer = customerController.RegisterCustomer(FirstNameTxd.Text, LastNameTxd.Text, PhoneTxd.Text,
                        EmailTxd.Text,
                        nyAddress, CommentTxt.Text);
                    MessageBox.Show("Kund registrerad.");
                    string skapare = InitialPage.username;
                    var orderID = ordercontroller.CreateOrder(CommentTxt.Text, Customer, skapare);
                    string stringOrderID = orderID.ToString();
                    string stringCustomer = Customer.FirstName + " " + Customer.LastName;
                    parent.updateOrderAndCustomer(stringOrderID, stringCustomer);
                    parent.activeOrderId = orderID;
                    parent.OpenChildForm(new Home());
                    //orderForm.Show();
                    this.Close();
                    //CreateOrder orderfrom = new Cr
                    //eateOrder();
                    //orderfrom.Show();
                }
                else {
                    MessageBox.Show("Vänligen fyll i all information.");
                }
            }
            else {
                MessageBox.Show("Vänligen fyll i all information.");
            }
        }
    }
}
