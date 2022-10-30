// See https://aka.ms/new-console-template for more information
using System;

namespace stage0
{
    partial class Program
    {
        static void Main (string[] rags)
        {
            welcome5873();
            welcome5874();
            Console.ReadKey();
        }

        private static void welcome5873()
        {
            Console.Write("Enter your name, Please.");
            string userName = Console.ReadLine();
            Console.WriteLine("{0}, welcome to my first console application.", userName);
        }
        static partial void welcome5874() { }
    }

}

