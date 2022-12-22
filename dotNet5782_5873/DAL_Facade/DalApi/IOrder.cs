using DO;
<<<<<<< HEAD

namespace DalApi;

public  interface  IOrder :ICrud<Order>
=======
namespace DalApi;

public interface IOrder:ICrud<Order>
>>>>>>> 3156437c72a88d00c64cc98d35b70a23cca124cf
{
    /// <summary>
    /// This functions are an auxiliary functions
    /// It get all required details from the customer and sends them to the matched function
    /// </summary>
    void Add();
    void Delete();
   
}

