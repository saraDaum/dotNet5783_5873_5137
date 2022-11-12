using DO;
using static DAL.DataSource;

namespace DAL;


public struct DALOrder
{

    //Update order in order's array
    public static void updateOrder(Order newOne)
    {
        bool existFlag = false;
        for (int i = 0; i < Config.Next_DALOrder; i++)
        {
            if (OrderArray[i].ID == newOne.ID)
            {
                existFlag = true;
                OrderArray[i] = newOne;
                Console.WriteLine("Order has been successfully update");
            }
            if (existFlag == false)
            {
                throw new Exception("ERROR: This order doesn't found. No action happened.\n(Check yourself. Maybe you just have a typo. ");
            }
        }
    }
    /// <summary>
    /// This function gets an order object, enter it to order's array and returns the order number
    /// </summary>
    /// <param name="newOrder"></param>
    /// <returns></returns>
    public static int addOrder(Order newOrder)
    {
        bool isExist = false;
        foreach (Order currentOrder in OrderArray)
        {
            if (currentOrder.ID == newOrder.ID)
            {
                Console.WriteLine("A order with this number already exists in the database.");
                isExist = true;
            }
        }
        if (!isExist)
        {
            OrderArray[Config.Next_DALOrder++] = newOrder;
            Console.WriteLine("The order entered to database successfully.\nThe order number of the item is: ");
            return newOrder.ID;
        }
        return 0;
    }
   
    public static void readAnOrder()
        
    {
        int orderNumber;
        Console.WriteLine("Please enter your order number");
        string orderStr=Console.ReadLine();
        bool TryParseSucceeded = int.TryParse(orderStr, out orderNumber);
        if (TryParseSucceeded)
        {
            bool isExist=false;
            foreach (Order currentOrder in OrderArray)
            {
                if (currentOrder.ID == orderNumber)
                {
                    isExist=true;
                    currentOrder.ToString();
                }
                if (isExist)
                    Console.WriteLine("This order dosen't exist in database.\n(Check yourself. Maybe you just have a typo.)");
            }
        }
        else
        {
            throw new Exception("ERROR: Failed to convert variables. Failed to receive input.");
        }
    }


    /// <summary>
    /// This function returns all instances of order
    /// </summary>
    /// <returns></returns>
    public static Order[] returnAllOrders()
    {
        Order[] myOrders = new Order[Config.Next_DALOrder];
        for (int i = 0; i < Config.Next_DALOrder; i++)
        {
            myOrders[i] = OrderArray[i];
        }
        return myOrders;
    }

   
    /// <summary>
    /// This function gets an ID number and returns the corresponding Order object
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Order ReturnOrderObject(int id)
    {
        foreach (Order currentOrder in OrderArray)
        {
            if (currentOrder.ID == id)
                return currentOrder;
        }
        Order emptyOrder = new Order
        {
            ID = Config.NextOrderNumber,
            CustomerName = "",
            CustomerEmail = "",
            CustomerAddress = "",
            OrderDate = DateTime.Today,
            ShipDate = DateTime.Today,
            DeliveryDate = DateTime.Today
        };
        return emptyOrder;
    }

    public static void delete()
    {
        Console.WriteLine("Do you know your order number? Enter y or n.");
        string ans = Console.ReadLine();
        if (ans == "n" || ans == "N")
        {
            foreach (Order currentOrder in OrderArray)
            {
                currentOrder.ToString();
            }
        }
        Console.WriteLine("Please enter your order number.");
        int orderNumber;
        string orderNumStr = Console.ReadLine();
        bool TryParseSucceeded = int.TryParse(orderNumStr, out orderNumber);
        if (TryParseSucceeded)
        {
            deleteOrder(orderNumber);
        }
    }

    /// <summary>
    /// Delete order from order's array.
    /// </summary>
    /// <param name="OrderNumber"></param>
    /// <exception cref="Exception"></exception>
    static void deleteOrder(int OrderNumber)
    {
        bool existFlag = false;
        for (int i = 0; i < Config.Next_DALOrder; i++)
        {
            if (OrderArray[i].ID == OrderNumber)
            {
                existFlag = true;
                OrderArray[i] = OrderArray[Config.Next_DALOrder];
                Config.Next_DALOrder--;
                Console.WriteLine("The order has been successfully deleted");

            }
            if (existFlag == false)
            {
                Console.WriteLine("ERROR: This order dosen't exist in database.\n(Check yourself. Maybe you just have a typo.) ");
            }
        }
    }
}
