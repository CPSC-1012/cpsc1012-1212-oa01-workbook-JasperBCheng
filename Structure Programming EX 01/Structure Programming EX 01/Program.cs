using System;

namespace Structure_Programming_EX_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Welcome to Structure Programming Exercises!");
            Console.WriteLine($"Please press enter to continue . . . .");
            Console.Write($"> ")
            Console.ReadLine();
            Ex1();    
        }

       static void Ex1(string[] args)
        {
            Console.Clear();
            string Name;
            int Age;
            double AnnualPay;
            Console.WriteLine($"Hi! What is your name?");
            Console.Write($"Name: ");
            Name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"How about your age?");
            Console.Write($"Age: ");
            Age = int.parse(Console.ReadLine());
        }
    }
}
