using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncHattprojekt
{
    public partial class Testform : Form
    {
        public Testform()
        {
            InitializeComponent();
        } 
        private void btnSpecialBeställning_Click(object sender, EventArgs e)
        {
     
        }

        private void btnStandardBeställning_Click(object sender, EventArgs e)
        {

        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
            StartPage f = new StartPage();
            f.Show();
        }
    }
}
