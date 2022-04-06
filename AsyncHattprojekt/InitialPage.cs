using System;
using System.Windows.Forms;


namespace AsyncHattprojekt
{
    public partial class InitialPage : Form
    {
        public InitialPage()
        {
            InitializeComponent();
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
