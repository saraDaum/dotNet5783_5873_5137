
namespace DO;

///<summary>
/// Structure for OrderItem:
/// Every OrderItem have the details of the item that order. Price, amount ect.
/// </summary>
public struct OrderItem
{
    //Fields
    public int ProductID { get; set; }
    public int OrderID { get; set; }
    public double ProductPrice { get; set; }
    public int Amount { get; set; }


    //Constructor
    public OrderItem(int productId, int orderId, double price, int amount)
    {
        ProductID = productId;
        OrderID = orderId;
        ProductPrice = price;   
        Amount = amount;
    }

    public override string ToString() => $@"
    Order item details:\n
    Product barkode:{ProductID}, 
    Order number:{OrderID}, 
    Price: {ProductPrice},
   	Amount in order: {Amount}";
}
