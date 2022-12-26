
namespace DO;

///<summary>
/// Structure for OrderItem ( a data entity)
/// Every OrderItem have the details of the item that order. Price, amount ect.
/// </summary>
public struct OrderItem
{

    /// <summary>
    /// Product unique ID
    /// </summary>
    public int ProductID { get; set; }

    /// <summary>
    /// Order unique ID
    /// </summary>
    public int OrderID { get; set; }

    /// <summary>
    /// Product price
    /// </summary>
    public double ProductPrice { get; set; }

    /// <summary>
    /// 
    /// Required amount from this item
    /// </summary>
    public int Amount { get; set; }

    /// <summary>
    /// Unique ID for this item
    /// </summary>
    public int autoID { get; set; }

    public override string ToString() => $@"
    Order item details:\n
    ID code: {autoID}
    Product barkode: {ProductID}, 
    Order number: {OrderID}, 
    Price: {ProductPrice},
   	Amount in order: {Amount}";
}
