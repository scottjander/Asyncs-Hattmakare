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
        private string filePath;
        private int fabricID;
        public NewUI parent { get; set; }

        public SpecialHatForm(int orderId)
        {
            InitializeComponent();
            specialHatController = new SpecialHatController();
            testklassen = new Testklassen();
            orderID = orderId;
            FillListView();
        }


        private void FillListView()
        {
            listView1.Items.Clear();
            foreach (Fabric fabric in specialHatController.GetAllFabrics())
            {
                ListViewItem lvi = new ListViewItem(fabric.Id.ToString());
                lvi.SubItems.Add(fabric.ItemName);
                lvi.SubItems.Add(fabric.Colour);
                lvi.SubItems.Add(fabric.AmountInStock.ToString());
                listView1.Items.Add(lvi);
            }
        }


        private void btnAddHat_Click(object sender, EventArgs e)
        {
            //validera fält
            Fabric fabric = specialHatController.GetFabricOnId(fabricID);
            string name = txtBoxName.Text;
            double length = Convert.ToDouble(txtBoxFabricLength.Text);
            int decoration = Convert.ToInt32(txtBoxDecoration.Text);
            int size = Convert.ToInt32(txtBoxSize.Text);
            string comment = txtBoxComment.Text;
            string fileName = txtBoxFileName.Text;
            specialHatController.AddSpecialHat(name, fabric, length, decoration, size, comment, orderID, fileName, filePath);
            this.Close();
            OrderForm orderform = new OrderForm(orderID);
            orderform.Show();
            parent.UpdatePrice();
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
                filePath = dialog.SafeFileName;
            }

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                fabricID = Convert.ToInt32(listView1.SelectedItems[0].Text);
                txtBoxChosenFabric.Text = listView1.SelectedItems[0].SubItems[1].Text + "\t " +
                                          listView1.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void SpecialHatForm_Load(object sender, EventArgs e)
        {

        }
    }
}
