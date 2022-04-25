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

namespace AsyncHattprojekt
{
    public partial class SkapaAnvändare : Form
    {
        AnvandareController anvandareController;
        public SkapaAnvändare()
        {
            InitializeComponent();
            anvandareController = new AnvandareController();
        }

        private void btnSkapaAnvandare_Click(object sender, EventArgs e)
        {
            string anvandare = txtNyAnvandare.Text;
            if (anvandare.Length >= 1 && anvandare.Length <= 15) {
                anvandareController.LaggTillAnstalld(anvandare);
                this.Close();
            }
            else {
                MessageBox.Show("Använd mellan 1 och 15 karaktärer");
            }
        }
    }
}
