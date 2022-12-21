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
    {/*
        IMapper mapper = OurAutoMapper.OrderConfiguration.CreateMapper();
        DO.Order doOrder = mapper.Map<DO.Order>(dal);
        Dal.Order.Add(doOrder);
        return doOrder.ID;
        */

        //  IAutoMapper autoMapper= oredrMapperConfig.cre
        //DO.Order doorder= 
        // var DoOrder= DAL.DALOrder.Add(MyBoOrder);
        return 0;

    }

    public int Add(Order entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(int ID)
    {

    }

    public BO.Order Get(int Id)
    {
        //var doOrder = Dal.Order.GetById(id);

        //   IAutoMapper mapper = myMapper.OrderMappingConfiguration.createMapper();

        // var boOrder = mapper.<BO.BOOrder, DO.Order>();
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

    public void Update(BO.Order MyBoOrder)
    {

    }

    public void Update(Order entity)
    {
        throw new NotImplementedException();
    }
}
