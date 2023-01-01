using BlImplementation;
using DAL;
using DalApi;
using DO;
using System.Data.Common;
using System.Diagnostics.Metrics;
using System.Net;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml;
using DAL_Test;

namespace DAL_Test
{
    public class Application
    {
  

        public static void Main(string[] args)
        {
            try
            {
                IDal DalListVar = new DalList();
                IBL BLVar = new BL();
                Order myOrder = new Order
                {

                    CustomerAddress = "Zhahl 13",
                    CustomerEmail = "Shira@gmail.com",
                    CustomerName = "Shira Cohen",

                };
                
                Product myProduct = new Product
                {
                    Barcode = 1234,
                    ProductName="Lulypup",
                    Category=,
                    ProductPrice=5,
                    AmountInStock = 1573,

                };

                OrderItem myOrderItem = new OrderItem
                {
                    ProductID = 1,
                    OrderID = 1,
                    ProductPrice = 1200,
                    Amount = 73,
                };



                void application()
                {
                    Console.WriteLine("Please choose from the next options:");
                    Console.WriteLine("For order menu enter 1");
                    Console.WriteLine("For order item's menu enter 2");
                    Console.WriteLine("For prouduct's menu enter 3");
                    Console.WriteLine("For to exite menu enter 4");
                    bool ans = int.TryParse(Console.ReadLine(), out int choose);
                    if (ans)
                    {
                        switch (choose)
                        {
                            case (1):
                                {
                                    order();
                                    break;
                                }
                            case (2):
                                {
                                    orderItem();
                                    break;
                                }
                            case (3):
                                {
                                    products();
                                    break;
                                }
                            case (4):
                                {
                                    exit();
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("ERROR..........");
                                    application();
                                    break;
                                }


                        }
                    }

                }

                void order()
                {
                   
                    Console.WriteLine("If you want to add an order enter 1");
                    Console.WriteLine("If you want to read an order enter 2");
                    Console.WriteLine("if you want to update an order enter 3");
                    Console.WriteLine("if you went to delete an order enter 4");
                    Console.WriteLine("if you went to exit enter 5");

                    bool convert = int.TryParse(Console.ReadLine(), out int chooseOrder);
                    if (convert)
                    {
                        switch (chooseOrder)
                        {
                            case (1):
                                {
                                   
                                    BLVar.Order.Add(myOrder);
                                    break;
                                }

                            case (2):
                                {
                                    int ID = 0;
                                    Console.WriteLine("Please enter your ID");
                                    ID = Console.Read();
                                    if (ID!=-1)
                                    BLVar.Order.GetById(ID);
                                    break;
                                }
                            case (3):
                                {
                                    BLVar.Order.Update(myOrder);
                                    break;
                                }
                            case (4):
                                {
                                    Console.WriteLine("Do you know your order number? Enter y or n.");
                                    string? ans = Console.ReadLine();
                                    if (ans == "n" || ans == "N")
                                    {
                                        OrderList.ForEach(MyOrder => print(MyOrder));
                                    }
                                    Console.WriteLine("Please enter your order number.");
                                    int orderNumber;
                                    string? orderNumStr = Console.ReadLine();
                                    bool TryParseSucceeded = int.TryParse(orderNumStr, out orderNumber);
                                    if (TryParseSucceeded)
                                    {
                                        BLVar.Order.Delete(orderNumber);

                                    }

                              
                                    break;
                                }

                            case (5):
                                {
                                    exit();
                                    break;
                                }
                        }
                    }
                }

                int orderItem()
                {
                    Console.WriteLine("if you went to add press 1");
                    Console.WriteLine("if you went to read press 2");
                    Console.WriteLine("if you went to update press 3");
                    Console.WriteLine("if you went to delete press 4");
                    Console.WriteLine("if you went to exit  press 5");

                    var convert = int.TryParse(Console.ReadLine(), out int chooseOrderItem);
                    if (convert)
                    {
                        switch (chooseOrderItem)
                        {
                            case (1):
                                {
                                    {
                                       

                                    DaListVar.OrderItem.Add(myOrderItem);
                                    break;
                                }

                            case (2):
                                {
                                   
                                    BLVar.OrderItem.GetById(ID);
                                    break;
                                }
                            case (3):
                                {
                                    BLVar.OrderItem.Update();
                                    break;
                                }
                            case (4):
                                {
                                    BLVar.OrderItem.Delete(1);
                                    break;
                                }

                            case (5):
                                {
                                    exit();
                                    break;
                                }
                        }
                    }
                }

                void products()
                {
                    Console.WriteLine("if you went to add press 1");
                    Console.WriteLine("if you went to read press 2");
                    Console.WriteLine("if you went to update press 3");
                    Console.WriteLine("if you went to delete press 4");
                    Console.WriteLine("if you went to exit  press 5");

                    bool convert = int.TryParse(Console.ReadLine(), out int chooseProuduct);
                    if (convert)
                    {
                        switch (chooseProuduct)
                        {
                            case (1):
                                {
                                    DalListVar.Product.Add(myProduct);
                                    break;
                                }

                            case (2):
                                {
                                    DalListVar.Product.GetById(1);
                                    break;
                                }
                            case (3):
                                {
                                    DalListVar.Product.Update();
                                    break;
                                }
                            case (4):
                                {
                                    DalListVar.Product.Delete(1);
                                    break;
                                }

                            case (5):
                                {
                                    exit();
                                    break;
                                }
                        }
                    }
                }

                void exit()
                {
                    Console.WriteLine("LOG OUT.......");
                    return;

                }

                application();
            }
            catch(EntityNotFoundException ex)
            {
                Console.WriteLine("EntityNotFoundException");
                Console.WriteLine(ex.Message);
            }
            catch(InvalidEntityException ex) {
                Console.WriteLine("InvalidEntityException");
                Console.WriteLine(ex.Message);  
            }
            catch(FailedToConvertException ex) {
                Console.WriteLine("FailedToConvertException");
                Console.WriteLine(ex.Message);
            }
            catch(DuplicateIdException ex) {
                Console.WriteLine("DuplicateIdException");
                Console.WriteLine(ex.Message);  
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception");
                Console.WriteLine(ex.Message);  
            }
        }

    }

}

