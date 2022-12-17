using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using DalApi;
using AutoMapper;
namespace BlImplementation;

internal class BoOrder:BlApi.IBoOrder
{
    private IDal dal= new Dallist();

    BLAutoMapper MyMapper= new BLAutoMapper();

   Order order = {
       CustomerName="Miryami Aizenbach",
       CustomerEmail="Miryam7.52002@gmail.com",
       CustomerAddress="Yesodot - Moshav shel parot",
       OrderDate= new DateTime(2022,12,10,0,0,0),
       ShipDate= new DateTime();
      deliverDate= OrderDate.AddDays(10)
        };
    

    public int Add(BO.Order MyBoOrder)
    {
       var DoOrder= DAL.DALOrder.Add(MyBoOrder);
      
     
    }
    public void Delete(int ID)
    {

    }
    
    public BO.Order Get (int Id)
    {
     var doOrder = Dal.Order.GetById(id);

    IAutoMapper mapper = myMapper.OrderMappingConfiguration.createMapper();
    
    var boOrder= mapper.Map<BO.Order>(doOrder)

    return boOrder; 
    }
    
    public void Update(BO.Order MyBoOrder)
    {

    }
    

}
