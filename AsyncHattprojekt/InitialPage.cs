using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using DataLayer.Models;


namespace AsyncHattprojekt
{
    public partial class InitialPage : Form
    {
        public InitialPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new HatDbContext())
            {
                var customer = new Customer()
                {
                    CustomerBonusPoints = 0, Email = "meh", FirstName = "Berik", LastName = "Bawerman", Phone = 07623424
                };
                var enHatt = new Hat() {Comment = "Gjorde två hatt", MadeToOrder = true, Price = 100};
                var tvaHatt = new Hat() { Comment = "Gjorde tre hatt", MadeToOrder = true, Price = 570 };
                var hattLista = new List<Hat>();
                hattLista.Add(enHatt);
                hattLista.Add(tvaHatt);
                DateTime tiden = DateTime.Now;
                var minOrder = new Order()
                    {Comment = "Näe", Customer = customer, Hats = hattLista, TotalPrice = hattLista.Sum(x => x.Price), StartDate = tiden, DateFinished = tiden };
                context.Customers.Add(customer);
                context.Hats.Add(enHatt);
                context.Hats.Add(tvaHatt);
                context.Orders.Add(minOrder);
                context.SaveChanges();

                //var nyanstalld = new Employees() {Name = textBox1.Text};
                //context.Employees.Add(nyanstalld);
                //context.SaveChanges();
            }

        }
    }
}
