using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using BO;
using DAL;
using DalApi;

namespace BlImplementation;

internal class BoOrderTracking:IBoOrderTracking
{
    private IDal dal= new DalList();

    public int Add(OrderTracking entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<OrderTracking> GetAll()
    {
        throw new NotImplementedException();
    }

    public OrderTracking GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(OrderTracking entity)
    {
        throw new NotImplementedException();
    }
}
