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
using DataLayer.Models;

namespace AsyncHattprojekt
{
    public partial class StandardHatOrder : Form
    {
        public HatDbContext HatDbContext = new HatDbContext();
        public StandardHatController standardHatController = new StandardHatController();
        public int orderID;
        public int hatID;
        public Testklassen testklassen = new Testklassen();
        public NewUI parent { get; set; }

        public StandardHatOrder(int orderID)
        {
            InitializeComponent();
            //testklassen.testmetoden3();
            FillListView();
            this.orderID = orderID;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems[0] != null) {
                 var hat = listView1.SelectedItems[0];
            hatID = Convert.ToInt32(hat.SubItems[3].Text);
            standardHatController.OrderStandardHat(orderID, hatID);
            //parent.addTolistViewHats();
            parent.UpdateOrder();
            this.Close();
            }
            else {
                MessageBox.Show("Var god välj en hatt.");
            }


        }

        private void prisTxtBx_TextChanged(object sender, EventArgs e)
        {

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listView1.SelectedItems.Count > 0) {
            //    hatID = Convert.ToInt32(listView1.SelectedItems[0].Text);
            //    textBox1.Text = listView1.SelectedItems[0].SubItems[2].Text + "\t " +
            //                              listView1.SelectedItems[0].SubItems[3].Text;
            //}
        }
        private void FillListView()
        {
            listView1.Items.Clear();
            //foreach (Hat hat in standardHatController.GetUniqueHats()) {
            //    ListViewItem lvi = new ListViewItem(hat.Id.ToString());
            //    lvi.SubItems.Add(hat.Price.ToString());
            //    lvi.SubItems.Add(hat.size.ToString());
            //    lvi.SubItems.Add(hat.color);
            //    listView1.Items.Add(lvi);
            //}
            foreach (Hat hat in standardHatController.GetUniqueHats()) {

                ListViewItem items = new ListViewItem(new[] { hat.size.ToString(), hat.color, hat.Price.ToString(), hat.Id.ToString() });
                listView1.Items.Add(items);
            }
        }
        //private void btnOkaLager_Click(object sender, EventArgs e)
        //{


        //    double amount = Convert.ToDouble(txtMangd.Text);
        //    var fabric = listView1.SelectedItems[0];
        //    var id = Convert.ToInt32(fabric.SubItems[4].Text);

        //    fabricStockController.IncreaseAmountInStorage(amount, id);
        //    FyllMaterial();


        //}
    }
}
