using DO;

namespace DalApi;

public interface IOrderItem//:ICrud<OrderItem>
{
 public OrderItem GetByID(int orderID, int productID);
}
