using DataLayer.Models;
using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Controllers
{
    public class FakturaController
    {

        private FakturaRepository FakturaRepository = new FakturaRepository();

        public int HamtaKundIdPaOrderId(int id)
        {
            int index = FakturaRepository.HamtaKundIdPaOrderId(id);
            return index;
        }
        public Order HamtaOrderObjektPaOrderId(int id)
        {
            var order = FakturaRepository.HamtaOrderObjekt(id);
            return order;
        }

        public string HamtaForNamn(int id)
        {
            string fornamn = FakturaRepository.HamtaForNamn(id);
            return fornamn;
        }
        public string HamtaEfterNamn(int id)
        {
            string efternamn = FakturaRepository.HamtaEfterNamn(id);
            return efternamn;
        }

        public string HamtaAdressPaKundID(int id)
        {
            string adress = FakturaRepository.HamtaAdressPaKundID(id);
            return adress;
        }
        public double HamtaTotalSumma(int id)
        {
            double summa = FakturaRepository.HamtaTotalSumma(id);
            return summa;
        }
        public Address HamtaAdressObjekt(int id)
        {
            var kund = HamtaKundIdPaOrderId(id);
            var adress = FakturaRepository.HamtaAdressObjekt(kund);
            return adress;
        }
        public void SkapaFaktura(bool betald, int orderid, double summa)
        {
            var adress = HamtaAdressObjekt(orderid);
            var order = HamtaOrderObjektPaOrderId(orderid);
            FakturaRepository.SkapaFaktura(adress, order, summa, betald);
        }
    }
}
