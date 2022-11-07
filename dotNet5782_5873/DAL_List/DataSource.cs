using DO;

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
        public static int NextOrder { get => NextOrder + 1; private set; } = 0;//Only Order has automatic numberation.

        //A random feild
        private static readonly Random rnd = new Random();
       
    }

    //Constructor
    public static DataSource()
    {

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
            init_Product();
            init_order();
            init_OrderItem();
        }
        for (int i = 0; i < 30; i++)
        {
            init_order();
            init_OrderItem();
        }
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

    private static int find_OrderID() {
        int OrderID = rnd.Next();

    }

    
    private static bool is_Barkode_OK(int barcode)
    {
        for(int i=0; i<Config.DALProduct_Length; i++)
        {
            if (productArray[i].Barcode == barcode)
                return true;
        }
        return false;
    }
}