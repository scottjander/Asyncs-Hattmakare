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
        public Customer RegisterCustomer(string firstName, string lastName, string phone, string email, Address address, string comment)
        {
            try
            {
                var customer = new Customer()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Phone = phone,
                    Email = email,
                    Address = address,
                    Comment = comment,
                };

                var a = address;

                HatDbContext.Addresses.Add(a);
                HatDbContext.Customers.Add(customer);
                HatDbContext.SaveChanges();
                return customer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new Customer();
            }
        }
    }
}
