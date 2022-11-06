﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DO;

///<summary>
/// Structure for Order:
/// Every order have the details of the transaction. Cusomer details, time of order, shiping time ect.
/// </summary>
public struct Order
{
    public int ID { get; set; }
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public string CustomerAddress { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime ShipDate { get; set; }
    public DateTime DeliveryDate { get; set; }
    public override string ToString() => $@"
    Product details:\n
    Product barkode={Barcode}: {ProductName}, 
    category: {Category},
    Price: {Price},
   	Amount in stock: {InStock}";


}


