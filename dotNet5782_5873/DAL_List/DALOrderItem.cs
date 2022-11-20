using DO;
using System;
using DalApi;
using static DAL.DataSource;

namespace DAL;

internal class DALOrderItem : DalApi.ICrud<OrderItem>
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
    public int Add()
    {
        Console.WriteLine("Welcome to OrderItem menu.\nDo you know your order number? enter y or n");
        string ans = Console.ReadLine();
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
                        OrderItem NewOrderItem = new OrderItem
                        {
                            ProductID = barcode,
                            OrderID = orderNum2,
                            ProductPrice = price,
                            Amount = amount,
                            autoID = Config.autoCounter
                        };
                        OrderItemList.Insert(0, NewOrderItem);
                        Console.WriteLine("OKAY. All detailes has been saved");
                        return NewOrderItem.autoID;

                    }
                    else
                    {


                        throw new Exception("ERROR: Failed to convert variables. Failed to receive input.\nAN ERROR OCCURED IN CREATE_AN_ORDER_ITEM FUNCTION:ORDER_ITEM");

                    }
                }
                else
                {
                    throw new Exception("ERROR: Failed to convert variables. Failed to receive input.\nAN ERROR OCCURED IN CREATE_AN_ORDER_ITEM FUNCTION:ORDER_ITEM");

                }
            }
            else
            {
                throw new Exception("ERROR: Failed to convert variables. Failed to receive input.\nAN ERROR OCCURED IN CREATE_AN_ORDER_ITEM FUNCTION:ORDER_ITEM");
            }

        }
        else
        {
            throw new Exception("ERROR: Failed to convert variables. Failed to receive input.\nAN ERROR OCCURED IN CREATE_AN_ORDER_ITEM FUNCTION:ORDER_ITEM");
        }

        throw new Exception("ERROR: Failed to convert variables. Failed to receive input.\nAN ERROR OCCURED IN CREATE_AN_ORDER_ITEM FUNCTION:ORDER_ITEM");
        return 0;
    }

    public static void Get(int id)
    {
        OrderItemList.ForEach(MyOrderItem => print(MyOrderItem, id));
    }


    private static void print(OrderItem myOrderItem, int id)
    {
        if (myOrderItem.autoID == id)
        {
            Console.WriteLine(myOrderItem);
        }
    }

    public static void Update()
    {
        Console.WriteLine("Do you know your order item ID? Enter y or n.");
        string ans = Console.ReadLine();
        //int OrderNumber, productBarcode;
        if (ans == "n" || ans == "N")
        {
            foreach (OrderItem currentOrderItem in OrderItemList)      //Print all order items for customer
            {
                currentOrderItem.ToString();
            }
        }
        Console.WriteLine("Please enter your order item ID.");
        int orderNumber;
        string orderNumStr = Console.ReadLine();
        bool TryParseSucceeded = int.TryParse(orderNumStr, out orderNumber);
        if (TryParseSucceeded)
        {
            Console.WriteLine("What amount do you want?");
            int amount;
            string amountStr = Console.ReadLine();
            bool TryParseSucceeded2 = int.TryParse(amountStr, out amount);
            if (TryParseSucceeded2)
            {
                foreach (OrderItem currentOrderItem in OrderItemList)
                {
                    if (currentOrderItem.OrderID == orderNumber)        //Searching the item to make an update object
                    {
                        OrderItem updateOne = new OrderItem

                        {
                            ProductID = currentOrderItem.ProductID,
                            OrderID = currentOrderItem.OrderID,
                            Amount = amount,                           //The new amount
                            ProductPrice = currentOrderItem.ProductPrice,
                            autoID = currentOrderItem.autoID
                        };
                        updateOrderItem(updateOne);
                    }
                    else
                    {
                        Console.WriteLine("No order item match.");
                    }
                }
            }
            else
            {
                throw new Exception("ERROR: Failed to convert variables. Failed to receive input.\nAN ERROR OCCURED IN UPDATE FUNCTION:ORDER_ITEM");
            }
        }
        else
        {
            throw new Exception("ERROR: Failed to convert variables. Failed to receive input.\nAN ERROR OCCURED IN UPDATE FUNCTION:ORDER_ITEM");
        }
    }

    /// <summary>
    /// Update orderItem in orderItem's array
    /// </summary>
    /// <param name="newOne"></param>
    /// <exception cref="Exception"></exception>
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

    public static void Delete()
    {
        Console.WriteLine("Do you know your order item ID? Enter y or n.");
        string ans = Console.ReadLine();
        int OrderNumber, productBarcode;
        if (ans == "n" || ans == "N")
        {
            foreach (OrderItem currentOrderItem in orderItemArray)      //Print all order items for customer
            {
                currentOrderItem.ToString();
            }
        }
        Console.WriteLine("Please enter your order item ID.");
        int orderNumber;
        string orderNumStr = Console.ReadLine();
        bool TryParseSucceeded = int.TryParse(orderNumStr, out orderNumber);
        if (TryParseSucceeded)
        {
            foreach (OrderItem currentOrderItem in orderItemArray)      //Searching the order item to delete it.
            {
                if (currentOrderItem.OrderID == orderNumber)
                {
                    deleteOrderItem(orderNumber, currentOrderItem.ProductID);
                }
                else
                {
                    Console.WriteLine("No match item.");
                }
            }
        }
        else
        {
            throw new Exception("ERROR: Failed to convert variables. Failed to receive input.");
        }
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
                Console.WriteLine("ERROR: This item doesn't found.\n(Check yourself. Maybe you just have a typo. ");
            }
        }
    }

    public OrderItem add(OrderItem entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<OrderItem> GetAll()
    {
        IEnumerable<OrderItem> OrderItems = OrderItemList;
        return OrderItems;
    }
    public void ReadAll()
    {

    }







    public OrderItem update(OrderItem entity)
    {
        throw new NotImplementedException();
    }

    public OrderItem delete(int id)
    {
        throw new NotImplementedException();
    }

    OrderItem ICrud<OrderItem>.Add(OrderItem entity)
    {
        throw new NotImplementedException();
    }

    public OrderItem Get(int id)
    {
        throw new NotImplementedException();
    }

    public OrderItem Update(OrderItem entity)
    {
        throw new NotImplementedException();
    }

    public OrderItem Delete(int id)
    {
        throw new NotImplementedException();
    }

    //public static OrderItem getOrderItemDetails()
    //{

    //}

    ///// <summary>list
    ///// This function gets object details, create a new object and put it in the array.
    ///// </summary>
    ///// <param name="pID"></param>
    ///// <param name="oID"></param>
    ///// <param name="price"></param>
    ///// <param name="amount"></param>
    //private int init_OrderItem(int pID, int oID, double price, int amount)
    //{
    //    OrderItem MyOrderItem = new OrderItem
    //    {
    //        ProductID = pID,
    //        OrderID = oID,
    //        ProductPrice = price,
    //        Amount = amount,
    //        autoID = Config.autoCounter
    //    };
    //    Add(MyOrderItem);
    //    return MyOrderItem.OrderID;

    //}


}
