using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using DalApi;
namespace BlImplementation;

internal class Order:IOrder
{
    private IDal Dal= new Dallist();

    BO.Order order = new BO.Order();
    
    public bool Add(BO.Order MyBOOrder)
    {
        DO.Order MyOrder=MyBOOrder;
      
        return true;
    }
}
