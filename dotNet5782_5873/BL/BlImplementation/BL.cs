using BlApi;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    sealed public class BL:IBl
    {
            public IBoOrder Order => new BoOrder();

            public IBoOrderItem OrderItem => new BoOrderItem();

            public IBoProduct Product => new BoProduct();

            public List<BO.Order> Orders = new List<BO.Order>();

        }
    }

}
}
