using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using BO;
using DAL;
using DalApi;
using DO;

namespace BlImplementation;

internal class BoOrderTracking:IBoOrderTracking
{
    private IDal dal= new DalList();

    public bool ChangeOrderStatus(BO.OrderTracking order ,BO.OrderStatus status)
    {
        order.Status = status;
       
        //{
        //    if (item.orderId == orderId)//נמצא את ההזמנה שהאי די שלה נשלח
        //    {
        //        Console.WriteLine(item);

        //        return true;
        //    } 
        }
                                      
                                      //נשנה את הסטטוס שלה
        //נחזיר אם הצלחנו
        return true;
    }
}
