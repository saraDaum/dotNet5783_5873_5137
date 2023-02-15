using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BlApi;
using DalApi;
using DO;

namespace BlImplementation;

internal class BoOrderItem : IBoOrderItem
{
    IDal? dal = DalApi.Factory.Get();
    OurAutoMapper AutoMapper = new OurAutoMapper();
    public int Add(BO.OrderItem BoEntity)
    {
        IMapper mapper = AutoMapper.OrderItemConfiguration.CreateMapper();
        DO.OrderItem DoOrderItem = mapper.Map<DO.OrderItem>(BoEntity);
        int ID = dal.OrderItem.Add(DoOrderItem);
        return ID;
    }

    public void Delete(int id)
    {
        dal.OrderItem.Delete(id);
    }

    public IEnumerable<BO.OrderItem>? Get(Func<BO.OrderItem, bool>? deligate)
    {
        IMapper mapper = AutoMapper.OrderItemConfiguration.CreateMapper();
        IEnumerable<BO.OrderItem> AllBoOrderItems = new List<BO.OrderItem>();//A new list of BO.Order
        IEnumerable<DO.OrderItem> AllDOOrderItems = dal.OrderItem.Get(item=>item.autoID==item.autoID); //Get the DO.Order list
        foreach (OrderItem currentOrderItem in AllDOOrderItems)
        {
            BO.OrderItem myOrderItem = mapper.Map<BO.OrderItem>(currentOrderItem);//Mapper
            AllBoOrderItems.Append(myOrderItem);
        }
        return AllBoOrderItems;
    }

    public IEnumerable<BO.OrderItem> GetAll()
    {
        IMapper mapper = AutoMapper.OrderItemConfiguration.CreateMapper();
        IEnumerable<BO.OrderItem> AllBoOrderItems = new List<BO.OrderItem>();//A new list of BO.Order
        IEnumerable<DO.OrderItem> AllDOOrderItems = dal.OrderItem.GetAll(); //Get the DO.Order list
        foreach (OrderItem currentOrderItem in AllDOOrderItems)
        {
            BO.OrderItem myOrderItem = mapper.Map<BO.OrderItem>(currentOrderItem);//Mapper
            AllBoOrderItems.Append(myOrderItem);
        }
        return AllBoOrderItems;
    }

    public BO.OrderItem GetAnObject(Predicate<BO.OrderItem> myDelegate)
    {
        throw new NotImplementedException();
    }

    public BO.OrderItem GetById(int id, int orderId)
    {
        IMapper mapper = AutoMapper.OrderConfiguration.CreateMapper();
        BO.OrderItem myOrderItem = mapper.Map<BO.OrderItem>(dal.OrderItem.Get(item=>item.autoID==id));
        return myOrderItem;
    }


    public void Update(BO.OrderItem BoEntity)
    {
        IMapper mapper = AutoMapper.OrderItemConfiguration.CreateMapper();
        DO.OrderItem DoOrderItem = mapper.Map<DO.OrderItem>(BoEntity);
        dal.OrderItem.Update(DoOrderItem);
    }

   

}
