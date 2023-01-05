using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BlApi;

public interface IBoOrderTracking
{
    /// <summary>
    /// change the order status (for menager)
    /// </summary>
    /// <param name="orderId">the order id</param>
    /// <param name="status">the status to replace</param>
    /// <returns>succese</returns>
    bool ChangeOrderStatus(int orderId, BO.OrderStatus status);

}
