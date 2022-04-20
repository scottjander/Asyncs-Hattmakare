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
using DataLayer.Models.Enums;

namespace AsyncHattprojekt
{
    
    public partial class ManageHatts : Form
    {
        private StandardHatController standardHatController = new StandardHatController();
        public ManageHatts()
        {
            InitializeComponent();
            ShowHatStock();
            FillCmbBoxColors();
            FillComboBoxSize();
        }

        public void FillComboBoxSize()
        {
            cmbBoxSize.DataSource = standardHatController.GetUniqueSizes();
        }
        public void FillCmbBoxColors()
        {
            cmbBoxColor.DataSource = standardHatController.GetUniqueColors();
        }

        private void ShowHatStock()
        {
            int size = (int) HatSize.S54;
            lblSizeAmount.Text = standardHatController.GetSizeOfHats(size).ToString();
            size = (int) HatSize.S54;
        }

        private void btnRemove52_Click(object sender, EventArgs e)
        {

        }
    }
}
