using BlApi;
using BlImplementation;
using BO;
using System;
using System.Security.Cryptography.X509Certificates;

namespace BlTest;

public class ApplicationBL
{
    public void Main(string[] args)
    {
        IBl blVar = new BL();
        int choose = ReadInt("Choose the Entity you want");//להחליף את ההודעה למפורטת
        switch (choose)
        {
            case 0: return;
            case 1:
                cart();
                break;
            case 2:
                order();
                break;
            case 3:
                OrderForList();
                break;
            case 4:
                OrderItem();
                break;
            case 5:
                OrderTracking();
                break;
            case 6:
                Product();
                break;
            case 7:
                ProductItem();
                break;

            default: return;
                //וכן הלאה....
        }
        void order()
        {
            Order order = new Order();
            order.OrderDate = DateTime.Now;
            order.ShipDate = DateTime.Now;
            order.CustomerAddress = "123345";
            order.CustomerName = "dtgfdgtf";

            int choose = ReadInt("הודעה שמפרטת מה להקיש");
            switch (choose)
            {
                case 0:
                    return;
                case 1:
                    blVar.Order.Add(order);
                    break;
                case 2:
                    Order order1 = blVar.Order.GetAnObject(e => e.GetHashCode() == e.GetHashCode());//מחזיר תמיד אמת
                    Console.WriteLine("the return obj is: ", order1);
                    break;
                case 3:
                    IEnumerable<Order>? orders = blVar.Order.Get(e => e.GetHashCode() == e.GetHashCode());
                    if (orders == null)
                        Console.WriteLine("the list is empty");
                    else
                    {
                        foreach (var item in orders)
                        {
                            Console.WriteLine(item);
                        }
                    }


                    break;

                default:
                    break;
            }
        }


        void OrderForList()
        {
            Console.WriteLine("no function in here");
            //int choose = ReadInt("הודעה שמפרטת מה להקיש");
            //switch (choose)
            //{
            //    case 0:
            //        return;
            //    case 1:
            //        blVar.OrderForList.Add();
            //        break;


            //}
        }

        void OrderItem()
        {
            throw new NotImplementedException();
        }



        void OrderTracking()
        {
            int choose = ReadInt("הודעה שמפרטת מה להקיש");
            switch (choose)
            {
                case 0:
                    return;
                case 1:
                    blVar.OrderTracking.ChangeOrderStatus(1,0);//הכנסתי אי די של ההזמנה-1 ואת הסטטוס של ההזמנה-0
                    break;
            }
        }

        void Product()
        {
            throw new NotImplementedException();
        }


        void ProductItem()
        {
            throw new NotImplementedException();
        }
    }



    private void cart()
    {

    }

    private int ReadInt(string comment)
    {
        Console.WriteLine(comment);
        string? s = Console.ReadLine();
        bool ans = int.TryParse(s, out int choose);
        if (ans == false)
        {
            Console.WriteLine("Somthing went wrong");
            ReadInt(comment);
        }
        return choose;
    }
}
