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
            FillCmbBoxColors();
            FillComboBoxSize();
            ShowHatStock();
        }

        public void FillComboBoxSize()
        {
            this.cmbBoxSize.SelectedIndexChanged -= new EventHandler(cmbBoxSize_SelectedIndexChanged);
            cmbBoxSize.DataSource = standardHatController.GetUniqueSizes();
            this.cmbBoxSize.SelectedIndexChanged += new EventHandler(cmbBoxSize_SelectedIndexChanged);
        }
        public void FillCmbBoxColors()
        {
            this.cmbBoxColor.SelectedIndexChanged -= new EventHandler(cmbBoxColor_SelectedIndexChanged);
            cmbBoxColor.DataSource = standardHatController.GetUniqueColors();
            this.cmbBoxColor.SelectedIndexChanged += new EventHandler(cmbBoxColor_SelectedIndexChanged);
        }

        private void ShowHatStock()
        {
            int size = Convert.ToInt32(cmbBoxSize.Text);
            string color = cmbBoxColor.Text;
            lblSizeAmount.Text = standardHatController.GetAmountOfHats(size, color).ToString();
        }

        private void cmbBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowHatStock();
        }

        private void cmbBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowHatStock();
        }

        private void btnAddHats_Click(object sender, EventArgs e)
        {
            int amountToDelete = Convert.ToInt32(txtBoxAddHats.Text);
            int size = Convert.ToInt32(cmbBoxSize.Text);
            string color = cmbBoxColor.Text;

            standardHatController.AddHats(amountToDelete, size, color);
            ShowHatStock();
        }

        private void btnRemoveHats_Click(object sender, EventArgs e)
        {
            int amountToDelete = Convert.ToInt32(txtBoxAddHats.Text);
            int size = Convert.ToInt32(cmbBoxSize.Text);
            string color = cmbBoxColor.Text;
            
            standardHatController.DeleteHats(amountToDelete, size, color);
            ShowHatStock();
        }

        private void btnChangePrice_Click(object sender, EventArgs e)
        {
            double newPrice = Convert.ToDouble(txtBoxPrice.Text);

            standardHatController.ChangeHatPrice(newPrice);
            MessageBox.Show("Pris har ändrats");

        }
    }
}
