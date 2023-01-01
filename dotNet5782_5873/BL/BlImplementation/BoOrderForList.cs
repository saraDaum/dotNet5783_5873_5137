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

internal class BoOrderForList:IBoOrderForList
{
    private IDal dal= new DalList();
    
   
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
