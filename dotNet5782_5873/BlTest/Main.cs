using BlApi;
using BlImplementation;
using BO;
using System;
using System.Security.Cryptography.X509Certificates;

namespace BlTest;

public class ApplicationBL
{
    public static void Main(string[] args)
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
            default: return;
                //וכן הלאה....
        }


    }

    private static void order()
    {
        int choose = ReadInt("הודעה שמפרטת מה להקיש");
        switch (choose)
        {
            case 0:
                return;
            case 1:
                break  ;

            default:
                break;
        }
    }

    private static void cart()
    {

    }

    static int ReadInt(string comment)
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
