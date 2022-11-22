using DalApi;
using DO;
using Microsoft.VisualBasic;
using System;
using System.Reflection;
using static DAL.DataSource;

namespace DAL;


internal struct DALOrder : DalApi.ICrud<Order>
{
    /// <summary>list
    /// This function gets an order object, enter it to order's array and returns the order number
    /// </summary>
    /// <param name="newOrder"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public int Add(Order newOrder)
    {
        int index = OrderList.FindIndex(MyOrder => MyOrder.ID == newOrder.ID);
        if (index != -1)
        {
            OrderList.Insert(0, newOrder);
            Console.WriteLine("The order entered to database successfully.\nThe order number of the item is: ");
            return newOrder.ID;
        }
        if (index == -1)
        {
            throw new Exception("A order with this number already exists in the database.");

        }
        return 0;
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
            throw new Exception("Object dosen't exist.");
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
    public void Delete(int id)
    {
        Console.WriteLine("Do you know your order number? Enter y or n.");
        string ans = Console.ReadLine();
        if (ans == "n" || ans == "N")
        {
            OrderList.ForEach(MyOrder => print(MyOrder));
        }
        Console.WriteLine("Please enter your order number.");
        int orderNumber;
        string orderNumStr = Console.ReadLine();
        bool TryParseSucceeded = int.TryParse(orderNumStr, out orderNumber);
        if (TryParseSucceeded)
        {
            int index = OrderList.FindIndex(MyOrder => MyOrder.ID == id);
            
        }

    }

    public void DeleteO(int index)
    {
        if (index == -1)
        {
            throw new Exception("The order has been successfully deleted.");
        }
        if (index != -1)
        {
            OrderList.RemoveAt(index);
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
        IEnumerable<Order> orders = OrderList;
        return orders;
    }


    /// <summary>list
    /// This function gets an ID number and returns the corresponding Order object
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public  Order Get(int id)
    {
        int index = OrderList.FindIndex(MyOrder => MyOrder.ID == id);
        if (index == -1)
            throw new Exception("This object dosen't exist.");
        return OrderList.ElementAt(index);

    }



    /// <summary>list
    /// This function gets an Order object and print it's detail
    /// </summary>
    /// <param name="id"></param>
    /// <exception cref="Exception"></exception>
    public void ReadById(int id)
    {
        int orderNumber;
        Console.WriteLine("Please enter your order number");
        string orderStr = Console.ReadLine();
        bool TryParseSucceeded = int.TryParse(orderStr, out orderNumber);
        if (TryParseSucceeded)
        {
            Order MyOrder = OrderList.Find(MyOrder => MyOrder.ID == id);
            Console.WriteLine(MyOrder);
        }
        else
        {
            throw new Exception("ERROR: Failed to convert variables. Failed to receive input.");
        }
    }

}