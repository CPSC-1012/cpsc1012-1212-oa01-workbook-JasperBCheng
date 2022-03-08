/*
 * Write a program that has at least three methods, you may use more if you need, that prompts the user to enter exactly 3 marks then print the average of the three marks and the letter grade for the average.  The first method reads in and verifies marks from a student, call the method PromptForMark.  The marks must be between 0 to 100 and validated for invalid inputs.  The second method calculates and returns the students average, call the method CalculateAverage.  The third method determines the student letter grade, call it LetterGrade.  Use the table below to determine the letter grade.
 * 
 * Input: firstMark, secondMark, thirdMark, 
 * 
 * Output: overallAverage, gradeLetter
 * 
 * Written By: Jasper B. Cheng
 * 
 * Written For: Sam WU
 * 
 * Last Modified: 03/08/2022
 * 
 * Section (1212) (OA01)
 * 
 */

using System;

namespace CSPC1012_Lab4_JasperCheng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int
                firstMark,
                secondMark,
                thirdMark;

            double
                overallAverage;

            string
                gradeLetter;

            bool
                validateRetry = false;

            while (validateRetry == false)
            {
                Console.WriteLine($"****************Student Grade Calculator****************");
                Console.Write($"Input 1st Mark: ");
                firstMark = PromptForMark();
                Console.Write($"\nInput 2nd Mark: ");
                secondMark = PromptForMark();
                Console.Write($"\nInput 3rd Mark: ");
                thirdMark = PromptForMark();
                overallAverage = CalculateAverage(firstMark, secondMark, thirdMark);
                gradeLetter = LetterGrade(overallAverage);
                Console.WriteLine($"\nThe average is {overallAverage:F2}% and a student code of {gradeLetter}");
                Console.WriteLine($"\nDo you want to try again? (Y)|(N)");
                validateRetry = ValidateUserRetry();
            }
        }

        static int PromptForMark()
        {
            int selectedValue = 0;
            bool validateInput = false;
            while (validateInput == false)
            {
                if (int.TryParse(Console.ReadLine(), out selectedValue))
                {
                    if (selectedValue >= 0 && selectedValue <= 100)
                    {
                        validateInput = true;
                    }
                    else if (selectedValue > 100)
                    {
                        Console.WriteLine($"\nInvalid Input!");
                        Console.WriteLine($"Please enter a number between 1 to 100");
                        Console.Write($"> ");
                    }
                    else if (selectedValue < 0)
                    {
                        Console.WriteLine($"\nInvalid Input!");
                        Console.WriteLine($"Please enter a positive number");
                        Console.Write($"> ");
                    }  
                }
                else
                {
                    Console.WriteLine($"\nInput string was not in a correct format");
                    Console.WriteLine($"Please input a positive integer");
                    Console.Write($"> ");
                }
            }
            return selectedValue;
        }

        static double CalculateAverage(int firstMark, int secondMark, int thirdMark)
        {
            const int
                MaxMark = 300,
                AverageMultiplier = 100;
            double totalMark = firstMark + secondMark + thirdMark;
            double totalAverage = (totalMark / MaxMark) * AverageMultiplier;
            return totalAverage;
        }

        static string LetterGrade(double overallAverage)
        {
            string gradeLetter = "default";
            if (overallAverage >= 80)
            {
                gradeLetter = "A";
            }
            else if(overallAverage < 80 && overallAverage >= 65)
            {
                gradeLetter= "B";
            }
            else if(overallAverage < 65 && overallAverage >= 50)
            {
                gradeLetter = "C";
            }
            else if(overallAverage < 50 && overallAverage >= 40)
            {
                gradeLetter = "D";
            }
            else if(overallAverage < 40)
            {
                gradeLetter = "F";
            }
            return gradeLetter;
        }

        static bool ValidateUserRetry()
        {
            bool
                validateInput = false,
                validateRetry = false;
            while (validateInput == false)
            {
                Console.Write($"> ");
                string userRetry = Console.ReadLine();
                if (userRetry == "y" || userRetry == "Y")
                {
                    validateRetry = false;
                    validateInput = true;
                }
                else if (userRetry == "n" || userRetry == "N")
                {
                    validateRetry = true;
                    validateInput = true;
                }
                else
                {
                    Console.WriteLine($"\nInvalid Input!");
                    Console.WriteLine($"Please input either (Y) or (N)");
                }
            }
            Console.WriteLine($"");
            return validateRetry;
        }
    }

}
