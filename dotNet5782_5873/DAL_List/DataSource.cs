using DalApi;
using DO;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace DAL;
internal class DataSource
{
    internal static class Config
    {
        //NextOrder.get() return NextOrder+1 and advance iit by one the value.
        private static int nextOrder = 100000;
        public static int NextOrderNumber { get => nextOrder++; private set => nextOrder = value; }  //Only Order has automatic numberation.
        public static int autoCounter { get => autoCounter++; private set => autoCounter = value; }

        //A random feild
        public static readonly Random rnd = new Random();


    }

    //Constructor
    static DataSource()
    {
        try
        {
            s_Initalize();
        }
        catch
        {
            Console.WriteLine("here");
        }

    }





    /// <summary>
    /// Initialize the values.
    /// </summary>
    private static void s_Initalize()
    {
        auto_Init_Products();
        auto_Init_order();
        ProductList.Add(MyProduct);
        //orderItem
    }

    /// <summary>list
    /// Auto boot
    /// </summary>
    private static void auto_Init_order()
    {
        Order MyOrder = new Order
        {
            CustomerName = "Sara Cohen",
            CustomerEmail = "Sara0548@gmail.com",
            CustomerAddress = "Hamodia 3, Ofakim",
        };
        OrderList.Add(MyOrder);
        Order MyOrder1 = new Order
        {
            CustomerName = "Hodaya Levy",
            CustomerEmail = "Hodaya25840@gmail.com",
            CustomerAddress = "Zahal 52, Beit-Shemesh",
        };
        OrderList.Add(MyOrder1);
        Order MyOrder2 = new Order
        {
            CustomerName = "Rachel Cohen",
            CustomerEmail = "racheli.me@gmail.com",
            CustomerAddress = "Smile 103, Jerusalem",
        };
        OrderList.Add(MyOrder2);
        Order MyOrder3 = new Order
        {
            CustomerName = "Malka Seld",
            CustomerEmail = "malka_seld@gmail.com",
            CustomerAddress = "Happyness 72, Ofakim",
        };
        OrderList.Add(MyOrder3);
        Order MyOrder4 = new Order
        {
            CustomerName = "Shira Cohen",
            CustomerEmail = "Shira_052715@gmail.com",
            CustomerAddress = "Black  23, Jerusalem",
        };
        OrderList.Add(MyOrder4);
        Order MyOrder5 = new Order
        {
            CustomerName = "Yael Fadila",
            CustomerEmail = "Yael.no.yes@gmail.com",
            CustomerAddress = "Hamodia 83, Ofakim",
        };
        OrderList.Add(MyOrder5);
        Order MyOrder6 = new Order
        {
            CustomerName = "Adi Holasher",
            CustomerEmail = "Adi_123@gmail.com",
            CustomerAddress = "Flower 91, Beer - Sheva",

        };
        OrderList.Add(MyOrder6);
        Order MyOrder7 = new Order
        {
            CustomerName = "Shlomo Cohen",
            CustomerEmail = "Shlomo_120548@gmail.com",
            CustomerAddress = "Sorek 94, Cineret",
        };
        OrderList.Add(MyOrder7);
        Order MyOrder8 = new Order
        {
            CustomerName = "Zadok Cohen Zedek",
            CustomerEmail = "someone@gmail.com",
            CustomerAddress = "anivalid 137, Zfat",

        };
        OrderList.Add(MyOrder8);
        Order MyOrder9 = new Order
        {
            CustomerName = "Maya Feld",
            CustomerEmail = "M1010_m10@gmail.com",
            CustomerAddress = "Gilo 94, Duchifat",

        };
        OrderList.Add(MyOrder9);
        Order MyOrder10 = new Order
        {
            CustomerName = "Lea Daum",
            CustomerEmail = "Sara0548@gmail.com",
            CustomerAddress = "Hamodia 3, Ofakim",
        };
        OrderList.Add(MyOrder10);
        Order MyOrder11 = new Order
        {
            CustomerName = "Keren Karni",
            CustomerEmail = "karen.local@gmail.com",
            CustomerAddress = "Gefen 3, Ofakim",

        };
        OrderList.Add(MyOrder11);
        Order MyOrder12 = new Order
        {
            ID = Config.NextOrderNumber,
            CustomerName = "Jak Levy",
            CustomerEmail = "0558523510@gmail.com",
            CustomerAddress = "Zahal 512, Beit-Shemesh",

        };
        OrderList.Add(MyOrder12);
        Order MyOrder13 = new Order
        {
            CustomerName = "Akiva Gidoni",
            CustomerEmail = "smile.me@gmail.com",
            CustomerAddress = "Smile 83, Tirat - Carmel",

        };
        OrderList.Add(MyOrder13);
        Order MyOrder14 = new Order
        {
            CustomerName = "Tom Seldalom",
            CustomerEmail = "tim.tom@gmail.com",
            CustomerAddress = "Happyness 73,  Tirat - Carmel",

        };
        OrderList.Add(MyOrder14);
        Order MyOrder15 = new Order
        {
            CustomerName = "Shir bonbon",
            CustomerEmail = "Shir_0123@gmail.com",
            CustomerAddress = "My boat  19, Kiryat - Shmona",
        };
        OrderList.Add(MyOrder15);
        Order MyOrder16 = new Order
        {
            CustomerName = "Yael Fogel",
            CustomerEmail = "Yaeyes@gmail.com",
            CustomerAddress = "Tena 83, Hermon",

        };
        OrderList.Add(MyOrder16);
        Order MyOrder17 = new Order
        {
            CustomerName = "Adi Ozer",
            CustomerEmail = "Adi_Ozer@gmail.com",
            CustomerAddress = "Flower 94, Gidon",

        };
        OrderList.Add(MyOrder17);
        Order MyOrder18 = new Order
        {
            CustomerName = "Gad Jakobi",
            CustomerEmail = "Dad@gmail.com",
            CustomerAddress = "Fish 94, Cineret",

        };
        OrderList.Add(MyOrder18);
        Order MyOrder19 = new Order
        {
            CustomerName = " Dan  Zedek",
            CustomerEmail = "Dani_Dan@gmail.com",
            CustomerAddress = "Summer 137, Zfat",

        };
        OrderList.Add(MyOrder19);
        Order MyOrder20 = new Order
        {
            CustomerName = "Maya Bobi",
            CustomerEmail = "M_BOBI@gmail.com",
            CustomerAddress = "Gilo 96, Duchifat",

        };
        OrderList.Add(MyOrder20);
        Order MyOrder21 = new Order
        {
            CustomerName = "Bob Sfog",
            CustomerEmail = "bob100@gmail.com",
            CustomerAddress = "Dogilo 126, Ofakim",

        };
        OrderList.Add(MyOrder21);
        Order MyOrder22 = new Order
        {
            CustomerName = "Bob Sfog",
            CustomerEmail = "bob100@gmail.com",
            CustomerAddress = "Dogilo 126, Ofakim",
        };
        OrderList.Add(MyOrder22);


    }


