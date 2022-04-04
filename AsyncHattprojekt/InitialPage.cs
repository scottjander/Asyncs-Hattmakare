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
                var nyanstalld = new Employees() {Name = textBox1.Text};
                context.Employees.Add(nyanstalld);
                context.SaveChanges();
            }

        }
    }
}
