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
    public partial class StartPage : Form
    {
        private OrderControllerScottRobin orderController = new OrderControllerScottRobin();
        public StartPage()
        {
            InitializeComponent();
            //var testklassen = new Testklassen();
            //testklassen.FillHat();
            lblNamn.Text = InitialPage.username;
        }

        private void btnBestall_Click(object sender, EventArgs e)
        {


            this.Hide();
            CreateOrder f = new CreateOrder();
            f.ShowDialog();
            f = null;
            this.Show();
        }

        private void btnSeOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Testform f = new Testform();
            f.ShowDialog();
            f = null;
            this.Show();
        }

        private void btnLagerStatus_Click(object sender, EventArgs e)
        {
            this.Hide();
            Testform f = new Testform();
            f.ShowDialog();
            f = null;
            this.Show();
        }

        private void btnSeKundRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Testform f = new Testform();
            SkapaFaktura f = new SkapaFaktura();
            f.ShowDialog();
            f = null;
            this.Show();
        }

        private void btnLoggaUt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OnFormClose(object sender, FormClosedEventArgs e)
        { 
            Application.Exit();
        }

        private void lblNamn_Click(object sender, EventArgs e)
        {

        }
    }
}
