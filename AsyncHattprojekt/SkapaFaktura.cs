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
        public SkapaFaktura()
        {
            InitializeComponent();
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
    }
}
