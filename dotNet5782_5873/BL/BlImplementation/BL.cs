using BlApi;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    public  class BL : IBl
    {
        public IBoOrder Order => new BoOrder();

        public IOrderItem OrderItem =>  new BoOrderItem();

        public IProduct Product => new BoProduct();

        IOrder IBl.Order => throw new NotImplementedException();
    }
}
