using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO;

///<summary>
/// Structure for Order
/// Every order have the details of the transaction. Cusomer details, time of order, shiping time ect.
/// </summary>
public struct OrderItem
{
    public int ProductID { get; set; }
    public int OrderID { get; set; }
    public double ProductPrice { get; set; }
    public int Amount { get; set; }


}
