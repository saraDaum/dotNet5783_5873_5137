using BlApi;
using BlImplementation;
using BO;
using Dal;
using DalApi;
using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace BlTest;

public class Program
{
    public static void Main(string[] args)
    {
        try {
            IBl? blVar = BlApi.Factory.Get();
            IDal? dal = DalApi.Factory.Get();//CHECK: Is it okay?
            int choose = ReadInt("Choose the Entity you want:\nFor exit menu enter 0,\nFor order menu enter 1,\nFor orderitem menu enter 2,\nFor Trackinorder menu enter 3,\nFor product menu enter 4,\nFor OrderForList menu enter 5,\nFor cart menu enter 6,\nFor ProductItem menu enter 7 ");//להחליף את ההודעה למפורטת
            switch (choose)
            {
                case 0: return;
                case 1:
                    order();

                    break;
                case 2:
                    OrderItem();
                    break;
                case 3:
                    OrderTracking();

                    break;
                case 4:
                    Product();
                    break;
                case 5:
                    OrderForList();
                    break;
                case 6:
                    cart();
                    break;
                case 7:
                    ProductItem();
                    break;

                default:
                    break;
                    //וכן הלאה....
            }
            void order()
            {
                Order myOrder = new Order();
                //order.OrderDate = DateTime.Now;
                //order.ShipDate = DateTime.Now;
                //order.CustomerAddress = "123345";
                //order.CustomerName = "dtgfdgtf";

                int choose = ReadInt("Choose the Entity you want:\nFor exit menu enter 0,\nFor add menu enter 1,\nFor GetAnObject menu enter 2,\nFor Get menu enter 3,\nFor Update menu enter 4,\nFor Delete menu enter 5");
                switch (choose)
                {
                    case 0:
                        return;
                    case 1:
                        int i = blVar.Order.Add(myOrder);
                        Console.WriteLine("Item entered " + i);
                        break;
                    case 2:
                        Order order1 = blVar.Order.GetAnObject(e => e.GetHashCode() == e.GetHashCode());//מחזיר תמיד אמת
                        Console.WriteLine("the return obj is: ", order1);
                        break;
                    case 3:
                        IEnumerable<Order>? orders = blVar.Order.Get(e => e.GetHashCode() == e.GetHashCode());
                        if (orders == null)
                            Console.WriteLine("the list is empty");
                        else
                        {
                            foreach (var item in orders)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        break;
                    case 4:
                        blVar.Order.Update(myOrder);
                        break;
                    case 5:
                        blVar.Order.Delete(myOrder.ID);
                        break;

                    default:
                        break;
                }
            }


            void OrderForList()
            {
                Console.WriteLine("This function doesn't implemented yet.");
                //int choose = ReadInt("הודעה שמפרטת מה להקיש");
                //switch (choose)
                //{
                //    case 0:
                //        return;
                //    case 1:
                //        blVar.OrderForList.Add();
                //        break;


                //}
            }

            void OrderItem()
            {
                OrderItem orderItem = new OrderItem();
                orderItem.Amount = 12;
                orderItem.ProductPrice = 13.4;
                orderItem.autoID = 1;
                orderItem.OrderID = 1;
                orderItem.ProductID = 1;

                int choose = ReadInt("Choose the Entity you want:\nFor exit menu enter 0,\nFor add menu enter 1,\nFor GetAnObject menu enter 2,\nFor Get menu enter 3,\nFor Update menu enter 4,\nFor Delete menu enter 5");

                switch (choose)
                {
                    case 0:
                        return;
                    case (1):
                        int i = blVar.OrderItem.Add(orderItem);
                        Console.WriteLine("Item entered " + i);
                        break;
                    case (2):
                        OrderItem orderItem1 = blVar.OrderItem.GetAnObject(e => e.GetHashCode() == e.GetHashCode());
                        Console.WriteLine("the return obj is: ", orderItem1);
                        break;
                    case 3:
                        IEnumerable<OrderItem>? orderItems = blVar.OrderItem.Get(e => e.GetHashCode() == e.GetHashCode());
                        if (orderItems == null)
                            Console.WriteLine("the list is empty");
                        else
                        {
                            foreach (var item in orderItems)
                            {
                                Console.WriteLine(item);
                            }
                        }

                        break;
                    case 4:
                        blVar.OrderItem.Update(orderItem);
                        break;
                    case (5):
                        blVar.OrderItem.Delete(orderItem.OrderID);
                        break;

                    default:
                        break;
                }
            }




            void OrderTracking()
            {
                int choose = ReadInt("Choose the Entity you want:\nFor exit menu enter 0,\nFor ChangeOrderStatus menu enter 1");
                switch (choose)
                {
                    case 0:
                        return;
                    case 1:
                        // blVar.OrderTracking.ChangeOrderStatus(, 0);//הכנסתי אי די של ההזמנה-1 ואת הסטטוס של ההזמנה-0
                        break;
                }
            }

            void Product()
            {
                Product myProduct = new Product();
                myProduct.Barcode = 10000001;
                myProduct.Category = (DO.Category)2;
                myProduct.ProductName = "blush sacara";
                myProduct.ProductPrice = 30;
                myProduct.AmountInStock = 13;


                int choose = ReadInt("Choose the Entity you want:\nFor exit menu enter 0,\nFor add menu enter 1,\nFor GetAnObject menu enter 2,\nFor Get menu enter 3,\nFor Update menu enter 4,\nFor Delete menu enter 5");
                switch (choose)
                {
                    case 0:
                        return;
                    case 1:
                        int i = blVar.Product.Add(myProduct);
                        Console.WriteLine("Item entered " + i);
                        break;
                    case 2:
                        Product product1 = blVar.Product.GetAnObject(e => e.Barcode == 10000001);
                        Console.WriteLine(product1);

                        break;
                    case 3:
                        IEnumerable<Product>? products = blVar.Product.Get(e => e.GetHashCode() == e.GetHashCode());
                        if (products == null)
                            Console.WriteLine("No itemes in product");
                        else
                            foreach (var item in products)
                            {
                                Console.WriteLine(item);
                            }

                        break;
                    case 4:
                        blVar.Product.Update(myProduct);
                        break;
                    case 5:
                        blVar.Product.Delete((int)myProduct.Barcode);
                        break;
                    default:
                        break;
                }
            }


            void ProductItem()
            {
                Console.WriteLine("This function doesn't implemented yet.");
            }
            void cart()
            {
                Console.WriteLine("This function doesn't implemented yet.");
            }


        
        }
        catch (Exception ex){
            Console.WriteLine("Error: ", ex);
        }
        }



private static int ReadInt(string comment)
{            
        Console.WriteLine(comment);
        string? s = Console.ReadLine();
        bool ans = int.TryParse(s, out  int choose);
        if (ans == false)
        {
            Console.WriteLine("Somthing went wrong");
            ReadInt(comment);
        }
        return choose;
        }     
 }

