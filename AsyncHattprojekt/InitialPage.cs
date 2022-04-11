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
using DataLayer;
using DataLayer.Models;


namespace AsyncHattprojekt
{
    public partial class InitialPage : Form
    {
        public Testklassen testklassen;
        public StandardHatController StandardHatController;

        public InitialPage()
        {
            InitializeComponent();
            testklassen = new Testklassen();
            //testklassen.TestMetoden3();
            StandardHatController = new StandardHatController();
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
            var form2 = new StandardHatOrder(5);
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StandardHatController.addHats();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StandardHatController.deleteHats();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = Convert.ToString(StandardHatController.GetUniqueHats().Count());

        }
    }
}
