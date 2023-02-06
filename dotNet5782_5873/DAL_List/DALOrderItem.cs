using DO;
using System;
using DalApi;
using static DAL.DataSource;
using System.Reflection;

namespace DAL;
//Finish
internal class DALOrderItem : IOrderItem
{
    /// <summary>
    /// ADD AN OBJECT 
    /// </summary>
    /// <param name="newOrderItem"></param>
    /// <returns></returns>
    public int Add(OrderItem newOrderItem)
    {
        bool isExist = false;
        foreach (OrderItem currentOrderItem in OrderItemList)
        {
            if (currentOrderItem.OrderID == newOrderItem.OrderID && currentOrderItem.ProductID == newOrderItem.ProductID)
            {
                Console.WriteLine("An order item with this details already exists in the database.");
                isExist = true;
            }
        }
        if (!isExist)
        {
            //OrderItemList[Config.Next_DALOrderItem++] = newOrderItem;
            Console.WriteLine("The order item entered to database successfully.\nThe order item number of the item is: ");
            return newOrderItem.autoID;
        }
        return 0;
    }

    /// <summary>list
    /// This function creates an orderItem object and returns it's ID .
    /// </summary>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public void Add()
    {
        Console.WriteLine("Welcome to OrderItem menu.\nDo you know your order number? enter y or n");
        string? ans = Console.ReadLine();
        if (ans == "y")
        {
            Console.WriteLine("Please enter your order number");
        }
        else
        {

            OrderItemList.ForEach(MyOrderItm => MyOrderItm.ToString());
            Console.WriteLine("Please enter your order number");
        }
        int orderNum2;
        string? orderStr = Console.ReadLine();
        bool TryParseSucceeded = int.TryParse(orderStr, out orderNum2);
        if (TryParseSucceeded)
        {
            Console.WriteLine("Please enter product barcode");
            int barcode;
            string? barcodeStr = Console.ReadLine();
            bool result = int.TryParse(barcodeStr, out barcode);
            if (result)
            {
                Console.WriteLine("O.K. What is the price of the product?");
                double price;
                string? priceStr = Console.ReadLine();
                bool convertResult = double.TryParse(priceStr, out price);
                if (convertResult)
                {

                    Console.WriteLine("O.K. What is the price of the product?");
                    int amount;
                    string? amountStr = Console.ReadLine();
                    bool result2 = int.TryParse(amountStr, out amount);
                    if (result2)
                    {
                        OrderItem NewOrderItem = new OrderItem
                        {
                            ProductID = barcode,
                            OrderID = orderNum2,
                            ProductPrice = price,
                            Amount = amount,
                            autoID = Config.autoCounter
                        };
                        Add(NewOrderItem);
                       Console.WriteLine("OKAY. All detailes has been saved");
                       

                    }
                    else
                    {


                        throw new FailedToConvertException("CreateAnOrderItem function :: DAL_ORDER_ITEM");

                    }
                }
                else
                {
                    throw new FailedToConvertException("CreateAnOrderItem function :: DAL_ORDER_ITEM");

                }
            }
            else
            {
                throw new FailedToConvertException("CreateAnOrderItem function :: DAL_ORDER_ITEM");
            }

        }
        else
        {
            throw new FailedToConvertException("CreateAnOrderItem function :: DAL_ORDER_ITEM");
        }

        throw new FailedToConvertException("CreateAnOrderItem function :: DAL_ORDER_ITEM");
       
    }

       private static void print(OrderItem myOrderItem)
    {
        Console.WriteLine(myOrderItem);
    }

