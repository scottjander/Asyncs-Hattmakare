using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Controllers;
using DataLayer;
using DataLayer.Models;

namespace AsyncHattprojekt
{
    public partial class MaterialVy : Form
    {
        FabricStockController fabricStockController;
        public MaterialVy()
        {
            InitializeComponent();
            fabricStockController = new FabricStockController();
            FyllMaterial();
        }
        public void FyllMaterial()
        {
            listView1.Items.Clear();
            List<Fabric> fabrics = fabricStockController.GetAllFabric();
            foreach (Fabric a in fabrics) {

                ListViewItem items = new ListViewItem(new[] { a.ItemName, a.Price.ToString(), a.AmountInStock.ToString(), a.Colour, a.Id.ToString()});
                listView1.Items.Add(items);


                //listView1.Items.Add(a.Price.ToString());
                //listView1.Items.Add(a.AmountInStock.ToString());
                //listView1.Items.Add(a.Colour);

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOkaLager_Click(object sender, EventArgs e)
        {


                double amount = Convert.ToDouble(txtMangd.Text);
                var fabric = listView1.SelectedItems[0];
                var id = Convert.ToInt32(fabric.SubItems[4].Text);

                fabricStockController.IncreaseAmountInStorage(amount, id);
                FyllMaterial();


        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
