using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using DalApi;
using AutoMapper;
using DAL;

namespace BlImplementation;

internal class BoOrder:BlApi.IBoOrder
{
    private IDal dal= new DalList();

    MapperConfiguration  oredrMapperConfig = new MapperConfiguration(cnf =>
         cnf.CreateMap<BO.BOOrder, DO.Order>()
         .ReverseMap()   );
    
    public int Add(BO.BOOrder MyBoOrder)
    {
      //  IAutoMapper autoMapper= oredrMapperConfig.cre
       //DO.Order doorder= 
        var DoOrder= DAL.DALOrder.Add(MyBoOrder);
      
     
    }
    public void Delete(int ID)
    {

    }
    
    public BO.BOOrder Get (int Id)
    {
     //var doOrder = Dal.Order.GetById(id);

    IAutoMapper mapper = myMapper.OrderMappingConfiguration.createMapper();

       // var boOrder = mapper.<BO.BOOrder, DO.Order>();

    return ; 
    }
    
    public void Update(BO.BOOrder MyBoOrder)
    {

    }
    

}
