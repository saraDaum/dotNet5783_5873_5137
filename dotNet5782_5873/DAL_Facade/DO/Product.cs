using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO;

///<summary>
/// Structure for Product:
/// Every product have the details like: product name, product price, product amount in stock ect.
/// </summary>
public struct Product
{
    public int Barcode { get; set; }
    public string ProductName { get; set; }
    public Category Category { get; set; }
    public double ProductPrice { get; set; }
    public int InStock { get; set; }

}
