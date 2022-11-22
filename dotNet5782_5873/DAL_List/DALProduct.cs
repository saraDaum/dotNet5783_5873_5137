﻿using static DAL.DataSource;
namespace DAL;
using DO;
internal class DALProduct : DalApi.ICrud<Product>  
{
    private Product NULL;

    public Product Get(int barcode)
    {
        int index = ProductList.FindIndex(current => current.Barcode == barcode);
        if (index != -1)
        {
            return ProductList[index];
        }
        return NULL;
    }


    /// <summary>list
    /// This function create a product object and enter it to the array.
    /// </summary>
    /// <returns></returns>
    public int Add()
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
            Add(newProduct);
        }
        return newProduct.Barcode;
    }

    public int Add(Product newProduct)
    {
        ProductList.Add(newProduct);
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
            foreach (DALProduct currentProduct in ProductList)
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
            ProductList.ForEach(p => print(p));     //Print all order items for customer
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
        Console.WriteLine("The item has been successfully removed");
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


    public void Update()
    {
        Console.WriteLine("Do you know your product's barcode? Enter y or n.");
        string ans = Console.ReadLine();
        //int OrderNumber, productBarcode;
        if (ans == "n" || ans == "N")
        {
            ProductList.ForEach(obj => print(obj));
        }
        Console.WriteLine("Please enter your  product's barcode.");
        string strBarcode = Console.ReadLine();
        int barcode;
        bool TryParseSucceeded = int.TryParse(strBarcode, out barcode);
        if (TryParseSucceeded)
        {
            Console.WriteLine("What do you want to update?\nTo update product name enter 1, To update product price enter 2, To update product amount in stock enter 2\n");
            string answer = Console.ReadLine();
            int choose;
            bool TryParseSucceeded2 = int.TryParse(answer, out choose);
            if (TryParseSucceeded2)
            {
                int index = ProductList.FindIndex(obj => obj.Barcode == barcode);         //Searching the item to make an update object
                if (index != -1)
                {
                    switch (choose)
                    {
                        case (1):
                            {
                                Console.WriteLine("O.K. Please enter the new name.");
                                string name = Console.ReadLine();
                                Product updateOne = new Product
                                {
                                    Barcode = ProductList[index].Barcode,
                                    ProductName = name,
                                    Category = ProductList[index].Category,
                                    ProductPrice = ProductList[index].ProductPrice,
                                    InStock = ProductList[index].InStock


                                };
                                Update(updateOne);
                                break;
                            }
                        case (2):
                            {
                                Console.WriteLine("O.K. Please enter the new price.");
                                string strPrice = Console.ReadLine();
                                int newPrice;
                                bool tryToConvert = int.TryParse(strPrice, out newPrice);
                                if (tryToConvert)
                                {
                                    Product updateOne = new Product
                                    {
                                        Barcode = ProductList[index].Barcode,
                                        ProductName = ProductList[index].ProductName,
                                        Category = ProductList[index].Category,
                                        ProductPrice = newPrice,
                                        InStock = ProductList[index].InStock


                                    };
                                    Update(updateOne);
                                    break;
                                }
                                else
                                {
                                    throw new Exception("ERROR: Failed to convert variables. Failed to receive input.\nAN ERROR OCCURED IN UPDATE FUNCTION:PRODUCT");
                                }
                            }
                        case 3:
                            {
                                Console.WriteLine("O.K. Please enter the new amount in stock.");
                                string strAmount = Console.ReadLine();
                                int newInStock;
                                bool convertAmount = int.TryParse(strAmount, out newInStock);
                                if (convertAmount)
                                {
                                    Product updateOne = new Product
                                    {
                                        Barcode = ProductList[index].Barcode,
                                        ProductName = ProductList[index].ProductName,
                                        Category = ProductList[index].Category,
                                        ProductPrice = ProductList[index].ProductPrice,
                                        InStock = newInStock
                                    };
                                    Update(updateOne);
                                    break;
                                }
                                else
                                {
                                    throw new Exception("ERROR: Failed to convert variables. Failed to receive input.\nAN ERROR OCCURED IN UPDATE FUNCTION:PRODUCT");
                                }
                            }
                    }
                }
                else
                {
                    Console.WriteLine("No order item match.");
                }
            }

            else
            {
                throw new Exception("ERROR: Failed to convert variables. Failed to receive input.\nAN ERROR OCCURED IN UPDATE FUNCTION:PRODUCT");
            }
        }
        else
        {
            throw new Exception("ERROR: Failed to convert variables. Failed to receive input.\nAN ERROR OCCURED IN UPDATE FUNCTION:PRODUCT");
        }
    }

    /// <summary>
    /// This function gets an Product object and update it.
    /// </summary>
    /// <param name="myOrderItem"></param>
    public void Update(Product myProduct)
    {
        int index = ProductList.FindIndex(obj => obj.Barcode == myProduct.Barcode);         //Searching the item to make an update object
        if (index != -1)
        {
            ProductList[index] = myProduct;
            Console.WriteLine("Item has been successfully updated. ");
        }
        else
        {
            Console.WriteLine("No match item.");
        }
    }
}

/// <summary>
/// This function returns all instances of  product 
/// </summary>
/// <returns></returns>




