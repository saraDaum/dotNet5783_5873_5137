using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    internal class Class1 { 
 public int Barcode { get;}
public string ProductName { get;  }
public Category Category { get;  }
public double ProductPrice { get;  }
public int InStock { get;  }



   public override string ToString() => $@"
    Product details:\n
    {Barcode}- {ProductName}, 
    category: {Category},
    Price: {ProductPrice},
   	Amount in stock: {InStock}";
    }
}
