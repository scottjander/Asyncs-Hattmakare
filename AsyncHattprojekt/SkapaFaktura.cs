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
        public SkapaFaktura()
        {
            InitializeComponent();
            kundController = new KundController();
            orderController = new OrderController();
        }

        private void btnSkapaFaktura_Click(object sender, EventArgs e)
        {
            using (var context = new HatDbContext())
            {
                double summa = Convert.ToDouble(tbSummaAttBetala.Text);

                var nyfaktura = new Invoice() { SumToPay = summa, IsPaid = chbBetald.Checked };
                context.Invoices.Add(nyfaktura);
                context.SaveChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //int id = Convert.ToInt32(tbKundID.Text);
            //int index = kundController.HamtaIndex(id);

            //tbFaktureringsadress.Text = index.ToString();
            int id = Convert.ToInt32(tbOrderID.Text);
            int index = orderController.HamtaKundIdPaOrderId(id);

            tbFaktureringsadress.Text = index.ToString();


        } 
    }
}
