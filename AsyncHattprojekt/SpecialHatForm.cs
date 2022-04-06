using BusinessLayer.Controllers;
using DataLayer;
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
    public partial class SpecialHatForm : Form
    {
        private SpecialHatController specialHatController;
        private Testklassen testklassen;
        private int orderID;

        public SpecialHatForm(int orderID)
        {
            InitializeComponent();
            specialHatController = new SpecialHatController();
            testklassen = new Testklassen();
            testklassen.TestMetoden();
            FillComboBox();
        }

        private void FillComboBox()
        {
            cmbBoxFabric.DataSource = specialHatController.GetFabric();
            cmbBoxFabric.DisplayMember = "ItemName";
        }

        private void btnAddHat_Click(object sender, EventArgs e)
        {

        }
    }
}
