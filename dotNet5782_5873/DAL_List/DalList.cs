using DO;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    sealed public class DalList //: IDal
    //public class DalList
    {
        public static readonly object DALOrder;

        public static object DALOrderItem { get; set; }
        public static object DALProduct { get; set; }

        public DalApi.ICrud<Order> order => new DALOrder();

        public DalApi.ICrud<OrderItem> OrderItem => new DALOrderItem();

        public DalApi.ICrud<Product> Product => new DALProduct();




    }
}
