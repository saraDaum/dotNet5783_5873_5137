using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using DalApi;
using AutoMapper;
using DAL;
using DO;

namespace BlImplementation;

internal class BoOrder : IBoOrder
{
    private IDal dal = new DalList();

    OurAutoMapper AutoMapper = new OurAutoMapper();


    public int Add(BO.Order MyBoOrder)
    {
        IMapper mapper = AutoMapper.OrderConfiguration.CreateMapper();
        DO.Order DoOrder = mapper.Map<DO.Order>(MyBoOrder);
        Add(DoOrder);
        return DoOrder.ID;
        
    }

    //Why it's insist me to implement this function??
    public int Add(Order entity)
    {
        dal.Order.Add(entity);
        return entity.ID;
    }

    public void Delete(int ID)
    {
        IMapper mapper = AutoMapper.OrderConfiguration.CreateMapper();
        DO.Order DoOrder= mapper.Map<DO.Order>(ID);
        dal.Order.Delete(ID);
    }

   
    public BO.Order GetById(int id)
    {
        IMapper mapper = AutoMapper.OrderConfiguration.CreateMapper();
        BO.Order myOrder = mapper.Map<BO.Order>(id);
        return myOrder;
    }

    public void Update(BO.Order MyBoOrder)
    {

    }

    public void Update(Order entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<BO.Order>  GetAll()
    {
        IMapper mapper= AutoMapper.OrderConfiguration.CreateMapper();
        IEnumerable<BO.Order> AllBoOrders= new List<BO.Order>();//A new list of BO.Order
        IEnumerable<DO.Order> AllDOOrders= dal.Order.GetAll(); //Get the DO.Order list
        foreach (Order order in AllDOOrders)
        {
        BO.Order myOrder= mapper.Map<BO.Order>(order);//Mapper
            AllBoOrders.Append(myOrder);
        }
        return AllBoOrders;
    }

  

    Order ICrud<Order>.GetById(int id)
    {
        throw new NotImplementedException();
    }

    IEnumerable<Order> ICrud<Order>.GetAll()
    {
        throw new NotImplementedException();
    }
}
