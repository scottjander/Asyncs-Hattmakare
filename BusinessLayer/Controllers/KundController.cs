using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using DataLayer.Repositories;

namespace BusinessLayer.Controllers
{
    public class KundController
    {
        public KundRepository KundRepository
        {
            get { return new KundRepository(); }
        }
        public CustomerRepository CustomerRepository
        {
            get { return new CustomerRepository(); }
        }

        public int HamtaIndex(int id)
        {
            int index = KundRepository.HamtaIndex(id);
            return index;
        }

        public void UpdateCustomerPoints(int customerId)
        {
            int orderCount = CustomerRepository.GetAmountOfOrdersThisYear(customerId);
            int customerPoints;
            switch (orderCount)
            {
                case 1:
                case 0:
                    customerPoints = 0;
                    break;
                case 2:
                    customerPoints = 2;
                    break;
                case 3:
                    customerPoints = 3;
                    break;
                case 4:
                    customerPoints = 4;
                    break;
                default:
                    customerPoints = 5;
                    break;
            }

            CustomerRepository.UpdateCustomerBonusPoints(customerId, customerPoints);

        }

        public List<Customer> GetAllCustomers()
        {
            return CustomerRepository.GetAllCustomers();
        }

        public Customer GetCustomerOnID(int id)
        {
            return CustomerRepository.GetCustomerOnID(id);
        }

    }
}
