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
using BusinessLayer;


namespace AsyncHattprojekt
{
    public partial class StandardHatOrder : Form
    {
        public HatDbContext HatDbContext = new HatDbContext();
        public StandardHatController standardHatController = new StandardHatController();

        public StandardHatOrder()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {



        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            standardHatController.OrderStandardHat(Convert.ToDouble(prisTxtBx.Text), kommentarTxtBx.Text);
        }

        private void prisTxtBx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
