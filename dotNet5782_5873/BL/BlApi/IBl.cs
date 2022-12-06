using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi;

public interface IBl
{
    /// <summary>
    /// Order interface implementation
    /// </summary>
    public IOrder Order { get;  }

    /// <summary>
    /// OrderItem interface implementation
    /// </summary>
    public IOrderItem OrderItem { get; }

    /// <summary>
    /// Product interface implementation
    /// </summary>
    public IProduct Product { get; }



}
