using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using BO;
using DalApi;

namespace BlImplementation;

internal class BoOrderForList:IBoOrderForList
{
    IDal? dal = DalApi.Factory.Get();

    //We don't implement it yet because we don't know what to do.
    //We wait to see the rest of the instructions.

    public int Add(Order entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Order> GetAll()
    {
        throw new NotImplementedException();
    }

    public Order GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(Order entity)
    {
        throw new NotImplementedException();
    }

    // להמיר
    // ואז
    // Dal.Order.Add(DO.Order O)


}
