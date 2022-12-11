using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;

namespace BlImplementation;
internal class OrderItem:IOrderItem
{
    private IDal Dal= new Dallist();
     BO.OrderItem orderItem = new BO.OrderItem();
public int Add(BO.Order MyBOOrderItem)
    {

    }
    public int Delete (int ID)
    {
       // return Dal.Delete(ID);  
    }

    public BO.Order Get (int Id)
    {

    }
    public int Update (BO.OrderItem MyBoOrderItem)
    {

    }
}
