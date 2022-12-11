using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using DalApi;
namespace BlImplementation;

internal class Order:IOrder
{
    private IDal dal= new Dallist();

    BO.Order order = {
       CustomerName="Miryami Aizenbach",
       CustomerEmail="Miryam7.52002@gmail.com",
       CustomerAddress="Yesodot - Moshav shel parot",
       OrderDate= new DateTime(2022,12,10,0,0,0),
       ShipDate= new DateTime();
            

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

    }
    
    public void Update(BO.Order MyBoOrder)
    {

    }
    

}
