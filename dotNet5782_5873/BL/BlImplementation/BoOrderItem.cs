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

internal class BoOrderItem:IBoOrderItem
{
    private IDal Dal= new DalList();

    public int Add(BO.OrderItem entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<BO.OrderItem> GetAll()
    {
        throw new NotImplementedException();
    }

    public BO.OrderItem GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(BO.OrderItem entity)
    {
        throw new NotImplementedException();
    }
}
