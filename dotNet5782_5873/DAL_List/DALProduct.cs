using DO;
using System;
using static DAL.DataSource;

namespace DAL;

public struct DALProduct
{
    public static int product_Barcode_Calculation()
    {
        int barcode = Config.rnd.Next(10000000, 100000000);
        return barcode;
    }

    //This function restart the array in index "i" with a barcode.
    public static int Make_A_Barcode()
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

    /// <summary>
    /// A helper function that checks whether this barcode already exists for another product
    /// </summary>
    /// <param name="b"></param>
    /// <returns></returns>
    public static bool is_Barkode_OK(int b)
    {
        for (int i = 0; i < Config.Next_DALProduct; i++)
        {
            if (productArray[i].Barcode == b)
                return true;
        }
        return false;
    }


    public static void newProduct()
    {
        Console.WriteLine("Hello, please enter product category");
        Category AnsCategory = Console.ReadLine();
        Console.WriteLine("Please enter your ProductName ");
        string AnsProductName = Console.ReadLine();

        foreach (Product currentProduct in productArray)
        {
            if (currentProduct.Category == AnsCategory && currentProduct.ProductName == AnsProductName)
            {

                Product newProduct = new Product
                {
                    Barcode = Make_A_Barcode(),
                    Category = AnsCategory,
                    ProductPrice = currentProduct.ProductPrice,
                    ProductName = currentProduct.ProductName,


                };
                addProduct(newProduct);
            }
        }
    }




    /// <summary>
    /// ADD AN OBJECT 
    /// </summary>
    /// <param name="newProduct"></param>
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

    public static void update()
    {
        Console.WriteLine("What product do you want to update? Enter product category");
        string category= Console.ReadLine();
        Console.WriteLine("Please enter product name");
        string productName = Console.ReadLine();
    }

        public static void readAnProduct()

        {
            int productNumber;
            Console.WriteLine("Please enter your Product barcode");
            string productStr = Console.ReadLine();
            int productBarcode;
            bool TryParseSucceeded = int.TryParse(productStr, out productBarcode);
            if (TryParseSucceeded)
            {
                bool isExist = false;
                foreach (Product currentProduct in productArray)
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


        /// <summary>
        /// Update product in product's array
        /// </summary>
        /// <param name="newOne"></param>
        /// <exception cref="Exception"></exception>
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



    public static void delete()
    {
        Console.WriteLine("Do you know your product barcode? Enter y or n.");
        string ans = Console.ReadLine();
        int ProductBarcode;
        if (ans == "n" || ans == "N")
        {
            foreach (Product currentProduct in productArray)      //Print all order items for customer
            {
                currentProduct.ToString();
            }
        }
        Console.WriteLine("Please enter your product barcode.");
        string orderNumStr = Console.ReadLine();
        bool TryParseSucceeded = int.TryParse(orderNumStr, out ProductBarcode);
        if (TryParseSucceeded)
        {
            foreach (Product currentProduct in productArray)      //Searching the order item to delete it.
            {
                if (currentProduct.Barcode == ProductBarcode)
                {
                    deleteProduct(currentProduct.Barcode);
                }
                else
                {
                    Console.WriteLine("No match item.");
                }
            }
        }
        else
        {
            throw new Exception("ERROR: Failed to convert variables. Failed to receive input.");
        }
    }




    /// <summary>
    /// Delete product from product's array
    /// </summary>
    /// <param name="ProductBarcode"></param>
    /// <exception cref="Exception"></exception>
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

    public static void read()
    {
        Product[] allProducts = new Product[Config.Next_DALProduct];
        allProducts = returnAllProducts();
        foreach (Product currentProduct in productArray)      //Print all product for customer
        {
            currentProduct.ToString();
        }
    }

    /// <summary>
    /// This function returns all instances of  product 
    /// </summary>
    /// <returns></returns>
    public static Product[] returnAllProducts()
    {
        Product[] myProducts = new Product[Config.Next_DALProduct];
        for (int i = 0; i < Config.Next_DALProduct; i++)
        {
            myProducts[i] = productArray[i];
        }
        return myProducts;
    }

   
    /// <summary>
    /// This function gets an ID number and returns the corresponding Product object
    /// </summary>
    /// <param name="barcode"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
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
}