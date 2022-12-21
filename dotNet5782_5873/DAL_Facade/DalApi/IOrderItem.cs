using DO;

namespace DalApi;

public interface IOrderItem:ICrud<OrderItem>
{
  OrderItem GetByID(int orderID, int productID);
    /// <summary>
    /// This functions are an auxiliary functions
    /// It get all required details from the customer and sends them to the matched function
    /// </summary>
    void Delete();
    void Update();
    
}
