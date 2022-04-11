using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;



namespace AsyncHattprojekt
{
    public partial class InitialPage : Form
    {
        AnvandareController anvandareController;
        public InitialPage()
        {
            InitializeComponent();
            anvandareController = new AnvandareController();
            cbVäljAnvändare_fyllcbx();
        }

        private void cbVäljAnvändare_fyllcbx()
        {
            List<string> namn = anvandareController.getAllEmployeeNames();
            foreach(string name in namn)
            {
                cbVäljAnvändare.Items.Add(name);
            }
        }

      
        public static string username = "";
        private void btnLoggaIn_Click(object sender, EventArgs e)
        {
            //var testklassen = new Testklassen();
            //testklassen.dummydata();
            this.Hide();
            username = cbVäljAnvändare.Text;
            StartPage f = new StartPage();
            f.ShowDialog();
            f = null;
            this.Show();
           
        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
