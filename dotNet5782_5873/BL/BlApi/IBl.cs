using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi;

public interface IBl
{
    public IBoCart Cart { get; }
    public IOrder Order { get;  }
    public IBoOrderForList OrderForList { get; }  
    public IOrderItem OrderItem { get; }
    public IBoOrderTracking OrderTracking { get; }     
    public IProduct Product { get; }
   public IBoProductItem ProductItem { get; }   




}
