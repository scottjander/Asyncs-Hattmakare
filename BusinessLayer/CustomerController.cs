using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Repositories;
using DataLayer.Models;
using DataLayer;

namespace BusinessLayer
{
    public class CustomerController
    {
        public HatDbContext HatDbContext = new HatDbContext();
        public CustomerRepository CustomerRepository;
        public CustomerController()
        {
            CustomerRepository = new CustomerRepository();
        }
        public void kundReg(string firstName, string lastName, int phone, string email, string address)
        {
            var customer = new Customer()
            {
                FirstName = firstName,
                LastName = lastName,
                Phone = phone,
                Email = email,
                Address = address,


            };
            HatDbContext.Customers.Add(customer);
            HatDbContext.SaveChanges();
        }
    }
}
