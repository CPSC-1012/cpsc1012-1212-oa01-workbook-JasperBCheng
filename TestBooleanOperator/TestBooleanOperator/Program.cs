using System;

namespace TestBooleanOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0 && number % 3 == 0)
                {
                    Console.WriteLine($"{number} is divisible by 2 and 3.");
                }
                if (number % 2 == 0 || number % 3 == 0)
                {
                    Console.WriteLine($"{number} is divisible by 2 or 3.");
                }
                if (number % 2 == 0 ^ number % 3 == 0)
                {
                    Console.WriteLine($"{number} is divisible by 2 or 3, but not both.");
                }

            int birthYear;
            Console.WriteLine($"What is you birth year?");
            Console.Write($"> ");
            birthYear = int.Parse(Console.ReadLine());
            switch (birthYear % 12)
            {
                case 0:
                    Console.WriteLine($"Monkey");
                    break;
                case 1:
                    Console.WriteLine($"Rooster");
                    break;
                case 2:
                    Console.WriteLine($"Dog");
                    break;
                case 3:
                    Console.WriteLine($"Pig");
                    break;
                case 4:
                    Console.WriteLine($"Rat");
                    break;
                case 5:
                    Console.WriteLine($"Ox");
                    break;
                case 6:
                    Console.WriteLine($"Tiger");
                    break;
                case 7:
                    Console.WriteLine($"Rabbit");
                    break;
                case 8:
                    Console.WriteLine($"Dragon");
                    break;
                case 9:
                    Console.WriteLine($"Snake");
                    break;
                case 10:
                    Console.WriteLine($"Horse");
                    break;
                case 11:
                    Console.WriteLine($"Sheep");
                    break;
                default:
                    Console.WriteLine($"Error");
                    break;
            }
        }
    }
}
