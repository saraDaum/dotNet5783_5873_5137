using DO;
namespace DalApi;

public interface IProduct:ICrud<Product>
{
    /// <summary>
    /// This functions are an auxiliary functions
    /// It get all required details from the customer and sends them to the matched function
    /// </summary>
    void Delete();
    void Update();
}
