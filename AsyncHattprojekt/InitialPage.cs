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
            var testklassen = new Testklassen();
            testklassen.dummydata();
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
    }
}
