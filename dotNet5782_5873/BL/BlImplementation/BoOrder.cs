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
using System.Reflection.Metadata.Ecma335;

namespace BlImplementation;

internal class BoOrder : IBoOrder
{
    private IDal dal = new DalList();

    OurAutoMapper AutoMapper = new OurAutoMapper();

    /// <summary>
    /// This function gets an order object and create a new one.
    /// </summary>
    /// <param name="MyBoOrder"></param>
    /// <returns></returns>
    public int Add(BO.Order MyBoOrder)
    {
        IMapper mapper = AutoMapper.OrderConfiguration.CreateMapper();
        DO.Order DoOrder = mapper.Map<DO.Order>(MyBoOrder);
        int ID = dal.Order.Add(DoOrder);
        return ID;

    }

    /// <summary>
    /// This function gets an ID and delete the match Order.
    /// </summary>
    /// <param name="ID"></param>
    public void Delete(int ID)
    {
        dal.Order.Delete(ID);
          }

    /// <summary>
    /// This function gets an ID and returns the match item.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public BO.Order GetById(int id)
    {
        IMapper mapper = AutoMapper.OrderConfiguration.CreateMapper();
        IEnumerable<DO.Order>? allDoOrder = dal.Order.Get(item=> item.ID==item.ID);//Stupid condition because I want it return all list
        BO.Order myBoOrder = new BO.Order();
        DO.Order myOrder = allDoOrder.First(order => order.ID == id);
        //Can't check if it's NULL
        myBoOrder = mapper.Map<BO.Order>(myOrder);
        return myBoOrder;
    }

    /// <summary>
    /// This function gets an order object (BO) and update it in DO.
    /// </summary>
    /// <param name="MyBoOrder"></param>
    public void Update(BO.Order MyBoOrder)
    {
        IMapper mapper = AutoMapper.OrderConfiguration.CreateMapper();
        DO.Order DoOrder = mapper.Map<DO.Order>(MyBoOrder);
        dal.Order.Update(DoOrder);
    }

    /// <summary>
    /// This function returns all the orders.
    /// </summary>
    /// <returns></returns>
    public IEnumerable<BO.Order> GetAll()
    {
        IMapper mapper = AutoMapper.OrderConfiguration.CreateMapper();
        IEnumerable<BO.Order> AllBoOrders = new List<BO.Order>();//A new list of BO.Order
        IEnumerable<DO.Order>? AllDOOrders = dal.Order.Get(item => item.ID == item.ID);//Stupid condition because I want it return all list
        if (AllDOOrders.Count() > 0)
        {
            foreach (DO.Order order in AllDOOrders)
            {
                BO.Order myOrder = mapper.Map<BO.Order>(order);//Mapper
                AllBoOrders.Append(myOrder);
            }
        }
        return AllBoOrders;
    }

    public BO.Order GetAnObject(Predicate<BO.Order> myDelegate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<BO.Order>? Get(Func<BO.Order, bool>? deligate)
    {
        throw new NotImplementedException();
    }
}
