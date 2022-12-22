using DO;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
<<<<<<< HEAD
    sealed public class DalList :IDal 
     {
        public IOrder order => new DALOrder();
=======
    sealed public  class DalList : IDal
    //public class DalList
    {
        
        //public static readonly object DALOrder;
        //public static object DALOrderItem { get; set; }
        // public static object DALProduct { get; set; }

        public IOrder Order => new DALOrder() ;
        public IOrderItem OrderItem => new DALOrderItem() ;
        public IProduct Product => new DALProduct();
        //public static IDal instance { get; } = new DalList();
>>>>>>> 3156437c72a88d00c64cc98d35b70a23cca124cf

        public IOrder Order => throw new NotImplementedException();

        public IOrderItem OrderItem => new DALOrderItem();

        public IProduct Product => new DALProduct();
    }
}
