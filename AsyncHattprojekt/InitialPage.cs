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
        Testklassen testklassen;
        public InitialPage()
        {
            InitializeComponent();
            anvandareController = new AnvandareController();
            testklassen = new Testklassen();
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


        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSkapaAnvändare_Click(object sender, EventArgs e)
        {
            SkapaAnvändare f = new SkapaAnvändare();
            f.ShowDialog();
            f = null;
            cbVäljAnvändare.Items.Clear();
            cbVäljAnvändare_fyllcbx();
        }

        private void btnLoggaIn_Click_1(object sender, EventArgs e)
        {
            //testklassen.dummydata();
            if (cbVäljAnvändare.SelectedIndex >= 0) {
                this.Hide();
                username = cbVäljAnvändare.Text;
                StartPage f = new StartPage();
                f.ShowDialog();
                f = null;
                this.Show();
            }
            else {
                MessageBox.Show("Välj en användare");
            }
        }


        //private void button4_Click(object sender, EventArgs e)
        //{
        //    StandardHatController.addHats();
        //}

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    StandardHatController.deleteHats();
        //}

        //private void button6_Click(object sender, EventArgs e)
        //{

        //    textBox1.Text = Convert.ToString(StandardHatController.GetUniqueHats().Count());

        //}
    }
}
