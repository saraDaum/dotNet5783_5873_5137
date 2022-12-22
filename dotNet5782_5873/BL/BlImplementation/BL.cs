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
        public IBoOrder Order { get; } => new BoOrder();

        public IOrderItem OrderItem { get; } =>  new BoOrderItem();

        public IProduct Product { get; } => new BoProduct();

        public List<BO.Order> Orders= new 

        //IOrder IBl.Order => throw new NotImplementedException();
    }
}
