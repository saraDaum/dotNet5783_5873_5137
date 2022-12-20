using BlApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    public  class BL : IBl
    {
        public IOrder Order => new BlImplementation.BoOrder();

        public IOrderItem OrderItem =>  new BlImplementation.BoOrderItem();

        public IProduct Product =>  new BlImplementation.BoProduct();
    }
}
