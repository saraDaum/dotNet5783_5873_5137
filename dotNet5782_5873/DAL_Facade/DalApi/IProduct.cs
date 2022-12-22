using DO;
<<<<<<< HEAD

namespace DalApi;

public  interface  IProduct:ICrud<Product>
=======
namespace DalApi;

public interface IProduct:ICrud<Product>
>>>>>>> 3156437c72a88d00c64cc98d35b70a23cca124cf
{
    /// <summary>
    /// This functions are an auxiliary functions
    /// It get all required details from the customer and sends them to the matched function
    /// </summary>
    void Delete();
    void Update();
}
