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
    private IDal Dal= new Dallist();

    BO.Order order = new BO.Order();
    
    public int Add(BO.Order MyBOOrder)
    {
       
     
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
