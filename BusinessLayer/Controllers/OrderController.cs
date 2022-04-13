using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer.Controllers
{
    public class OrderController
    {
        public OrderRepository OrderRepository
        {
            get { return new OrderRepository(); }
        }

        
        //     public int HamtaKundIdPaOrderId(int id)
        //{
        //    int index = OrderRepository.HamtaKundIdPaOrderId(id);
        //    return index;
        //}



    }
}
