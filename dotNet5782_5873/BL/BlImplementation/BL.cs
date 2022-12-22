using BlApi;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{

    public class BL : IBl
    {
        public IOrder Order => new BlImplementation.Order();

        public IOrderItem OrderItem =>  new BlImplementation.OrderItem();

        public List<BO.Order> Orders= new 

        //IOrder IBl.Order => throw new NotImplementedException();
    }
}
