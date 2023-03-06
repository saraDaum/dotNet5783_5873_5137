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
    public void useLinqToObjectQuery(List<BO.OrderTracking> initList)
    {
        var v = from item in initList
                let average = item.ID
                where average < 80 //Only to use all options in quries... 😊😊
                orderby item.ID descending
                select new
                { id = item.ID, Status = item.Status, Average = average };
        var v2 = from item in initList
                 let average = item.ID
                 where average < 80
                 orderby item.ID descending
                 group item by item.ID;
               
    }

}
