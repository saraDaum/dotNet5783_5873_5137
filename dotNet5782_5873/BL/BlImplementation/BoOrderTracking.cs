using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
namespace BlImplementation;

internal class BoOrderTracking:IOrderTracking
{
    private IDal dal= new Dallist();

    BO.OrderTracking orderTracking
    {


    }
    public int Add (BO.OrderTracking MyBOOrderTracking)
    {
       // return dal.Add (MyBOOrderTracking);    
    }

    public int Delete (int ID)
    {
       // return dal.Delete (ID);
    } 
    public BO.OrderTracking Get (int Id )
    {

    }
    public int Uptate (BO.OrderTracking MyBoOrderTracking) 
    {
    
    }
     
}
