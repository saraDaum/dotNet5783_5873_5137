using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using DalApi;

namespace BlImplementation;
internal class BoProductItem:IBoProductItem
{
    IDal? dal = DalApi.Factory.Get();

    //We don't implement it yet because we don't know what to do.
    //We wait to see the rest of the instructions.

    public int Add(BO.ProductItem entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable Get(Func<object, bool> value)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<BO.ProductItem> GetAll()
    {
        throw new NotImplementedException();
    }

    public BO.ProductItem GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(BO.ProductItem entity)
    {
        throw new NotImplementedException();
    }
}
