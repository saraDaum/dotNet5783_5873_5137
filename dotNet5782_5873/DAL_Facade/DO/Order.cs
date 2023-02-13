
namespace DO;

///<summary>
/// Structure for Orde ( a data entity)
/// Every order have the details of the transaction. Cusomer details, time of order, shiping time ect.
/// </summary>
public struct Order
{
    private static int _id = 20000000;
    //Static ID, helper variable
    private static int staticID = 1000;
    /// <summary>
    /// Unique order ID
    /// </summary>
    public int ID { get; set; } //{ get=> staticID++;  set=>ID= value; }

    /// <summary>
    /// Customer name
    /// </summary>
    public string? CustomerName { get; set; }

    /// <summary>
    /// Customer email address
    /// </summary>
    public string? CustomerEmail { get; set; }

    /// <summary>
    /// Customer living address
    /// </summary>
    public string? CustomerAddress { get; set; }

    /// <summary>
    /// Order date
    /// </summary>
    public DateTime OrderDate { get; set ; }

    /// <summary>
    /// Ship date of this order
    /// </summary>
    public DateTime ShipDate { get; set; }

    /// <summary>
    /// Delivery date of this order
    /// </summary>
    public DateTime DeliveryDate { get; set; }
    public Order()
    {

        ID = ++_id;
        CustomerName = "";
        CustomerEmail = $"{ID}@gmail.com";
        CustomerAddress = "";
        OrderDate = DateTime.Today;
        ShipDate = DateTime.Today.AddDays(2);
        DeliveryDate = DateTime.Today.AddDays(10);
    }

    //Constructor
    //public Order( string customerName, string customerEmail, string customerAddress, DateTime orderDate)
    //{
    //    ID =DataSource. NextOrder;    
    //    CustomerName = customerName;
    //    CustomerEmail = customerEmail;
    //    CustomerAddress = customerAddress;
    //    OrderDate = orderDate;  
    //    ShipDate = DateTime.MinValue;
    //    DeliveryDate = DateTime.MinValue ;    

    //}

    public override string ToString() => $@"
    Order details:\n
    Order number: {ID}, 
    Name of the order: {CustomerName},
    address: {CustomerAddress}
    Order date: {OrderDate}";

}


