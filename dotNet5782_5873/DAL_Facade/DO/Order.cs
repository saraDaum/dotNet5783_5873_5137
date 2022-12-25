
namespace DO;

///<summary>
/// Structure for Order:
/// Every order have the details of the transaction. Cusomer details, time of order, shiping time ect.
/// </summary>
public struct Order
{

    //Static ID, helper variable
    private static int staticID=1000;
    /// <summary>
    /// Unique order ID
    /// </summary>
    public int ID { get=> staticID++;  set=>ID= value; }

    /// <summary>
    /// Customer name
    /// </summary>
    public string CustomerName { get; set; }

    /// <summary>
    /// Customer email address
    /// </summary>
    public string CustomerEmail { get; set; }

    /// <summary>
    /// Customer living address
    /// </summary>
    public string CustomerAddress { get; set; }

    /// <summary>
    /// Order date
    /// </summary>
    public DateTime OrderDate { get=>DateTime.Today ; set=> OrderDate= value; }

    /// <summary>
    /// Ship date of this order
    /// </summary>
    public DateTime ShipDate { get => DateTime.Today.AddDays(2); set => ShipDate = value; }

    /// <summary>
    /// Delivery date of this order
    /// </summary>
    public DateTime DeliveryDate { get=> DateTime.Today.AddDays(10); set=> DeliveryDate = value; }


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


