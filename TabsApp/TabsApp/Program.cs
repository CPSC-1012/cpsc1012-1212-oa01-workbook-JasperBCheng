using System;

namespace TabsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("These are our top sellers: \n");         //\n Creates a new line
            Console.WriteLine("\tItem 1\n \tItem 2 \n \tItem 3");    //\t is the same as pressing tab, giving you space in the same line

            Console.WriteLine("These are our top Sellers: ");
            Console.WriteLine("\tItem 1");
            Console.WriteLine("\tItem 2");
            Console.WriteLine("\tItem 3");
        }
    }
}
