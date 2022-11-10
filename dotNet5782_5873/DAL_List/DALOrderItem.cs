using DO;
using static DAL.DataSource;

namespace DAL;

public struct DALOrderItem
{
    
    /// <summary>
    /// This function gets object details, create a new object and put it in the array.
    /// </summary>
    /// <param name="pID"></param>
    /// <param name="oID"></param>
    /// <param name="price"></param>
    /// <param name="amount"></param>
    private static int init_OrderItem(int pID, int oID, double price, int amount)
    {

        orderItemArray[Config.Next_DALOrderItem++] = new OrderItem
        {
            ProductID = pID,
            OrderID = oID,
            ProductPrice = price,
            Amount = amount,
            autoID = Config.autoCounter
        };
        return orderItemArray[--Config.Next_DALOrderItem].autoID;

    }

    /// <summary>
    /// ADD AN OBJECT 
    /// </summary>
    /// <param name="newOrderItem"></param>
    /// <returns></returns>
    public static int addOrderItem(OrderItem newOrderItem)
    {
        bool isExist = false;
        foreach (OrderItem currentOrderItem in orderItemArray)
        {
            if (currentOrderItem.OrderID == newOrderItem.OrderID && currentOrderItem.ProductID == newOrderItem.ProductID)
            {
                Console.WriteLine("An order item with this details already exists in the database.");
                isExist = true;
            }
        }
        if (!isExist)
        {
            orderItemArray[Config.Next_DALOrderItem++] = newOrderItem;
            Console.WriteLine("The order item entered to database successfully.\nThe order item number of the item is: ");
            return newOrderItem.autoID;
        }
        return 0;
    }

    /// <summary>
    /// This function creates and returns an orderItem object.
    /// </summary>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public static OrderItem createAnOrderItem()
    {
        Console.WriteLine("Welcome yo Order menu.\nDo you know your order number? enter y or n");
        string ans = Console.ReadLine();
        if (ans == "y")
        {
            Console.WriteLine("Please enter your order number");
        }
        else
        {

            returnAllOrders();
            Console.WriteLine("Please enter your order number");
        }
        int orderNum2;
        string orderStr = Console.ReadLine();
        bool TryParseSucceeded = int.TryParse(orderStr, out orderNum2);
        if (TryParseSucceeded)
        {
            Console.WriteLine("Please enter product barcode");
            int barcode;
            string barcodeStr = Console.ReadLine();
            bool result = int.TryParse(barcodeStr, out barcode);
            if (result)
            {
                Console.WriteLine("O.K. What is the price of the product?");
                double price;
                string priceStr = Console.ReadLine();
                bool convertResult = double.TryParse(priceStr, out price);
                if (convertResult)
                {

                    Console.WriteLine("O.K. What is the price of the product?");
                    int amount;
                    string amountStr = Console.ReadLine();
                    bool result2 = int.TryParse(amountStr, out amount);
                    if (result2)
                    {
                        Console.WriteLine("OKAY. All detailes has been saved");

                    }
                    else
                    {
                        //init_OrderItem(barcode, orderNum2,price,amount);
                        OrderItem newOrderItem = new OrderItem
                        {
                            ProductID = barcode,
                            OrderID = orderNum2,
                            ProductPrice = price,
                            Amount = amount,
                            autoID = Config.autoCounter
                        };
                        throw new Exception("ERROR: Failed to convert variables. Failed to receive input.");
                        return newOrderItem;

                    }
                }
                else
                {
                    throw new Exception("ERROR: Failed to convert variables. Failed to receive input.");

                }
            }
            else
            {
                throw new Exception("ERROR: Failed to convert variables. Failed to receive input.");
            }

        }
        else
        {
            throw new Exception("ERROR: Failed to convert variables. Failed to receive input.");
        }
        OrderItem emptyOrderItem = new OrderItem
        {
            ProductID = 0,
            OrderID = 0,
            ProductPrice = 0,
            Amount = 0,
            autoID = 0
        };
        throw new Exception("ERROR: Failed to convert variables. Failed to receive input.");
        return emptyOrderItem;
    }


    //Update orderItem in orderItem's array
    public static void updateOrderItem(OrderItem newOne)
    {
        bool existFlag = false;
        for (int i = 0; i < Config.Next_DALOrderItem; i++)
        {
            if (orderItemArray[i].OrderID == newOne.OrderID && orderItemArray[i].ProductID == newOne.ProductID)
            {
                existFlag = true;
                orderItemArray[i] = newOne;
                Console.WriteLine("Item has been successfully update");
            }
            if (existFlag == false)
            {
                throw new Exception("ERROR: This item doesn't found. No action happened.\n(Check yourself. Maybe you just have a typo. ");
            }
        }
    }

    
    //This function returns all instances of orderItem 
    public static OrderItem[] returnAllOrderItems()
    {
        OrderItem[] myOrderItems = new OrderItem[Config.Next_DALOrderItem];
        for (int i = 0; i < Config.Next_DALOrder; i++)
        {
            myOrderItems[i] = orderItemArray[i];
        }
        return myOrderItems;
    }

    /// <summary>
    /// Delete orderItem from orderItem's array.
    /// </summary>
    /// <param name="OrderNumber"></param>
    /// <param name="productBarcode"></param>
    /// <exception cref="Exception"></exception>
    static void deleteOrderItem(int OrderNumber, int productBarcode)
    {
        bool existFlag = false;
        for (int i = 0; i < Config.Next_DALOrderItem; i++)
        {
            if (orderItemArray[i].OrderID == OrderNumber && orderItemArray[i].ProductID == productBarcode)
            {
                existFlag = true;
                orderItemArray[i] = orderItemArray[Config.Next_DALOrderItem];
                Config.Next_DALOrderItem--;
                Console.WriteLine("The item has been successfully deleted");
            }
            if (existFlag == false)
            {
                throw new Exception("ERROR: This item doesn't found.\n(Check yourself. Maybe you just have a typo. ");
            }
        }
    }

    //public static OrderItem getOrderItemDetails()
    //{

    //}

}