    public void Update()
    {
        Console.WriteLine("Do you know your order item ID? Enter y or n.");
        string? ans = Console.ReadLine();
        //int OrderNumber, productBarcode;
        if (ans == "n" || ans == "N")
        {
            OrderItemList.ForEach(obj => print(obj));
        }
        Console.WriteLine("Please enter your order item ID.");
        bool TryParseSucceeded = int.TryParse(Console.ReadLine(), out int orderItemNumber);
        if (TryParseSucceeded)
        {
            Console.WriteLine("What amount do you want?");
            bool TryParseSucceeded2 = int.TryParse(Console.ReadLine(), out int  amount);
            if (TryParseSucceeded2)
            {
                int index = OrderItemList.FindIndex(obj => obj.OrderID == orderItemNumber);         //Searching the item to make an update object
                if (index != -1)
                {
                    OrderItem updateOne = new OrderItem
                    {
                        ProductID = OrderItemList[index].ProductID,
                        OrderID = OrderItemList[index].OrderID,
                        Amount = amount,                           //The new amount
                        ProductPrice = OrderItemList[index].ProductPrice,
                        autoID = OrderItemList[index].autoID
                    };
                    Update(updateOne);
                }
                else
                {
                    Console.WriteLine("No order item match.");
                }
            }

            else
            {
                throw new FailedToConvertException("Update function :: DAL_ORDER_ITEM");
            }
        }
        else
        {
            throw new FailedToConvertException("Update function :: DAL_ORDER_ITEM");
        }
    }

    /// <summary>
    /// This function gets an orderItem object and update it.
    /// </summary>
    /// <param name="myOrderItem"></param>
    public void Update(OrderItem myOrderItem)
    {
        int index = OrderItemList.FindIndex(obj => obj.autoID == myOrderItem.autoID);         //Searching the item to make an update object
        if (index != -1)
        {
            OrderItemList[index] = myOrderItem;
            Console.WriteLine("Item has been successfully updated. ");
        }
        else
        {
            Console.WriteLine("No match item.");
        }
    }

    /// <summary>
    /// Delete orderItem from orderItem's array.
    /// </summary>
    /// <exception cref="Exception"></exception>
    public void Delete()
    {
        Console.WriteLine("Do you know your order item ID? Enter y or n.");
        string? ans = Console.ReadLine();
        int OrderNumber, productBarcode;
        if (ans == "n" || ans == "N")
        {
            foreach (var currentOrderItem in OrderItemList)
            {
                Console.WriteLine(currentOrderItem);    //Print all order items for customer

            }

            Console.WriteLine("Please enter your order item ID.");
            bool TryParseSucceeded = int.TryParse(Console.ReadLine(), out int orderItemNumber);
            if (TryParseSucceeded)
            {
                OrderItem obj = OrderItemList.Find(currentOrderItem => currentOrderItem.OrderID == orderItemNumber);    //Searching the order item to delete it.
                Delete(obj.autoID);

            }

            else
            {
                throw new FailedToConvertException("Daelete function :: DAL_ORDER_ITEM");
            }
        }
    }
    /// <summary>
    /// This functoin gets an object and delete it.
    /// </summary>
    /// <param name="myOrderItem"></param>
    public void Delete(int id)
    {
        int index = OrderItemList.FindIndex(currentOrderItem => currentOrderItem.autoID == id);    //Searching the order item to delete it.
        if (index != -1)
        {
            OrderItemList.RemoveAt(index);
            Console.WriteLine("The item has been successfully removed");
        }
        else
        {
            throw new InvalidEntityException("Delete function :: DAL_ORDER_ITEM");

        }
    }

   
    public OrderItem GetByID(int orderID, int productID)
    {
       int index= OrderItemList.FindIndex(item=> item.OrderID==orderID&& item.ProductID==productID);
        if(index!= -1)
        {
            return OrderItemList[index];
        }
        else
        {
            throw new InvalidEntityException("GetById function :: DAL_ORDER_ITEM");
        }
    }

    public IEnumerable<OrderItem>? Get(Func<OrderItem, bool>? deligate)
    {
        if (deligate != null)
        {
            return OrderItemList.Where(deligate);   
        }
        return OrderItemList;
    }

     public OrderItem GetAnObject(Predicate<OrderItem> myDelegate)
    {
        return OrderItemList.Find(myDelegate);
    }

    public IEnumerable<OrderItem> GetAll()
    {
        throw new NotImplementedException();
    }
}



