using DO;

<<<<<<< HEAD
public  class IOrderItem
=======
namespace DalApi;

public interface IOrderItem:ICrud<OrderItem>
>>>>>>> 3156437c72a88d00c64cc98d35b70a23cca124cf
{
  OrderItem GetByID(int orderID, int productID);
    /// <summary>
    /// This functions are an auxiliary functions
    /// It get all required details from the customer and sends them to the matched function
    /// </summary>
    void Delete();
    void Update();
    
}
