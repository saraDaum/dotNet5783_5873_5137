using DO;
namespace DAL;
internal static class DataSource
{
    internal static class Config
    {
        //Static variables
        internal static int Next_DALOrder = 0;
        internal static int Next_DALOrderItem = 0;
        internal static int Next_DALProduct = 0;


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
        s_Initalize();
    }


    //All entity arrays
    internal static Order[] OrderArray = new Order[100];
    internal static OrderItem[] orderItemArray = new OrderItem[200];
    internal static Product[] productArray = new Product[50];

    /// <summary>
    /// Initialize the values.
    /// </summary>
    private static void s_Initalize()
    {
        auto_Init_Products();
        auto_Init_order();
        //orderItem
    }
      



    //DELETE!!
    private static void Insert_order(int i)
    {
        OrderArray[i].ID = Config.NextOrderNumber;
        OrderArray[i].CustomerName = Console.ReadLine();
        OrderArray[i].CustomerEmail = Console.ReadLine();
        OrderArray[i].CustomerAddress = Console.ReadLine();
        DateTime OrderDate = DateTime.Today;
        OrderArray[i].OrderDate = OrderDate;
        OrderArray[i].ShipDate = DateTime.Today + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 7L));

    }

    //DONE!!
    private static void auto_Init_order()
    {
        OrderArray[Config.Next_DALOrder++] = new Order
        {
            ID = Config.NextOrderNumber,
            CustomerName = "Sara Cohen",
            CustomerEmail = "Sara0548@gmail.com",
            CustomerAddress = "Hamodia 3, Ofakim",
            OrderDate = DateTime.Today,
            ShipDate = DateTime.Today + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 3L)),
            DeliveryDate = DateTime.Now + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 10L))
        };
        OrderArray[Config.Next_DALOrder++] = new Order
        {
            ID = Config.NextOrderNumber,
            CustomerName = "Hodaya Levy",
            CustomerEmail = "Hodaya25840@gmail.com",
            CustomerAddress = "Zahal 52, Beit-Shemesh",
            OrderDate = DateTime.Today,
            ShipDate = DateTime.Today + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 3L)),
            DeliveryDate = DateTime.Now + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 10L))
        };
        OrderArray[Config.Next_DALOrder++] = new Order
        {
            ID = Config.NextOrderNumber,
            CustomerName = "Rachel Cohen",
            CustomerEmail = "racheli.me@gmail.com",
            CustomerAddress = "Smile 103, Jerusalem",
            OrderDate = DateTime.Today,
            ShipDate = DateTime.Today + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 3L)),
            DeliveryDate = DateTime.Now + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 10L))
        };
        OrderArray[Config.Next_DALOrder++] = new Order
        {
            ID = Config.NextOrderNumber,
            CustomerName = "Malka Seld",
            CustomerEmail = "malka_seld@gmail.com",
            CustomerAddress = "Happyness 72, Ofakim",
            OrderDate = DateTime.Today,
            ShipDate = DateTime.Today + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 3L)),
            DeliveryDate = DateTime.Now + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 10L))
        };
        OrderArray[Config.Next_DALOrder++] = new Order
        {
            ID = Config.NextOrderNumber,
            CustomerName = "Shira Cohen",
            CustomerEmail = "Shira_052715@gmail.com",
            CustomerAddress = "Black  23, Jerusalem",
            OrderDate = DateTime.Today,
            ShipDate = DateTime.Today + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 3L)),
            DeliveryDate = DateTime.Now + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 10L))
        };
        OrderArray[Config.Next_DALOrder++] = new Order
        {
            ID = Config.NextOrderNumber,
            CustomerName = "Yael Fadila",
            CustomerEmail = "Yael.no.yes@gmail.com",
            CustomerAddress = "Hamodia 83, Ofakim",
            OrderDate = DateTime.Today,
            ShipDate = DateTime.Today + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 3L)),
            DeliveryDate = DateTime.Now + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 10L))
        };
        OrderArray[Config.Next_DALOrder++] = new Order
        {
            ID = Config.NextOrderNumber,
            CustomerName = "Adi Holasher",
            CustomerEmail = "Adi_123@gmail.com",
            CustomerAddress = "Flower 91, Beer - Sheva",
            OrderDate = DateTime.Today,
            ShipDate = DateTime.Today + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 3L)),
            DeliveryDate = DateTime.Now + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 10L))
        };
        OrderArray[Config.Next_DALOrder++] = new Order
        {
            ID = Config.NextOrderNumber,
            CustomerName = "Shlomo Cohen",
            CustomerEmail = "Shlomo_120548@gmail.com",
            CustomerAddress = "Sorek 94, Cineret",
            OrderDate = DateTime.Today,
            ShipDate = DateTime.Today + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 3L)),
            DeliveryDate = DateTime.Now + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 10L))
        };
        OrderArray[Config.Next_DALOrder++] = new Order
        {
            ID = Config.NextOrderNumber,
            CustomerName = "Zadok Cohen Zedek",
            CustomerEmail = "someone@gmail.com",
            CustomerAddress = "anivalid 137, Zfat",
            OrderDate = DateTime.Today,
            ShipDate = DateTime.Today + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 3L)),
            DeliveryDate = DateTime.Now + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 10L))
        };
        OrderArray[Config.Next_DALOrder++] = new Order
        {
            ID = Config.NextOrderNumber,
            CustomerName = "Maya Feld",
            CustomerEmail = "M1010_m10@gmail.com",
            CustomerAddress = "Gilo 94, Duchifat",
            OrderDate = DateTime.Today,
            ShipDate = DateTime.Today + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 3L)),
            DeliveryDate = DateTime.Now + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 10L))
        };
        OrderArray[Config.Next_DALOrder++] = new Order
        {
            ID = Config.NextOrderNumber,
            CustomerName = "Lea Daum",
            CustomerEmail = "Sara0548@gmail.com",
            CustomerAddress = "Hamodia 3, Ofakim",
            OrderDate = DateTime.Today,
            ShipDate = DateTime.Today + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 3L)),
            DeliveryDate = DateTime.Now + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 10L))
        };
        OrderArray[Config.Next_DALOrder++] = new Order
        {
            ID = Config.NextOrderNumber,
            CustomerName = "Keren Karni",
            CustomerEmail = "karen.local@gmail.com",
            CustomerAddress = "Gefen 3, Ofakim",
            OrderDate = DateTime.Today,
            ShipDate = DateTime.Today + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 3L)),
            DeliveryDate = DateTime.Now + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 10L))
        };
        OrderArray[Config.Next_DALOrder++] = new Order
        {
            ID = Config.NextOrderNumber,
            CustomerName = "Jak Levy",
            CustomerEmail = "0558523510@gmail.com",
            CustomerAddress = "Zahal 512, Beit-Shemesh",
            OrderDate = DateTime.Today,
            ShipDate = DateTime.Today + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 3L)),
            DeliveryDate = DateTime.Now + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 10L))
        };
        OrderArray[Config.Next_DALOrder++] = new Order
        {
            ID = Config.NextOrderNumber,
            CustomerName = "Akiva Gidoni",
            CustomerEmail = "smile.me@gmail.com",
            CustomerAddress = "Smile 83, Tirat - Carmel",
            OrderDate = DateTime.Today,
            ShipDate = DateTime.Today + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 3L)),
            DeliveryDate = DateTime.Now + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 10L))
        };
        OrderArray[Config.Next_DALOrder++] = new Order
        {
            ID = Config.NextOrderNumber,
            CustomerName = "Tom Seldalom",
            CustomerEmail = "tim.tom@gmail.com",
            CustomerAddress = "Happyness 73,  Tirat - Carmel",
            OrderDate = DateTime.Today,
            ShipDate = DateTime.Today + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 3L)),
            DeliveryDate = DateTime.Now + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 10L))
        };
        OrderArray[Config.Next_DALOrder++] = new Order
        {
            ID = Config.NextOrderNumber,
            CustomerName = "Shir bonbon",
            CustomerEmail = "Shir_0123@gmail.com",
            CustomerAddress = "My boat  19, Kiryat - Shmona",
            OrderDate = DateTime.Today,
            ShipDate = DateTime.Today + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 3L)),
            DeliveryDate = DateTime.Now + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 10L))
        };
        OrderArray[Config.Next_DALOrder++] = new Order
        {
            ID = Config.NextOrderNumber,
            CustomerName = "Yael Fogel",
            CustomerEmail = "Yaeyes@gmail.com",
            CustomerAddress = "Tena 83, Hermon",
            OrderDate = DateTime.Today,
            ShipDate = DateTime.Today + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 3L)),
            DeliveryDate = DateTime.Now + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 10L))
        };
        OrderArray[Config.Next_DALOrder++] = new Order
        {
            ID = Config.NextOrderNumber,
            CustomerName = "Adi Ozer",
            CustomerEmail = "Adi_Ozer@gmail.com",
            CustomerAddress = "Flower 94, Gidon",
            OrderDate = DateTime.Today,
            ShipDate = DateTime.Today + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 3L)),
            DeliveryDate = DateTime.Now + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 10L))
        };
        OrderArray[Config.Next_DALOrder++] = new Order
        {
            ID = Config.NextOrderNumber,
            CustomerName = "Gad Jakobi",
            CustomerEmail = "Dad@gmail.com",
            CustomerAddress = "Fish 94, Cineret",
            OrderDate = DateTime.Today,
            ShipDate = DateTime.Today + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 3L)),
            DeliveryDate = DateTime.Now + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 10L))
        };
        OrderArray[Config.Next_DALOrder++] = new Order
        {
            ID = Config.NextOrderNumber,
            CustomerName = " Dan  Zedek",
            CustomerEmail = "Dani_Dan@gmail.com",
            CustomerAddress = "Summer 137, Zfat",
            OrderDate = DateTime.Today,
            ShipDate = DateTime.Today + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 3L)),
            DeliveryDate = DateTime.Now + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 10L))
        };
        OrderArray[Config.Next_DALOrder++] = new Order
        {
            ID = Config.NextOrderNumber,
            CustomerName = "Maya Bobi",
            CustomerEmail = "M_BOBI@gmail.com",
            CustomerAddress = "Gilo 96, Duchifat",
            OrderDate = DateTime.Today,
            ShipDate = DateTime.Today + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 3L)),
            DeliveryDate = DateTime.Now + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 10L))
        };
        OrderArray[Config.Next_DALOrder++] = new Order
        {
            ID = Config.NextOrderNumber,
            CustomerName = "Bob Sfog",
            CustomerEmail = "bob100@gmail.com",
            CustomerAddress = "Dogilo 126, Ofakim",
            OrderDate = DateTime.Today,
            ShipDate = DateTime.Today + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 3L)),
            DeliveryDate = DateTime.Now + new TimeSpan(Config.rnd.NextInt64(10L * 1000L * 1000L * 3600L * 24L * 10L))
        };

    }

    private static void auto_Init_Products()
    {
        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = DALProduct.Make_A_Barcode(),
            ProductName = "Red blushe - SACARA",
            Category = Category.blushes,
            ProductPrice = 45,
            InStock = 6
        };
        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = DALProduct.Make_A_Barcode(),
            ProductName = "Blush for a natural color in the cheeks - MAC",
            Category = Category.blushes,
            ProductPrice = 75,
            InStock = 4
        };
        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = DALProduct.Make_A_Barcode(),
            ProductName = "A luxurious blush - Loreal",
            Category = Category.blushes,
            ProductPrice = 59,
            InStock = 3
        };
        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = DALProduct.Make_A_Barcode(),
            ProductName = "A black eye pencil- SACARA",
            Category = Category.Pencils,
            ProductPrice = 19,
            InStock = 6
        };
        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = DALProduct.Make_A_Barcode(),
            ProductName = "A gray eye pencil- MAC",
            Category = Category.Pencils,
            ProductPrice = 39,
            InStock = 3
        };
        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = DALProduct.Make_A_Barcode(),
            ProductName = "A black eye pencil, hipoalerganic- MAC",
            Category = Category.Pencils,
            ProductPrice = 49,
            InStock = 4
        };
        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = DALProduct.Make_A_Barcode(),
            ProductName = "A natural lipstick- MAC",
            Category = Category.lipstiks,
            ProductPrice = 69,
            InStock = 4
        };

        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = DALProduct.Make_A_Barcode(),
            ProductName = "A simple lipstick- SACARA",
            Category = Category.lipstiks,
            ProductPrice = 36,
            InStock = 3
        };
        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = DALProduct.Make_A_Barcode(),
            ProductName = "Pair lipstick, hipoalerganic - MAC",
            Category = Category.lipstiks,
            ProductPrice = 72,
            InStock = 2
        };
        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = DALProduct.Make_A_Barcode(),
            ProductName = "Makeup number 310 - MAC",
            Category = Category.makeup,
            ProductPrice = 79,
            InStock = 3
        };
        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = DALProduct.Make_A_Barcode(),
            ProductName = "Makeup number 350 - MAC",
            Category = Category.makeup,
            ProductPrice = 79,
            InStock = 2
        };
        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = DALProduct.Make_A_Barcode(),
            ProductName = "Makeup number 390 - MAC",
            Category = Category.makeup,
            ProductPrice = 79,
            InStock = 4
        };
        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = DALProduct.Make_A_Barcode(),
            ProductName = "Light Makeup  - SOFT-TOUCH",
            Category = Category.makeup,
            ProductPrice = 59,
            InStock = 3
        };
        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = DALProduct.Make_A_Barcode(),
            ProductName = "Light bronzer - SOFT-TOUCH",
            Category = Category.bronzers,
            ProductPrice = 35,
            InStock = 3
        };

        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = DALProduct.Make_A_Barcode(),
            ProductName = "Dramatic bronzer - SOFT-TOUCH",
            Category = Category.bronzers,
            ProductPrice = 39,
            InStock = 4
        };

        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = DALProduct.Make_A_Barcode(),
            ProductName = "Bronzer - MAC",
            Category = Category.bronzers,
            ProductPrice = 45,
            InStock = 2
        };

    }
















}


