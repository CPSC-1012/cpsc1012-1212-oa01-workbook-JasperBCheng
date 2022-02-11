using System;

namespace TryParseDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program demonstrates how to use TryParse to valid World!");

            // Prompt for valid hockey player number between 1 and 99
            // Repeat until a valid hockey player number is entered
            int hockeyPlayerNumber;
            bool validInput = false;
            
            do
            {
                Console.Write($"Enter the hockey player number (1 - 99): ");
                //hockeyPlayerNumber = int.Parse(Console.ReadLine());
                validInput = int.TryParse(Console.ReadLine(), out hockeyPlayerNumber);
                if (validInput)
                {
                    if (hockeyPlayerNumber < 1 || hockeyPlayerNumber > 99)
                    {
                        Console.WriteLine($"The hockey player number must be between 1 and 99");
                        validInput = false;
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid input value. Try again");
                }
            } while (validInput == false); //(!validInput)

            // Display the hockey player number
            Console.WriteLine($"The hockey player number is {hockeyPlayerNumber}");

        }
    }
}
