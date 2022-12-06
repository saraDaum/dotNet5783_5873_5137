using BlApi;

namespace BlTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            IBl bl = new BlImplementation.BL();
            bl.Order.Add();
        }
    }
}