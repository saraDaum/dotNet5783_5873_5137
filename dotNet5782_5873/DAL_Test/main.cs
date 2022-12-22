using DAL;
using DalApi;
using DO;
using System.Runtime.InteropServices;

namespace DAL_Test
{
    public class Application
    {
        public static void Main(string[] args)
        {
            IDal DalListVar = new DalList();
            Order myOrder= new Order();
            Product myProduct= new Product();
            OrderItem myOrderItem= new OrderItem();
            void application()
            {
                Console.WriteLine("Please choose from the next options:");
                Console.WriteLine("For order menu enter 1");
                Console.WriteLine("For order item's menu enter 2");
                Console.WriteLine("For prouduct's menu enter 3");
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
                                DalListVar.Order.Add();
                                break;
                            }
                            
                        case (2):
                            {
                                DalListVar.Order.GetById(1);
                                break;
                            }
                        case (3):
                            {
                                DalListVar.Order.Update(myOrder);
                                break;
                            }
                        case (4):
                            {
                                DalListVar.Order.Delete(1);
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

            void orderItem()
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
                                DalListVar.OrderItem.Add(myOrderItem);
                                break;
                            }

                        case (2):
                            {
                               DalListVar.OrderItem.GetById(1);
                                break;
                            }
                        case (3):
                            {
                                DalListVar.OrderItem.Update();
                                break;
                            }
                        case (4):
                            {
                                DalListVar.OrderItem.Delete();
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
                                DalListVar.Product.Delete();
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

    }

}

