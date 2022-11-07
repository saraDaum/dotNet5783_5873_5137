using DO;

namespace DAL;

internal static class DataSource
{
    internal static class Config {
        //Static variables
        internal static int DALOrder_Length = 0;
        internal static int DALOrderItem_Length = 0;
        internal static int DALProduct_Length = 0;

        public static int NextOrder { get => ++NextOrder; private set; } = 0;//Only Order has automatic numberation.

    }

    //Constructor
    public static DataSource()
    {

    }

    /// <summary>
    /// Loops to initialize the values.
    ///Instead of making a separate loop for each type of item, I put them together to save loops.
    /// </summary>
    private static s_Initalize()
    {
        for(int i=0; i<12; i++)
        {
            init_Product();
            init_order();
            init_OrderItem();
        }
        for(int i=0; i<30; i++)
        {
            init_order();
            init_OrderItem();
        }
    }

    //A random feild
    private static  Random rnd = new Random();
    readonly static int num = rnd.Next();

    //All entity arrays
    internal static Order[] OrderArray = new Order[100];
    internal static OrderItem[] orderItemArray = new OrderItem[200];
    internal static Product[] productArray = new Product[50];

    
    
    private static void init_order(Order myOrder)
    {
        OrderArray[DALOrder_Length++] = myOrder;
    }
   
    private static void init_OrderItem(OrderItem myOrderItem)
    {
        orderItemArray[DALOrderItem_Length++] = myOrderItem;
    }

    private static void init_Product(Product myProduct)
    {
        productArray[DALProduct_Length++] = myProduct;
    }
}