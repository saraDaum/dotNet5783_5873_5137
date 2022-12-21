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
                              //  DalList.Order.Add();
                                break;
                            }

                        case (2):
                            {
                               // DalList.Order.Get();
                                break;
                            }
                        case (3):
                            {
                                // DalList.Order.Update();
                                break;
                            }
                        case (4):
                            {
                               // DalList.Order.Delete();
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

                bool convert = int.TryParse(Console.ReadLine(), out int chooseOrderItem);
                if (convert)
                {
                    switch (chooseOrderItem)
                    {
                        case (1):
                            {
                               // DalList.DALOrderItem.Add();
                                break;
                            }

                        case (2):
                            {
                               // DAL.DalList.DALOrderItem.ReadAll();
                                break;
                            }
                        case (3):
                            {
                                //DAL.DalList.DALOrderItem.update();
                                break;
                            }
                        case (4):
                            {
                                //DAL.DalList.DALOrderItem.delete();
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
                                //DalList.DALProduct.newProduct();
                                break;
                            }

                        case (2):
                            {
                               // DalList.DALProduct.read();
                                break;
                            }
                        case (3):
                            {
                                //DalList.DALProduct.update();
                                break;
                            }
                        case (4):
                            {
                               // DalList.DALProduct.delete();
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

