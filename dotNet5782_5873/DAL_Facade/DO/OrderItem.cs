using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO;

///<summary>
/// Structure for OrderItem:
/// Every OrderItem have the details of the item that order. Price, amount ect.
/// </summary>
public struct OrderItem
{
    public int ProductID { get; set; }
    public int OrderID { get; set; }
    public double ProductPrice { get; set; }
    public int Amount { get; set; }


}
