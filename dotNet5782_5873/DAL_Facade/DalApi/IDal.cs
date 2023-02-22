using System.Diagnostics;

namespace DalApi;

public interface IDal
{
    public IOrder Order { get; }
    public IOrderItem OrderItem { get; }
    public IProduct Product { get; }

}
