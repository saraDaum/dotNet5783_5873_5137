using BlApi;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    sealed public class BL : IBl
    {
        public IBoCart Cart => new BoCart();

        public IBoOrder Order => new BoOrder();

        public IBoOrderForList OrderForList => new BoOrderForList();

        public IBoOrderItem OrderItem => new BoOrderItem();

        public IBoOrderTracking OrderTracking => throw new NotImplementedException();

        public IBoProduct Product => throw new NotImplementedException();

        public IBoProductItem ProductItem => throw new NotImplementedException();
    }
}


