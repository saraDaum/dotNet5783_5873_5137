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
    public IBoOrder Order { get;  }
    public IBoOrderForList OrderForList { get; }  
    public IBoOrderItem OrderItem { get; }
    public IBoOrderTracking OrderTracking { get; }     
    public IBoProduct Product { get; }
    public IBoProductItem ProductItem { get; }   




}
