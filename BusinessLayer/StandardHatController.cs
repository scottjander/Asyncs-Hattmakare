using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using DataLayer;

namespace BusinessLayer
{
    public class StandardHatController
    {
        public HatDbContext HatDbContext = new HatDbContext();
        //public CustomerRepository CustomerRepository;

        public StandardHatController()
        {
          //  CustomerRepository = new CustomerRepository();
        }




        public void OrderStandardHat(string price, string comment)
        {
            var hat = new Hat()
            {
               Price = price,
               Comment = comment,

            };
            HatDbContext.Hats.Add(hat);
            HatDbContext.SaveChanges(); 
        }




































    }
}
