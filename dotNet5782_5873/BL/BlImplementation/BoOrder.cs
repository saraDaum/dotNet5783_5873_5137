using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using DalApi;
using AutoMapper;
using DO;
using System.Reflection.Metadata.Ecma335;
using BO;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace BlImplementation;

internal class BoOrder : IBoOrder
{
    IDal? dal = DalApi.Factory.Get();

    OurAutoMapper AutoMapper = new OurAutoMapper();

    IEnumerable<BO.Order> AllBoOrders = new List<BO.Order>();//A new list of BO.Order


    private IEnumerable<BO.Order> getOrderslist()
    {
        IMapper mapper = AutoMapper.OrderConfiguration.CreateMapper();
        IEnumerable<DO.Order>? AllDoOrders = dal.Order.Get(item => item.ID == item.ID);//Stupid condition because I want it return all list
        if (AllDoOrders.Count() > 0)
        {
            IEnumerable<BO.Order> AllBoOrders = AllDoOrders.Select(item => mapper.Map<BO.Order>(item));

        }
        return AllBoOrders;
    }

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
            IEnumerable<DO.Order>? DoOrder = dal.Order.Get(item => item.ID == id);
            BO.Order myBoOrder = new BO.Order();
            myBoOrder = mapper.Map<BO.Order>(DoOrder);
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
        return AllBoOrders = getOrderslist();
    }

    public BO.Order GetAnObject(Predicate<BO.Order> myDelegate)
    {
        throw new NotImplementedException();
    }

    /*  public IEnumerable<BO.Order>? Get(Func<BO.Order, bool>? deligate)
      {

          AllBoOrders = getOrderslist();
          IEnumerable<DO.Order>? AllDoOrders = dal.Order.Get(item => item.ID == item.ID);//Stupid condition because I want it return all list
          if (AllDoOrders.Count() > 0)
          {

          }
          return AllBoOrders;
      }*/

    //
    public IEnumerable<BO.Order>? Get(Func<BO.Order, bool>? deligate)
    {
        if (deligate != null)
        {
            IEnumerable<BO.Order> orders = getOrderslist();
            return orders.Where(deligate);
        }
        return null;
    }

    public void Update(Action order)
    {
        throw new NotImplementedException();
    }

    public int CreateOrder(Cart cart)
    {
        IBl bl = BlApi.Factory.Get();
        BO.Order order = new BO.Order(); //ליצר הזמנה חדשה שהפרטים האישיים תואמים לפרטים שבסל
        order.CustomerName = cart.CustomerName;
        order.CustomerEmail = cart.CustomerEmail;
        order.CustomerAddress = cart.CustomerAddress;
        order.OrderDate = DateTime.Now;
        order.ShipDate = DateTime.Now;

        Add(order);
        //לשלוח את ההזמנה לפונקציה ADD

        foreach (BO.ProductItem item in cart.ItemsInCart)                         //ליצר OrderItems מתתוך הרשימה שבסל
        {
            bl.OrderItem.Add(create(item, order.ID));

        }
        //כל OrderItem לשלוח לפונקציה ADD של ORDER-ITEM

        return (order.ID);
    }

    public BO.OrderItem create(BO.ProductItem entity, int id)
    {
        BO.OrderItem newEntity = new();
        newEntity.ProductID = entity.Barcode;
        newEntity.OrderID = id;
        newEntity.Amount = entity.Amount;
        newEntity.ProductPrice = entity.Price;
        return newEntity;
    }

   
    /*public BO.Order GetAnObject(Predicate<BO.Order> myDelegate)
{
   return OrderList.Find(myDelegate);
}*/
    //
}
