using DO;
using static DAL.DataSource;

namespace DAL;

internal struct DALProduct : DalApi.ICrud<Product>
{
    public Product Get(int id)
    {
        throw new NotImplementedException();
    }
    public Product Add(Product entity)
    {
        throw new NotImplementedException();
    }

    //לבדוק האם חובה להחזיר את הברקוד או להדפיס אותו
    /// <summary>list
    /// This function create a product object and enter it to the array.
    /// </summary>
    /// <returns></returns>
    public int Add1()
    {
        Category category = new Category();
        Console.WriteLine("Hello, please enter product category.\n Options are: Pencils, \r\n        lipstiks,\r\n        blushes,\r\n        bronzers,\r\n        makeup,");
        string AnsCategory = Console.ReadLine();
        switch (AnsCategory)
        {
            case ("Pencils"):
                {
                    category = (Category)0;
                    break;
                }
            case ("lipstiks"):
                {
                    category = (Category)1;

                    break;
                }
            case (" blushes"):
                {
                    category = (Category)2;
                    break;
                }
            case ("bronzers"):

                {
                    category = (Category)3;
                    break;
                }
            case ("makeup"):
                {
                    category = (Category)4;
                    break;
                }
            default:
                break;
        }
        Console.WriteLine("Please enter your ProductName ");
        string AnsProductName = Console.ReadLine();
        Console.WriteLine("How much does the item cost? ");
        string strPrice = Console.ReadLine();
        Console.WriteLine("What is the quantity in stock? ");
        double price = Convert.ToDouble(strPrice);
        string strAmount = Console.ReadLine();
        int amount = Convert.ToInt32(strAmount); ;
        Product newProduct = new Product
        {
            Barcode = MakeABarcode(),
            ProductName = AnsProductName,
            Category = category,
            ProductPrice = price,
            InStock = amount,


        };

        bool isExist = is_Barkode_OK(newProduct.Barcode);
        if (isExist)
        {
            Console.WriteLine("A product with this barcode already exists in the database.");
            return 0;
        }
        else
        {
            ProductList.Add(newProduct);
            Console.WriteLine("The product entered to database successfully.\nThe barcode of the item is: {0} ", newProduct.Barcode);
        }
        return newProduct.Barcode;
    }

    /// <summary>list
    /// This function restart the array in index "i" with a barcode.
    /// </summary>
    /// <returns></returns>
    public static int MakeABarcode()
    {
        int barcode = Config.rnd.Next(10000000, 100000000);
        bool checkarcode = is_Barkode_OK(barcode);
        while (checkarcode)
        {
            barcode = Config.rnd.Next(10000000, 100000000);
            checkarcode = is_Barkode_OK(barcode);
        }
        return barcode;

    }

    /// <summary>list
    /// A helper function that checks whether this barcode already exists for another product
    /// </summary>
    /// <param name="b"></param>
    /// <returns></returns>
    public static bool is_Barkode_OK(int barcode)
    {
        int index = ProductList.FindIndex(MyProduct => MyProduct.Barcode == barcode);
        if (index == -1)
        {
            throw new Exception("Object dosen't exist");
        }
        else
        {
            return true;

        }
        return false;
    }

    public static void ReadAnProduct(int id)

    {
        int productNumber;
        Console.WriteLine("Please enter your Product barcode");
        string productStr = Console.ReadLine();
        int productBarcode;
        bool TryParseSucceeded = int.TryParse(productStr, out productBarcode);
        if (TryParseSucceeded)
        {
            bool isExist = false;
            foreach (Product currentProduct in ProductArray)
            {
                if (currentProduct.Barcode == productBarcode)
                {
                    isExist = true;
                    currentProduct.ToString();
                }
                if (isExist)
                    Console.WriteLine("This order dosen't exist in database.\n(Check yourself. Maybe you just have a typo.)");
            }
        }
        else
        {
            throw new Exception("ERROR: Failed to convert variables. Failed to receive input.");
        }
    }

    public void Delete()
    {
        Console.WriteLine("Do you know your product barcode? Enter y or n.");
        string ans = Console.ReadLine();
        int ProductBarcode;
        if (ans == "n" || ans == "N")
        {
            ProductList.ForEach(p=>print(p));     //Print all order items for customer
        }
        Console.WriteLine("Please enter your product barcode.");
        string orderNumStr = Console.ReadLine();
        bool TryParseSucceeded = int.TryParse(orderNumStr, out ProductBarcode);
        if (TryParseSucceeded)
        {
            int index = ProductList.FindIndex(obj => obj.Barcode == ProductBarcode);
            Delete(index);
        }
        else
        {
            throw new Exception("ERROR: Failed to convert variables. Failed to receive input.");
        }
    }

/// <summary>list
/// Delete an Order object
/// </summary>
/// <param name="id"></param>
/// <exception cref="Exception"></exception>
public void Delete(int id)
{
    ProductList.RemoveAt(id);

}

public static void print(Product obj)
{
    Console.WriteLine(obj);
}
/// <summary>
/// Delete product from product's array
/// </summary>
/// <param name="ProductBarcode"></param>
/// <exception cref="Exception"></exception>


public static void read()
{
    
}

/// <summary>
/// This function returns all instances of  product 
/// </summary>
/// <returns></returns>




