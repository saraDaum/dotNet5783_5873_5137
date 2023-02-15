using DO;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    sealed internal class DalList : IDal
    {
        public static IDal Instance { get; } = new DalList();
        public IOrder Order => new DALOrder();
        public IOrderItem OrderItem => new DALOrderItem();
        public IProduct Product => new DALProduct();

        /*private DalList()
        {

        }*/

    }
}
