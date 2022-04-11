using BusinessLayer.Controllers;
using DataLayer;
using DataLayer.Models;
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
    public partial class SkapaFaktura : Form
    {
        KundController kundController;
        OrderController orderController;
        FakturaController fakturaController;
        public SkapaFaktura()
        {
            InitializeComponent();
            kundController = new KundController();
            orderController = new OrderController();
            fakturaController = new FakturaController();
        }

        private void btnSkapaFaktura_Click(object sender, EventArgs e)
        {
            using (var context = new HatDbContext())
            {
                double summa = Convert.ToDouble(tbSummaAttBetala.Text);
              
                int adress = Convert.ToInt32(tbOrderID.Text);
                string hamtaadress = fakturaController.HamtaAdressPaKundID(adress);

                var nyfaktura = new Invoice() { SumToPay = summa, IsPaid = chbBetald.Checked, };
                context.Invoices.Add(nyfaktura);
                context.SaveChanges();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //int id = Convert.ToInt32(tbKundID.Text);
            //int index = kundController.HamtaIndex(id);

            //tbFaktureringsadress.Text = index.ToString();

            //int id = Convert.ToInt32(tbOrderID.Text);
            //int index = fakturaController.HamtaKundIdPaOrderId(id);

            //tbFaktureringsadress.Text = index.ToString();


            int fornamn = Convert.ToInt32(tbOrderID.Text);
            string hamtafornamn = fakturaController.HamtaForNamn(fornamn);
            tbForNamn.Text = hamtafornamn.ToString();
           
            int efternamn = Convert.ToInt32(tbOrderID.Text);
            string hamtaefternamn = fakturaController.HamtaEfterNamn(efternamn);
            tbEfterNamn.Text = hamtaefternamn.ToString();

            int adress = Convert.ToInt32(tbOrderID.Text);
            string hamtaadress = fakturaController.HamtaAdressPaKundID(adress);
            tbFaktureringsadress.Text = hamtaadress.ToString();

            int summa = Convert.ToInt32(tbOrderID.Text);
            int hamtasumma = fakturaController.HamtaTotalSumma(summa);
            tbSummaAttBetala.Text = hamtasumma.ToString();
            
        }

        private void tbKundID_TextChanged(object sender, EventArgs e)
        {

        }


        public static string OrderID = "";
        public static string ForNamn = "";
        public static string EfterNamn = "";
        public static string FaktureringsAdress = "";
        public static string SummaAttBetala = "";
        private void btnVisaFärdigFaktura_Click(object sender, EventArgs e)
        {

            OrderID = tbOrderID.Text;
            ForNamn = tbForNamn.Text;
            EfterNamn = tbEfterNamn.Text;
            FaktureringsAdress = tbFaktureringsadress.Text;
            SummaAttBetala = tbSummaAttBetala.Text;

            this.Hide();
            FärdigFaktura f = new FärdigFaktura();
            f.ShowDialog();
            f = null;
            this.Show();
        }
    }
}
