using BusinessLayer;
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

        private void cbVäljAnvändare_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnLoggaIn_Click(object sender, EventArgs e)
        {

            this.Hide();
            StartPage f = new StartPage();
            f.Show();
        }
    }
}
