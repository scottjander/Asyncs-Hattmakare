using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncHattprojekt
{
    public partial class FärdigFaktura : Form
    {
        ShippingLabelController shippingLabelController;
        public FärdigFaktura()
        {
            shippingLabelController = new ShippingLabelController();        
            InitializeComponent();
           
            lblOrderNumret.Text = SkapaFaktura.OrderID;
            lblNamnet.Text = SkapaFaktura.ForNamn + " " + SkapaFaktura.EfterNamn;
            lblAdressen.Text = SkapaFaktura.FaktureringsAdress;
            lblSumman.Text = SkapaFaktura.SummaAttBetala;

            shippingLabelController.printDocument.PrintPage += new PrintPageEventHandler(shippingLabelController.printDocument_PrintPage);
        }

        private void btnSkrivUt_Click(object sender, EventArgs e)
        {
            btnSkrivUt.Hide();
            shippingLabelController.PrintLabel(this);
           
        }
    }
}
