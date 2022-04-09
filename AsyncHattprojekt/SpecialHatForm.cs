using BusinessLayer.Controllers;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DataLayer.Models;

namespace AsyncHattprojekt
{
    public partial class SpecialHatForm : Form
    {
        private SpecialHatController specialHatController;
        private Testklassen testklassen;
        private int orderID;

        public SpecialHatForm(int orderId)
        {
            InitializeComponent();
            specialHatController = new SpecialHatController();
            testklassen = new Testklassen();
            testklassen.TestMetoden();
            FillComboBox();
            orderID=orderId;
        }

        private void FillComboBox()
        {
            cmbBoxFabric.DataSource = specialHatController.GetFabric();
            cmbBoxFabric.DisplayMember = "ItemName";
        }

        private void btnAddHat_Click(object sender, EventArgs e)
        {
            string name = txtBoxName.Text;
            FabricStock fabric = cmbBoxFabric.SelectedItem as FabricStock;
            double length = Convert.ToDouble(txtBoxFabricLength.Text);
            int decoration = Convert.ToInt32(txtBoxDecoration.Text);
            int size = Convert.ToInt32(txtBoxSize.Text);
            string comment = txtBoxComment.Text;
            string fileName = txtBoxFileName.Text;
            specialHatController.AddSpecialHat(name, fabric, length, decoration, size, comment, orderID, fileName);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(dialog.FileName);
                txtBoxFileName.Text = dialog.FileName;
            }

        }
    }
}
