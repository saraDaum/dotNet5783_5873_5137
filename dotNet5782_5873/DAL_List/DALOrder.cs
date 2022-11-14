using DalApi;
using DO;
using System;
using static DAL.DataSource;

namespace DAL;


internal struct DALOrder : DalApi.ICrud<Order>
{
    /// <summary>list
    /// Update order in order's array
    /// </summary>
    /// <param name="newOne"></param>
    /// <exception cref="Exception"></exception>
    public static void updateOrder(Order newOne)
    {
        int index = OrderList.FindIndex(MyOrder => MyOrder.ID == newOne.ID);
        if (index == -1)
        {
            throw new Exception("Object dosen't exist.");
        }
        if (index != -1)
        {
            OrderList.Insert(index, newOne);

        }

    }

    /// <summary>list
    /// Create an Order Object.
    /// </summary>
    public static void newOrder()
    {
        Console.WriteLine("Hello, please enter your name");
        string AnsCustomerName = Console.ReadLine();

        Console.WriteLine("Please enter your email");
        string AnsCustomerEmail = Console.ReadLine();

        Console.WriteLine("Please enter your Address");
        string AnsCustomerAddress = Console.ReadLine();

        Order newOrder = new Order
        {
            ID = Config.NextOrderNumber,
            CustomerName = AnsCustomerName,
            CustomerEmail = AnsCustomerEmail,
            CustomerAddress = AnsCustomerAddress,
            OrderDate = DateTime.Today,
            ShipDate = DateTime.Today + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 3L)),
            DeliveryDate = DateTime.Now + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 10L))
        };
        addOrder(newOrder);

    }
    /// <summary>list
    /// This function gets an order object, enter it to order's array and returns the order number
    /// </summary>
    /// <param name="newOrder"></param>
    /// <returns></returns>
    public static int addOrder(Order newOrder)
    {
        int index = OrderList.FindIndex(MyOrder => MyOrder.ID == newOrder.ID);
        if (index == -1)
        {
            OrderList.Insert(0, newOrder);
            Console.WriteLine("The order entered to database successfully.\nThe order number of the item is: ");
            return newOrder.ID;
        }
        if (index != -1)
        {
            throw new Exception("A order with this number already exists in the database.");

        }
        return 0;
    }

    /// <summary>list
    /// This function gets an Order object and print it's detail
    /// </summary>
    /// <exception cref="Exception"></exception>
    public static void readAnOrder()

    {
        int orderNumber;
        Console.WriteLine("Please enter your order number");
        string orderStr = Console.ReadLine();
        bool TryParseSucceeded = int.TryParse(orderStr, out orderNumber);
        if (TryParseSucceeded)
        {
            Order MyOrder = OrderList.Find(MyOrder => MyOrder.ID == orderNumber);
            MyOrder.ToString();
        }
        else
        {
            throw new Exception("ERROR: Failed to convert variables. Failed to receive input.");
        }
    }


    /// <summary>list
    /// This function returns all instances of order
    /// </summary>
    /// <returns></returns>
    public static IEnumerable<Order> returnAllOrders()
    {
        IEnumerable<Order> orders = OrderList;
        return orders;
    }


    /// <summary>list
    /// This function gets an ID number and returns the corresponding Order object
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Order ReturnOrderObject(int id)
    {
        int index = OrderList.FindIndex(MyOrder => MyOrder.ID == id);
        if (index == -1)
            throw new Exception("This object dosen't exist.");
        return OrderList.ElementAt(index);

    }

    /// <summary>list
    /// This function
    /// </summary>
    public static void delete()
    {
        
        Console.WriteLine("Do you know your order number? Enter y or n.");
        string ans = Console.ReadLine();
        if (ans == "n" || ans == "N")
        {
            returnAllOrders();
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
        int index = OrderList.FindIndex(MyOrder => MyOrder.ID == OrderNumber);
        if (index == -1)
        {
            throw new Exception("The order has been successfully deleted.");
        }
        if (index != -1)
        {
            OrderList.RemoveAt(index);
        }
        //bool existFlag = false;
        //for (int i = 0; i < Config.Next_DALOrder; i++)
        //{
        //    if (OrderArray[i].ID == OrderNumber)
        //    {
        //        existFlag = true;
        //        OrderArray[i] = OrderArray[Config.Next_DALOrder];
        //        Config.Next_DALOrder--;
        //        Console.WriteLine("The order has been successfully deleted");

        //    }
        //    if (existFlag == false)
        //    {
        //        Console.WriteLine("ERROR: This order dosen't exist in database.\n(Check yourself. Maybe you just have a typo.) ");
        //    }
        //}
    }


    public Order add(Order entity)
    {
        throw new NotImplementedException();
    }

    public Order Get(int id)
    {
        throw new NotImplementedException();
    }

    public Order update(Order entity)
    {
        throw new NotImplementedException();
    }

    public Order delete(int id)
    {
        throw new NotImplementedException();
    }

}
