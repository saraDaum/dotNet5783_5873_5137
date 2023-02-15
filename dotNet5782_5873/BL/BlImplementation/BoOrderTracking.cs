using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using BO;
using DalApi;
using DO;

namespace BlImplementation;

internal class BoOrderTracking : IBoOrderTracking
{
    IDal? dal = DalApi.Factory.Get();
    //We don't implement it yet because we don't know what to do.
    //We wait to see the rest of the instructions.


    //Mirymi, I don't know what do you want to do here!!!
    //check input!!
    public bool ChangeOrderStatus(BO.OrderTracking order, BO.OrderStatus status)
    {
        order.Status = status;
        if (order.Status == status)
            return true;
        else
            return false;
    }

}
