using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using DAL;
using DalApi;
using DO;

namespace BlImplementation;

internal class BoOrderItem:IOrderItem
{
    private IDal Dal= new DalList();

    public OrderItem GetOrderItem(int orderID, int productID)
    {
        throw new NotImplementedException();
    }
}
