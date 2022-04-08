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
        public Testklassen testklassen;

        public InitialPage()
        {
            InitializeComponent();
            testklassen = new Testklassen();
            testklassen.TestMetoden3();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form2 = new RegKund();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form2 = new StandardHatOrder();
            form2.Show();
        }
    }
}
