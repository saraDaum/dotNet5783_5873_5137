using DO;

namespace DalApi;

internal interface IOrderItem
{
 public OrderItem GetOrderItem(int orderID, int productID);
}
