using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DalList
    {
        public DalApi.ICrud<Order> order => new DALOrder();

        public DalApi.ICrud<OrderItem> OrderItem => new DALOrderItem();

        public DalApi.ICrud<Product> Product => new DALProduct();




    }
}
