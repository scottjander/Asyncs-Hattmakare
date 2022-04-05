using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DateFinished { get; set; }
        public string Comment { get; set; }
        public int TotalPrice { get; set; }

        //Alla hattar som skapas binds till en order. Kanske är problematisk för att det betyder att vi måste skapa en order
        // innan vi börjar skapa hattar?
        // Eller så kanske det fungerar bra, man skapar en order bunden till en kund först
        // och sen börjar man klicka in vad ordern faktiskt ska bestå av.
        public ICollection<Hat> Hats { get; set; }
        public Customer Customer { get; set; }
    }
}
