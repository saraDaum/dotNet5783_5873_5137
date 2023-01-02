using DalApi;
using DO;
using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Reflection;
using static DAL.DataSource;

namespace DAL;


internal class DALOrder : IOrder
{
    /// <summary>list
    /// This function gets an order object, enter it to order's array and returns the order number
    /// </summary>
    /// <param name="newOrder"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public int Add(Order newOrder)
    {
        if (newOrder.ID != 0)
        {
            if (!OrderList.Contains(newOrder))
            {
                OrderList.Insert(0, newOrder);
                Console.WriteLine("The order entered to database successfully.\nThe order number of the item is: ");
                return newOrder.ID;
            }
            else
            {
                throw new DuplicateIdException(newOrder.ID, "Add function :: DAL_ORDER");

            }
        }
        else
        {
            throw new InvalidEntityException("Add function :: DAL_ORDER");
        }
        return 0;
    }

    public void Add()
    {
        string name = "", email = "", address = "";
        Order newOrder = new Order();
        do
        {
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
        }
        while (name == "");
        do
        {
            Console.WriteLine("Please enter your email address");
            email = Console.ReadLine();
            while (!email.EndsWith("@gmail.com"))
            {
                Console.WriteLine("You don't enter a correct email.\nPlease enter a valid email address");
                email = Console.ReadLine();
            }
        }
        while (email == "");
        do
        {
            Console.WriteLine("Please enter your living address");
            address = Console.ReadLine();
        }
        while (address == "");
        Console.WriteLine("O.K. All details are in.\nPlease wait.");
        newOrder.CustomerName = name;
        newOrder.CustomerAddress = address;
        newOrder.CustomerEmail = email;
        Add(newOrder);

    }


    /// <summary>list
    /// Update order in order's array
    /// </summary>
    /// <param name="newOne"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public void Update(Order newOne)
    {
        int index = OrderList.FindIndex(MyOrder => MyOrder.ID == newOne.ID);
        if (index == -1)
        {
            throw new EntityNotFoundException("Update function :: DAL_ORDER");
        }
        if (index != -1)
        {
            OrderList[index] = newOne;

        }
    }

    /// <summary>list
    /// Delete an Order object
    /// </summary>
    /// <param name="id"></param>
    /// <exception cref="Exception"></exception>
    public void Delete()
    {
        Console.WriteLine("Do you know your order number? Enter y or n.");
        string? ans = Console.ReadLine();
        if (ans == "n" || ans == "N")
        {
            OrderList.ForEach(MyOrder => print(MyOrder));
        }
        Console.WriteLine("Please enter your order number.");
        int orderNumber;
        string? orderNumStr = Console.ReadLine();
        bool TryParseSucceeded = int.TryParse(orderNumStr, out orderNumber);
        if (TryParseSucceeded)
        {
            Delete(orderNumber);

        }

    }

    public void Delete(int ID)
    {
        int index = OrderList.FindIndex(order => order.ID == ID);
        if (index == -1)
        {
            throw new InvalidEntityException("Delete function :: DAL_ORDER");
        }
        if (index != -1)
        {
            OrderList.RemoveAt(index);
            Console.WriteLine("The item has been successfully removed");

        }
    }

    public static void print(Order obj)
    {
        Console.WriteLine(obj);
    }

    /// <summary>list
    /// This function returns all instances of order
    /// </summary>
    /// <returns></returns>
    public IEnumerable<Order> GetAll()
    {
        IEnumerable<Order> orders = DataSource.OrderList;
        return orders;
    }

    public void PrintAll()
    {
        List<Order> orders = OrderList;
        foreach (var item in orders)
        {
            Console.WriteLine(item);
        }
    }

    /// <summary>list
    /// This function gets an ID number and returns the corresponding Order object
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Order GetById(int id)
    {
        int index = OrderList.FindIndex(MyOrder => MyOrder.ID == id);
        if (index == -1)
            throw new EntityNotFoundException("GetById function :: DAL_ORDER");
        return OrderList[index];

    }



    /// <summary>list
    /// This function gets an Order object and print it's detail
    /// </summary>
    /// <param name="id"></param>
    /// <exception cref="Exception"></exception>
    public void ReadById(int id)
    {
        Console.WriteLine("Please enter your order number");
        bool TryParseSucceeded = int.TryParse(Console.ReadLine(), out int orderNumber);
        if (TryParseSucceeded)
        {
            Order MyOrder = OrderList.Find(MyOrder => MyOrder.ID == id);
            Console.WriteLine(MyOrder);
        }
        else
        {
            throw new FailedToConvertException("ReadById :: DAL_ORDER");
        }
    }

    public IEnumerable<Order> Get(Func<Order,bool>? myDeligate)
    {
        if (myDeligate != null)
        {
           return OrderList.Where(myDeligate);
        }
        return OrderList;
    }
}