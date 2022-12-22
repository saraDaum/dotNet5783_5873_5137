using System.Diagnostics;

<<<<<<< HEAD
public  interface IDal
=======
namespace DalApi;

public interface IDal
>>>>>>> 3156437c72a88d00c64cc98d35b70a23cca124cf
{
    public IOrder Order { get; }
    public IOrderItem OrderItem { get; }
    public IProduct Product { get; }
}
