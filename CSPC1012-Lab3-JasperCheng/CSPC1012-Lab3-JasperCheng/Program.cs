/*
 * Purpose: Write a program which prints out a teaspoon to tablespoon table in incrementes entered by the user from 1 to 20. The increment must be etered as a positive numver otherwise repeatedly ask the use to enter in a positive value. The program should repeat until the user would like to exit.
 * 
 * Input: incrementValue, userInput
 * 
 * Output: teaSpoonValue, tableSpoonValue, invalidInput, retryInput
 * 
 * Written By: Jasper B. Cheng
 * 
 * Written For: Sam WU
 * 
 * Last Modified: 02/11/2022
 * 
 * Section AO8
 * 
 */

using System;

namespace CSPC1012_Lab3_JasperCheng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*--------------------Conversion Table--------------------*");
            //Declaring Variables
            const double TeaSpoonInitialValue = 3.00 / 3.00;
            const double TableSpoonInitialValue = 1.00 / 3.00;

            double 
                //Inputting Initial value onto TeaSpoon
                teaSpoonValue = TeaSpoonInitialValue,
                incrementTeaSpoon,
                //Inputting Initial value onto TableSpoon
                tableSpoonValue = TableSpoonInitialValue, 
                incrementTableSpoon, 
                incrementValue;

            bool 
                userInput, 
                invalidInput = false, 
                retryInput = false;

            string tryAgain;

            //Creating a while loop for Invalid Inputs
            while (invalidInput == false)
            {
                //Setting the retryInput to false so if the user prompts to retry the program it can re-enter the while loop
                retryInput = false;
                Console.WriteLine($"How much would you like to increment? *Must be a positive number*");
                Console.Write($"Choice: ");
                //Asking user on how much they want to increment the values by
                userInput = double.TryParse(Console.ReadLine(), out incrementValue);
                if (incrementValue > 0)
                {
                    Console.WriteLine($"\n*------------------------*");
                    Console.WriteLine($" Tea Spoons  Table Spoons");
                    Console.WriteLine($"<==========  ============>");
                    //Creating a for loop for the incrementation of both tea spoon and table spoon
                    for (double i = 1; i <= 20; i+=incrementTeaSpoon)
                    {
                        //Writing out the Tea Spoon and Table Spoon
                        Console.WriteLine($"{teaSpoonValue,11:F} {tableSpoonValue,14:F}");
                        //The incrementation of Tea Spoon
                        incrementTeaSpoon = TeaSpoonInitialValue * incrementValue;
                        teaSpoonValue = teaSpoonValue + incrementTeaSpoon;
                        //The incrementation of Table Spoon
                        incrementTableSpoon = TableSpoonInitialValue * incrementValue;
                        tableSpoonValue = tableSpoonValue + incrementTableSpoon;
                    }
                    Console.WriteLine($"<========================>");
                    Console.WriteLine($"\n");
                    //Creating a while lopp for Invalid Inputs
                    while (retryInput == false)
                    {
                        Console.WriteLine($"Would you like to try again(Y/N)?");
                        Console.Write($"Choice: ");
                        tryAgain = Console.ReadLine();
                        if (tryAgain == "y" || tryAgain == "Y")
                        {
                            //If the user types "y" or "Y" then the user will go back to the beginning
                            invalidInput = false;
                            retryInput = true;
                            //Resetting the values of the variables
                            teaSpoonValue = TeaSpoonInitialValue;
                            tableSpoonValue = TableSpoonInitialValue;
                            Console.WriteLine($"\n\n");
                        }
                        else if (tryAgain == "n" || tryAgain == "N")
                        {
                            //If the user types "n" or "N" then the program will end
                            Console.WriteLine($"\n\nPlease press any key to exit the program . . . . .");
                            retryInput = true;
                            invalidInput = true;
                        }
                        else
                        {
                            //If the user types an Invalid Input it will repeat the question
                            Console.WriteLine($"\nInvalid Input! Please try Again . . . . .");
                        }
                    }
                }
                else
                {
                    //If the user types an Invalid Input it will repeat the question
                    Console.WriteLine($"\nInvalid Input! Please try again . . . . .");
                }
            }
        }
    }
}
