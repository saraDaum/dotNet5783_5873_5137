using DO;
namespace DalApi;

public interface IOrder:ICrud<Order>
{
    /// <summary>
    /// This functions are an auxiliary functions
    /// It get all required details from the customer and sends them to the matched function
    /// </summary>
    void Add();
    void Delete();
    void Get();
}

