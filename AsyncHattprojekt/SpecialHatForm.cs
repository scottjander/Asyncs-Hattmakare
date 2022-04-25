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
            //foreach (Fabric fabric in specialHatController.GetAllFabrics())
            //{
            //    ListViewItem lvi = new ListViewItem(fabric.Id.ToString());
            //    lvi.SubItems.Add(fabric.ItemName);
            //    lvi.SubItems.Add(fabric.Colour);
            //    lvi.SubItems.Add(fabric.AmountInStock.ToString());
            //    listView1.Items.Add(lvi);
            //}
            foreach (Fabric fabric in specialHatController.GetAllFabrics()) {

                ListViewItem items = new ListViewItem(new[] { fabric.ItemName, fabric.Colour, fabric.Price.ToString(), fabric.Id.ToString() });
                listView1.Items.Add(items);
            }
        }


        private void btnAddHat_Click(object sender, EventArgs e)
        {
            try {
                Fabric fabric = specialHatController.GetFabricOnId(fabricID);
                string name = txtBoxName.Text;
                double length = Convert.ToDouble(txtBoxFabricLength.Text);
                int decoration = Convert.ToInt32(txtBoxDecoration.Text);
                int size = Convert.ToInt32(txtBoxSize.Text);
                string comment = txtBoxComment.Text;
                string fileName = txtBoxFileName.Text;
                if (fabric != null && length != 0 ) {
                    specialHatController.AddSpecialHat(name, fabric, length, decoration, size, comment, orderID,
                        fileName,
                        filePath);
                    this.Close();
                     parent.UpdateOrder();
                }
                else {
                    MessageBox.Show("Fyll i all information");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message + " Dubbelkolla att fälten är korrekt ifyllda.");
            }
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
            if (listView1.SelectedItems.Count > 0) {
                var fabric = listView1.SelectedItems[0];
                fabricID = Convert.ToInt32(fabric.SubItems[3].Text);
                txtBoxChosenFabric.Text = fabric.SubItems[0].Text + "\t " +
                                          fabric.SubItems[1].Text;
            }
        }

        private void SpecialHatForm_Load(object sender, EventArgs e)
        {

        }
    }
}
