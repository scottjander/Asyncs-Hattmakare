﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Controllers;
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
            List<Fabric> fabrics = fabricStockController.GetAllFabric();
            foreach (Fabric a in fabrics) {

                ListViewItem items = new ListViewItem((new[] { a.ItemName, a.Price.ToString(), a.AmountInStock.ToString(), a.Colour }));
                listView1.Items.Add(items);


                //listView1.Items.Add(a.Price.ToString());
                //listView1.Items.Add(a.AmountInStock.ToString());
                //listView1.Items.Add(a.Colour);

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
