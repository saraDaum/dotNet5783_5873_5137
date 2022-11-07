using DO;
using static DO.Product;
namespace DAL;

internal static class DataSource
{
    internal static class Config
    {
        //Static variables
        internal static int DALOrder_Length = 0;
        internal static int DALOrderItem_Length = 0;
        internal static int DALProduct_Length = 0;

        //NextOrder.get() return NextOrder+1 and doesn't advance by one the value.
        //The value will be changed in OrderId field (ID = NextOrder++)
        private static int NextOrder { get => NextOrder + 1; private set; } = 100000;//Only Order has automatic numberation.

        //A random feild
        public static readonly Random rnd = new Random();

        public static dateTime date = new();

    }

    //Constructor
    public static DataSource()
    {
        s_Initalize();
    }


    //All entity arrays
    internal static Order[] OrderArray = new Order[100];
    internal static OrderItem[] orderItemArray = new OrderItem[200];
    internal static Product[] productArray = new Product[50];

    /// <summary>
    /// Loops to initialize the values.
    ///Instead of making a separate loop for each type of item, I put them together to save loops.
    /// </summary>
    private static s_Initalize()
    {
        for (int i = 0; i < 12; i++)
        {
            Insert_Product(i);
            //init_Product(i);
            Insert_order(i);
            //init_order(i);
            init_OrderItem();
        }
        for (int i = 12; i < 43; i++)
        {
            init_order();
            init_OrderItem();
        }
    }

    //This function restart the array in inder "i" whith a barcode.
    private static void Insert_Product(int i)
    {
        int barcode = product_Barcode_Calculation();
        bool checkarcode = barcode.is_Barkode_OK();
        while (checkarcode)
        {
            barcode = product_Barcode_Calculation();
            checkarcode = barcode.is_Barkode_OK();
        }
        Console.WriteLine("Please enter category of product.\nFor eye pencial enter 0,\nfor lipsticks enter 1,\nfor blushes enter 2,\nfor bronzers enter 3,\nfor makeups enter 4\n");
        Category myCategory = Console.ReadLine();
        Console.WriteLine("Please enter name of product.");
        string myProductName = Console.ReadLine();
        Console.WriteLine("What is the price of the product?");
        double myPrice = Console.ReadLine();
        Console.WriteLine("What is the quantity in stock?");
        int myInStock = Console.ReadLine();
        //Sends to constructor
         Product myProduct(barcode,myProductName, myCategory, myPrice, myInStock);
    }

    private static void Insert_order(int i)
    {
        OrderArray[i].ID = NextOrder++;
        Console.WriteLine("Please enter your name (or the name of the person ordering).");
        OrderArray[i].CustomerName = Console.ReadLine();
        Console.WriteLine("Please enter your email address.");
        OrderArray[i].CustomerEmail = Console.ReadLine();
        Console.WriteLine("Please enter your address.");
        OrderArray[i].CustomerAddress = Console.ReadLine();
        DateTime OrderDate = DateTime.today;
        OrderArray[i].OrderDate = OrderDate;
        OrderArray[i].ShipDate = DateTime.today- new TimeSpan(Config.rnd.NextInt64(10L*1000L*1000L*3600L*24L*7L));




    }

    private static void init_order(Order myOrder)
    {
        OrderArray[Config.DALOrder_Length++] = myOrder;
    }

    private static void init_OrderItem(OrderItem myOrderItem)
    {
        orderItemArray[Config.DALOrderItem_Length++] = myOrderItem;
    }

    private static void init_Product(Product myProduct)
    {

        productArray[Config.DALProduct_Length++] = myProduct;
    }

    //This function calculate the barcode of each item.
    // In "is_Barkode_OK" function we check if this barkode already exist .
    private static int product_Barcode_Calculation()
    {
        int barode = Config.rnd.Next(0, 100000000);
        if (barode < 10)
            barode *= 10000000;
        else if (barode < 100)
            barode *= 1000000;
        else if (barode < 1000)
            barode *= 100000;
        else if (barode < 10000)
            barode *= 10000;
        else if (barode < 100000)
            barode *= 1000;
        else if (barode < 1000000)
            barode *= 100;
        else if (barode < 10000000)
            barode *= 10;
        return barode;
    }


    //A helper function that checks whether this barcode already exists for another product
    private static bool is_Barkode_OK()
    {
        for (int i = 0; i < Config.DALProduct_Length; i++)
        {
            if (productArray[i].Barcode == this)
                return true;
        }
        return false;
    }

}