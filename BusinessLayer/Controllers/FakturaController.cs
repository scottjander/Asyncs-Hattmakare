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
        public FakturaRepository FakturaRepository
        {
            get { return new FakturaRepository(); }
        }

        public int HamtaKundIdPaOrderId(int id)
        {
            int index = FakturaRepository.HamtaKundIdPaOrderId(id);
            return index;
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
        public int HamtaTotalSumma(int id)
        {
            int summa = FakturaRepository.HamtaTotalSumma(id);
            return summa;
        }

    }
}
