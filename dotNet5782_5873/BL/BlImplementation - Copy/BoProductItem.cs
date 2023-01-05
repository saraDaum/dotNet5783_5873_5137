using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using DAL;
using DalApi;

namespace BlImplementation;
internal class BoProductItem:IBoProductItem
{
    private IDal dal= new DalList();

    public int Add(BO.ProductItem entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
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
