﻿using DO;
using Microsoft.VisualBasic;
using static DO.OrderItem;
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
        init_Products();
        init_order();
        init_OrderItem();
    }

    //This function restart the array in index "i" with a barcode.
    private static int Make_A_Barcode()
    {
        int barcode = product_Barcode_Calculation();
        bool checkarcode = is_Barkode_OK(barcode);
        while (checkarcode)
        {
            barcode = product_Barcode_Calculation();
            checkarcode = is_Barkode_OK(barcode);
        }
        return barcode;

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
    private static void init_order()
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

    private static void init_OrderItem()
    {
        orderItemArray[Config.Next_DALOrderItem++] = new OrderItem
        {
            //ProductID = ,
            //OrderID = ,
            //ProductPrice =,
            //Amount = ,
            //autoCounter = autoCounter.get()
        };


    }

    private static void init_Products()
    {
        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = Make_A_Barcode(),
            ProductName = "Red blushe - SACARA",
            Category = Category.blushes,
            ProductPrice = 45,
            InStock = 6
        };
        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = Make_A_Barcode(),
            ProductName = "Blush for a natural color in the cheeks - MAC",
            Category = Category.blushes,
            ProductPrice = 75,
            InStock = 4
        };
        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = Make_A_Barcode(),
            ProductName = "A luxurious blush - Loreal",
            Category = Category.blushes,
            ProductPrice = 59,
            InStock = 3
        };
        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = Make_A_Barcode(),
            ProductName = "A black eye pencil- SACARA",
            Category = Category.Pencils,
            ProductPrice = 19,
            InStock = 6
        };
        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = Make_A_Barcode(),
            ProductName = "A gray eye pencil- MAC",
            Category = Category.Pencils,
            ProductPrice = 39,
            InStock = 3
        };
        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = Make_A_Barcode(),
            ProductName = "A black eye pencil, hipoalerganic- MAC",
            Category = Category.Pencils,
            ProductPrice = 49,
            InStock = 4
        };
        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = Make_A_Barcode(),
            ProductName = "A natural lipstick- MAC",
            Category = Category.lipstiks,
            ProductPrice = 69,
            InStock = 4
        };

        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = Make_A_Barcode(),
            ProductName = "A simple lipstick- SACARA",
            Category = Category.lipstiks,
            ProductPrice = 36,
            InStock = 3
        };
        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = Make_A_Barcode(),
            ProductName = "Pair lipstick, hipoalerganic - MAC",
            Category = Category.lipstiks,
            ProductPrice = 72,
            InStock = 2
        };
        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = Make_A_Barcode(),
            ProductName = "Makeup number 310 - MAC",
            Category = Category.makeup,
            ProductPrice = 79,
            InStock = 3
        };
        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = Make_A_Barcode(),
            ProductName = "Makeup number 350 - MAC",
            Category = Category.makeup,
            ProductPrice = 79,
            InStock = 2
        };
        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = Make_A_Barcode(),
            ProductName = "Makeup number 390 - MAC",
            Category = Category.makeup,
            ProductPrice = 79,
            InStock = 4
        };
        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = Make_A_Barcode(),
            ProductName = "Light Makeup  - SOFT-TOUCH",
            Category = Category.makeup,
            ProductPrice = 59,
            InStock = 3
        };
        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = Make_A_Barcode(),
            ProductName = "Light bronzer - SOFT-TOUCH",
            Category = Category.bronzers,
            ProductPrice = 35,
            InStock = 3
        };

        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = Make_A_Barcode(),
            ProductName = "Dramatic bronzer - SOFT-TOUCH",
            Category = Category.bronzers,
            ProductPrice = 39,
            InStock = 4
        };

        productArray[Config.Next_DALProduct++] = new Product()
        {
            Barcode = Make_A_Barcode(),
            ProductName = "Bronzer - MAC",
            Category = Category.bronzers,
            ProductPrice = 45,
            InStock = 2
        };

    }
    /// <summary>
    ///This function calculate the barcode of each item.
    /// In "is_Barkode_OK" function we check if this barkode already exist .
    /// </summary>
    /// <returns></returns>
    private static int product_Barcode_Calculation()
    {
        int barcode = Config.rnd.Next(10000000, 100000000);
        return barcode;
    }

   
    /// <summary>
    /// A helper function that checks whether this barcode already exists for another product
    /// </summary>
    /// <param name="b"></param>
    /// <returns></returns>
    private static bool is_Barkode_OK(int b)
    {
        for (int i = 0; i < Config.Next_DALProduct; i++)
        {
            if (productArray[i].Barcode == b)
                return true;
        }
        return false;
    }

    /// <summary>
    /// ADD AN OBJECT FUNCTIONS
    /// </summary>
    /// <param name="newObject"></param>
    /// <returns></returns>

    public static int addProduct(Product newProduct)
    {
        bool isExist = is_Barkode_OK(newProduct.Barcode);
        if (isExist)
        {
            Console.WriteLine("A product with this barcode already exists in the database.");
            return 0;
        }
        else
        {
            productArray[Config.Next_DALProduct++] = newProduct;
            Console.WriteLine("The product entered to database successfully.\nThe barcode of the item is:  ");
        }
        return newProduct.Barcode;
    }

    public static int addOrder(Order newOrder)
    {
        bool isExist = false;
        foreach (Order currentOrder in OrderArray)
        {
            if (currentOrder.ID == newOrder.ID)
            {
                Console.WriteLine("A order with this number already exists in the database.");
                isExist = true;
            }
        }
        if (!isExist)
        {
            OrderArray[Config.Next_DALOrder++] = newOrder;
            Console.WriteLine("The order entered to database successfully.\nThe order number of the item is: ");
            return newOrder.ID;
        }
        return 0;
    }

    public static int addOrderItem(OrderItem newOrderItem)
    {
        bool isExist = false;
        foreach (OrderItem currentOrderItem in orderItemArray)
        {
            if (currentOrderItem.OrderID == newOrderItem.OrderID && currentOrderItem.ProductID == newOrderItem.ProductID)
            {
                Console.WriteLine("An order item with this details already exists in the database.");
                isExist = true;
            }
        }
        if (!isExist)
        {
            orderItemArray[Config.Next_DALOrderItem++] = newOrderItem;
            Console.WriteLine("The order item entered to database successfully.\nThe order item number of the item is: ");
            return newOrderItem.OrderItemCounter;
        }
        return 0;
    }

    /// <summary>
    /// RETURN OBJECT FUNCTIONS
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>

    //This function get an ID number and returns the corresponding Order object
    public static Order ReturnOrderObject(int id)
    {
        foreach (Order currentOrder in OrderArray)
        {
            if (currentOrder.ID == id)
                return currentOrder;
        }
        Order emptyOrder = new Order
        {
            ID = Config.NextOrderNumber,
            CustomerName = "",
            CustomerEmail = "",
            CustomerAddress = "",
            OrderDate = DateTime.Today,
            ShipDate = DateTime.Today,
            DeliveryDate = DateTime.Today
        };
        return emptyOrder;
    }

    //This function gets an ID number and returns the corresponding Product object
    public static Product ReturnProductObject(int barcode)
    {
        bool flag = false;
        foreach (Product currentProduct in productArray)
        {
            if (currentProduct.Barcode == barcode)
            {
                flag = true;
                return currentProduct;
            }
        }
        Product emptyProduct = new Product
        {
            Barcode = 0000000,
            ProductName = "",
            Category = Category.blushes,
            ProductPrice = 0,
            InStock = 0
        };
        if (!flag)
            throw new Exception("ERROR: This product doesn't found.\n(Check yourself. Maybe you just have a typo. ");


        return emptyProduct;
    }

    /// <summary>
    /// RETURN FUNCTIONS
    /// </summary>
    /// <returns></returns>

    //This function returns all instances of  product 
    public static Product[] returnAllProducts()
    {
        Product[] myProducts = new Product[Config.Next_DALProduct];
        for (int i = 0; i < Config.Next_DALProduct; i++)
        {
            myProducts[i] = productArray[i];
        }
        return myProducts;
    }

    //This function returns all instances of  order 
    public static Order[] returnAllOrders()
    {
        Order[] myOrders = new Order[Config.Next_DALOrder];
        for (int i = 0; i < Config.Next_DALOrder; i++)
        {
            myOrders[i] = OrderArray[i];
        }
        return myOrders;
    }

    //This function returns all instances of orderItem 
    public static OrderItem[] returnAllOrderItems()
    {
        OrderItem[] myOrderItems = new OrderItem[Config.Next_DALOrderItem];
        for (int i = 0; i < Config.Next_DALOrder; i++)
        {
            myOrderItems[i] = orderItemArray[i];
        }
        return myOrderItems;
    }

    /// <summary>
    /// UPDATING FUNCTIONS
    /// </summary>
    /// <param name="newOne"></param>
    /// <exception cref="Exception"></exception>

    //Update orderItem in orderItem's array
    public static void updateOrderItem(OrderItem newOne)
    {
        bool existFlag = false;
        for (int i = 0; i < Config.Next_DALOrderItem; i++)
        {
            if (orderItemArray[i].OrderID == newOne.OrderID && orderItemArray[i].ProductID == newOne.ProductID)
            {
                existFlag = true;
                orderItemArray[i] = newOne;
                Console.WriteLine("Item has been successfully update");
            }
            if (existFlag == false)
            {
                throw new Exception("ERROR: This item doesn't found. No action happened.\n(Check yourself. Maybe you just have a typo. ");
            }
        }
    }

    //Update order in order's array
    public static void updateOrder(Order newOne)
    {
        bool existFlag = false;
        for (int i = 0; i < Config.Next_DALOrder; i++)
        {
            if (OrderArray[i].ID == newOne.ID)
            {
                existFlag = true;
                OrderArray[i] = newOne;
                Console.WriteLine("Order has been successfully update");
            }
            if (existFlag == false)
            {
                throw new Exception("ERROR: This order doesn't found. No action happened.\n(Check yourself. Maybe you just have a typo. ");
            }
        }
    }

    //Update product in product's array
    public static void updateProduct(Product newOne)
    {
        bool existFlag = false;
        for (int i = 0; i < Config.Next_DALProduct; i++)
        {
            if (productArray[i].Barcode == newOne.Barcode)
            {
                existFlag = true;
                productArray[i] = newOne;
                Console.WriteLine("Product has been successfully update");
            }
            if (existFlag == false)
            {
                throw new Exception("ERROR: This product doesn't found. No action happened.\n(Check yourself. Maybe you just have a typo. ");
            }
        }
    }

    /// <summary>
    /// DELETE FUNCTIONS
    /// </summary>
    /// <param name="ID code"></param>
    /// <exception cref="Exception"></exception>

    //Delete product from product's array
    static void deleteProduct(int ProductBarcode)
    {
        bool existFlag = false;
        for (int i = 0; i < Config.Next_DALProduct; i++)
        {
            if (productArray[i].Barcode == ProductBarcode)
            {
                existFlag = true;
                productArray[i] = productArray[Config.Next_DALProduct];
                Config.Next_DALProduct--;
                Console.WriteLine("The product has been successfully deleted");

            }
            if (existFlag == false)
            {
                throw new Exception("ERROR: This product dosen't exist in stock\n(Check yourself. Maybe you just have a typo. ");
            }
        }

    }

    //Delete order from order's array
    static void deleteOrder(int OrderNumber)
    {
        bool existFlag = false;
        for (int i = 0; i < Config.Next_DALOrder; i++)
        {
            if (OrderArray[i].ID == OrderNumber)
            {
                existFlag = true;
                OrderArray[i] = OrderArray[Config.Next_DALOrder];
                Config.Next_DALOrder--;
                Console.WriteLine("The order has been successfully deleted");

            }
            if (existFlag == false)
            {
                throw new Exception("ERROR: This order dosen't exist in database.\n(Check yourself. Maybe you just have a typo. ");
            }
        }
    }

    //Delete orderItem from orderItem's array
    static void deleteOrderItem(int OrderNumber, int productBarcode)
    {
        bool existFlag = false;
        for (int i = 0; i < Config.Next_DALOrderItem; i++)
        {
            if (orderItemArray[i].OrderID == OrderNumber && orderItemArray[i].ProductID == productBarcode)
            {
                existFlag = true;
                orderItemArray[i] = orderItemArray[Config.Next_DALOrderItem];
                Config.Next_DALOrderItem--;
                Console.WriteLine("The item has been successfully deleted");
            }
            if (existFlag == false)
            {
                throw new Exception("ERROR: This item doesn't found.\n(Check yourself. Maybe you just have a typo. ");
            }
        }
    }
}


