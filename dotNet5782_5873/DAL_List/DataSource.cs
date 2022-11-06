using DO;

namespace DAL;

internal static class DataSource
{
    //A random feild
    private static  Random rnd = new Random();
    readonly static int num = rnd.Next();

    //All entity arrays
    internal static Order[] OrderArray = new Order[100];
    internal static OrderItem[] orderItemArray = new OrderItem[200];
    internal static Product[] productArray = new Product[50];

    private static void init_order()
    {
        ID
    }
 }