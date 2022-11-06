using static DO.Enums;

namespace DO;

///<summary>
/// Structure for Order:
/// Every order have the details of the transaction. Cusomer details, time of order, shiping time ect.
/// </summary>
public struct Order
{

    //Fields
    public int ID { get; set; }
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public string CustomerAddress { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime ShipDate { get; set; }
    public DateTime DeliveryDate { get; set; }


    //Constructor
    public Order(int id, string customerName, string customerEmail, string customerAddress, DateTime orderDate, DateTime shipDate, DateTime deliveryDate)
    {
        ID = id;    
        CustomerName = customerName;
        CustomerEmail = customerEmail;
        CustomerAddress = customerAddress;
        OrderDate = orderDate;  
        ShipDate = shipDate;
        DeliveryDate = deliveryDate;    

    }

    public override string ToString() => $@"
    Order details:\n
    Order number: {ID}, 
    Name of the order: {CustomerName},
    address: {CustomerAddress}
    Order date: {OrderDate}";

}


