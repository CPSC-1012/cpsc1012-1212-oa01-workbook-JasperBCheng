using System;

namespace NameSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Random object for generating random numbers
            Random rand = new Random();
            // Generate two random numbers between 1 and 99
            int num1 = rand.Next(1, 100);
            int num2 = rand.Next(1, 100);
            // Conpute the correct additional answer
            int correctAnswer = num1 + num2;
            // Prompt the user for the correct answer
            int userAnswer = PromptForIntergerValue($"What is {num1} + {num2} =");
            if (userAnswer == correctAnswer)
            {
                Console.WriteLine($"Correct! {num1} + {num2} = {correctAnswer}");
            }
            else
            {
                Console.WriteLine($"Incorrect! The correct Answer is {correctAnswer}");
            }
        }

        static int PromptForIntergerValue(string message)
        {
            int integerValue = 0;

            //Prompt the user for an input
            Console.Write(message);
            while (int.TryParse(Console.ReadLine(), out integerValue) == false)
            {
                // Input Value is not an integer
                Console.WriteLine($"Invalid Input! Please enter an Integer Value");
                Console.Write(message);
            }

            return integerValue;
        }
    }
}
