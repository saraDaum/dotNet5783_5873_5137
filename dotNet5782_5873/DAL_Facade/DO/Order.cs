using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DO;

///<summary>
/// Structure for ????
/// </summary>
public struct Order
{
    public int ID { get; set; }
    public int price { get; set; }
    public string category { get; set; }
    public string name { get; set; }
    public bool inStock { get; set; }
    public override string ToString() => $@"
    Product details:\n
    Product ID={ID}: {name}, 
    category - {category},
    Price: {price},
   	Amount in stock: {inStock}";


}