    /// <summary>list
    /// Auto boot
    /// </summary>
    public static void auto_Init_Products()
    {
        var helper = new DALProduct();
        Product MyProduct1 = new Product
        {
            Barcode = helper.MakeABarcode(),
            ProductName = "Red blushe - SACARA",
            Category = Category.blushes,
            ProductPrice = 45,
            InStock = 16
        };
        ProductList.Add(MyProduct1);
        Product MyProduct2 = new Product
        {
            Barcode = helper.MakeABarcode(),
            ProductName = "Red blushe - SACARA",
            Category = Category.blushes,
            ProductPrice = 45,
            InStock = 6
        };
        ProductList.Add(MyProduct2);
        Product MyProduct3 = new Product
        {
            Barcode = helper.MakeABarcode(),
            ProductName = "Blush for a natural color in the cheeks - MAC",
            Category = Category.blushes,
            ProductPrice = 75,
            InStock = 10
        };
        ProductList.Add(MyProduct3);
        Product MyProduct4 = new Product
        {
            Barcode = helper.MakeABarcode(),
            ProductName = "A luxurious blush - Loreal",
            Category = Category.blushes,
            ProductPrice = 59,
            InStock = 13
        };
        ProductList.Add(MyProduct4);
        Product MyProduct5 = new Product
        {
            Barcode = helper.MakeABarcode(),
            ProductName = "A black eye pencil- SACARA",
            Category = Category.Pencils,
            ProductPrice = 19,
            InStock = 15
        };
        ProductList.Add(MyProduct5);
        Product MyProduct6 = new Product
        {
            Barcode = helper.MakeABarcode(),
            ProductName = "A gray eye pencil- MAC",
            Category = Category.Pencils,
            ProductPrice = 39,
            InStock = 3
        };
        ProductList.Add(MyProduct6);
        Product MyProduct7 = new Product
        {
            Barcode = helper.MakeABarcode(),
            ProductName = "A black eye pencil, hipoalerganic- MAC",
            Category = Category.Pencils,
            ProductPrice = 49,
            InStock = 4
        };
        ProductList.Add(MyProduct7);
        Product MyProduct8 = new Product
        {
            Barcode = helper.MakeABarcode(),
            ProductName = "A natural lipstick- MAC",
            Category = Category.lipstiks,
            ProductPrice = 69,
            InStock = 4
        };
        ProductList.Add(MyProduct8);
        Product MyProduct9 = new Product
        {
            Barcode = helper.MakeABarcode(),
            ProductName = "A simple lipstick- SACARA",
            Category = Category.lipstiks,
            ProductPrice = 36,
            InStock = 12
        };
        ProductList.Add(MyProduct9);
        Product MyProduct10 = new Product
        {
            Barcode = helper.MakeABarcode(),
            ProductName = "Pair lipstick, hipoalerganic - MAC",
            Category = Category.lipstiks,
            ProductPrice = 72,
            InStock = 11
        };
        ProductList.Add(MyProduct10);
        Product MyProduct11 = new Product
        {
            Barcode = helper.MakeABarcode(),
            ProductName = "Makeup number 310 - MAC",
            Category = Category.makeup,
            ProductPrice = 79,
            InStock = 13
        };
        ProductList.Add(MyProduct11);
        Product MyProduct12 = new Product
        {
            Barcode = helper.MakeABarcode(),
            ProductName = "Makeup number 350 - MAC",
            Category = Category.makeup,
            ProductPrice = 79,
            InStock = 2
        };
        ProductList.Add(MyProduct12);
        Product MyProduct13 = new Product
        {
            Barcode = helper.MakeABarcode(),
            ProductName = "Makeup number 390 - MAC",
            Category = Category.makeup,
            ProductPrice = 79,
            InStock = 4
        };
        ProductList.Add(MyProduct13);
        Product MyProduct14 = new Product
        {
            Barcode = helper.MakeABarcode(),
            ProductName = "Light Makeup  - SOFT-TOUCH",
            Category = Category.makeup,
            ProductPrice = 59,
            InStock = 3
        };
        ProductList.Add(MyProduct14);
        Product MyProduct15 = new Product
        {
            Barcode = helper.MakeABarcode(),
            ProductName = "Light bronzer - SOFT-TOUCH",
            Category = Category.bronzers,
            ProductPrice = 35,
            InStock = 3
        };
        ProductList.Add(MyProduct15);
        Product MyProduct16 = new Product
        {
            Barcode = helper.MakeABarcode(),
            ProductName = "Dramatic bronzer - SOFT-TOUCH",
            Category = Category.bronzers,
            ProductPrice = 39,
            InStock = 4
        };
        ProductList.Add(MyProduct16);
        Product MyProduct17 = new Product
        {
            Barcode = helper.MakeABarcode(),
            ProductName = "Bronzer - MAC",
            Category = Category.bronzers,
            ProductPrice = 45,
            InStock = 2
        };
        ProductList.Add(MyProduct17);
    }



    /// <summary>
    /// The arrays are in list form
    /// </summary>

    public static List<Order> OrderList = new List<Order>();
    public static List<OrderItem> OrderItemList = new List<OrderItem>();
    public static List<Product>? ProductList = new List<Product>();
    static Product MyProduct = new Product
    {
        Barcode = 87659210,
        ProductName = "Bronzer - Lori",
        Category = Category.bronzers,
        ProductPrice = 45,
        InStock = 12
    };
    //ProductList.Add(MyProduct);




}



















