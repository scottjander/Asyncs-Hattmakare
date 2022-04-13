using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataLayer.Repositories
{
    public class AnvandareRepository
    {

        public List<string> GetAllNames()
        {
           using (var context = new HatDbContext())
            {
                var allaAnstallda = context.Employees.ToList();
                List<string> names = new List<string>();
                foreach(var anstalld in allaAnstallda)
                {
                    names.Add(anstalld.Name);
                }
                return names;
            }
        }

        public void SkapaNyAnvandare(string namn)
        {
            using (var context = new HatDbContext())
            {
                var anvandare = new Employees()
                {
                    Name = namn,
                };
                context.Employees.Add(anvandare);
                context.SaveChanges();
            }
        }


    }
}
