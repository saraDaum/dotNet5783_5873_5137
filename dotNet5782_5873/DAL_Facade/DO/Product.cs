using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO;

public struct Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public double ProductPrice { get; set; }
    public Category Category { get; set; }
    public int InStock { get; set; }

}
