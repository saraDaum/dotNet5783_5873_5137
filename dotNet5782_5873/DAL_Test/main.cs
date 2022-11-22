using DAL;
using DO;

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
                int choose = Console.Read();

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

            void order()
            {
                Console.WriteLine("If you want to add an order enter 1");
                Console.WriteLine("If you want to read an order enter 2");
                Console.WriteLine("if you want to update an order enter 3");
                Console.WriteLine("if you went to delete an order enter 4");
                Console.WriteLine("if you went to exit enter 5");

                int chooseOrder = Console.Read();

                switch (chooseOrder)
                {
                    case (1):
                        {
                            DAL.DalList.DALOrder.add();
                            break;
                        }

                    case (2):
                        {
                            DAL.DalList.DALOrder.GetType();
                            break;
                        }
                    case (3):
                        {
                            break;
                        }
                    case (4):
                        {
                            DAL.DalList.DALOrder.Delete();
                            break;
                        }

                    case (5):
                        {
                            exit();
                            break;
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

                int chooseOrderItem = Console.Read();       //Cousting!!

                switch (chooseOrderItem)
                {
                    case (1):
                        {
                            DAL.DalList.DALOrderItem.Add();
                            break;
                        }

                    case (2):
                        {
                            DAL.DalList.DALOrderItem.ReadAll();
                            break;
                        }
                    case (3):
                        {
                            DAL.DalList.DALOrderItem.update();
                            break;
                        }
                    case (4):
                        {
                            DAL.DalList.DALOrderItem.delete();
                            break;
                        }

                    case (5):
                        {
                            exit();
                            break;
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

                int chooseProuduct = Console.Read();

                switch (chooseProuduct)
                {
                    case (1):
                        {
                            DAL.DalList.DALProduct.newProduct();
                            break;
                        }

                    case (2):
                        {
                            DAL.DalList.DALProduct.read();
                            break;
                        }
                    case (3):
                        {
                            DAL.DalList.DALProduct.update();
                            break;
                        }
                    case (4):
                        {
                            DAL.DalList.DALProduct.delete();
                            break;
                        }

                    case (5):
                        {
                            exit();
                            break;
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

