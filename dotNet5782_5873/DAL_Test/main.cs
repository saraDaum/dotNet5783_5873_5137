using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static void Main(string[] args)
    {
         void application()
        {
            Console.WriteLine("Please choose from the next options:");
            Console.WriteLine("for order type 1");
            Console.WriteLine("for orderItem type 2");
            Console.WriteLine("for prouduct type 3");
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
                        prouduct();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("eroor..........");
                        application();
                        break;
                    }


            }

            int orderCounter = 0;

            void order()
            {

                orderCounter++;

                Console.WriteLine("if you went to add press 1");
                Console.WriteLine("if you went to read press 2");
                Console.WriteLine("if you went to update press 3");
                Console.WriteLine("if you went to delete press 4");
                Console.WriteLine("if you went to exit  press 5");

                int chooseorder = Console.Read();

                switch (chooseorder)
                {
                    case (1):
                        {
                            DataSource.addOrder();
                            break;
                        }

                    case (2):
                        {
                            DataSource.wwwww();
                            break;
                        }

                    case (3):
                        {
                            DataSource.deleteOrder();
                            break;
                        }

                    case (4):
                        {
                            exit();
                            break;
                        }
                }



                int orderItemCounter = 0;

                void orderItem()
                {

                    orderCounter++;

                    Console.WriteLine("if you went to add press 1");
                    Console.WriteLine("if you went to read press 2");
                    Console.WriteLine("if you went to update press 3");
                    Console.WriteLine("if you went to delete press 4");
                    Console.WriteLine("if you went to exit  press 5");

                    int chooseorderItem = Console.Read();

                    switch (chooseorderItem)
                    {
                        case (1):
                            {
                                DataSource.addOrder();
                                break;
                            }

                        case (2):
                            {
                                DataSource.wwwww();
                                break;
                            }

                        case (3):
                            {
                                DataSource.deleteOrderItem();
                                break;
                            }

                        case (4):
                            {
                                exit();
                                break;
                            }
                    }


                    int orderItemCounter = 0;

                    void orderItem()
                    {

                        orderCounter++;

                        Console.WriteLine("if you went to add press 1");
                        Console.WriteLine("if you went to read press 2");
                        Console.WriteLine("if you went to update press 3");
                        Console.WriteLine("if you went to delete press 4");
                        Console.WriteLine("if you went to exit  press 5");

                        int chooseprouduct = Console.Read();

                        switch (chooseprouduct)
                        {
                            case (1):
                                {
                                    DataSource.addProduct();
                                    break;
                                }

                            case (2):
                                {
                                    DataSource.wwwww();
                                    break;
                                }

                            case (3):
                                {
                                    DataSource.deleteProduct();
                                    break;
                                }

                            case (4):
                                {
                                    exit();
                                    break;
                                }
                        }


                        void exit()
                    {


                    }



                }

            }

        }

    }
}