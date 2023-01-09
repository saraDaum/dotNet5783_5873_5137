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
            Order myOrder = new Order();
            //order.OrderDate = DateTime.Now;
            //order.ShipDate = DateTime.Now;
            //order.CustomerAddress = "123345";
            //order.CustomerName = "dtgfdgtf";

            int choose = ReadInt("הודעה שמפרטת מה להקיש");
            switch (choose)
            {
                case 0:
                    return;
                case 1:
                    blVar.Order.Add(myOrder);
                    break;
                case 2:
                    blVar.Order.GetAnObject();

                default:
                    break;
            }
        }


        void OrderForList()
        {
            int choose = ReadInt("הודעה שמפרטת מה להקיש");
            switch (choose)
            {



            }
        }

         void OrderItem()
        {
            throw new NotImplementedException();
        }



         void OrderTracking()
        {
            throw new NotImplementedException();
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

    

    private  void cart()
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
