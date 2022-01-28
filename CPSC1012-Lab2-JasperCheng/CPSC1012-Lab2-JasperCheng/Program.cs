using System;

/**
 * Purpose: To create a program the can convert imperial system values into metric sytem values
 * 
 * Input: ConversionSelected, Inches, Yards, Miles
 * 
 * Output: Centimeters, Meters, Kilometers
 * 
 * Written by: Jasper B. Cheng
 * 
 * Written for: Sam Wu
 * 
 * Section A08
 */
namespace CPSC1012_Lab2_JasperCheng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring the variables
            double inchesValue, yardsValue, milesValue, centimetersValue, metersValue, kilometersValue;
            const double InchesConversion = 2.54;
            const double YardsConversion = 0.9144;
            const double MilesConversion = 1.60934;
            string conversionSelected;
            //Main Menu
            Console.WriteLine("X--------------------Conversion Calculator--------------------X");
            Console.WriteLine($"Please choose one of the following conversions");
            Console.WriteLine($"    1.) Inches to centimeters");
            Console.WriteLine($"    2.) Yards to meters");
            Console.WriteLine($"    3.) Miles to Kilometers");
            Console.WriteLine($"    4.) Exit");
            Console.Write($"Choice: "); 
            //Inputting the selected choice
            conversionSelected = Console.ReadLine();
            if (conversionSelected == "1")
            {
                Console.WriteLine($"\nPlease enter the value in Inches");
                Console.Write($"> ");
                //Inputting the values of Inches
                inchesValue = double.Parse(Console.ReadLine());
                //Converting Inches into Centimeters
                centimetersValue = inchesValue * InchesConversion;
                //Writing out the converted value
                Console.WriteLine($"\nThe value of {inchesValue:F} inches in centimeters is {centimetersValue:F} cm");
            }
            else if(conversionSelected == "2")
            {
                Console.WriteLine($"\nPlease enter the value in Yards");
                Console.Write($"> ");
                //Inputting the values of Yards
                yardsValue = double.Parse(Console.ReadLine());
                //Converting Yards into Meters
                metersValue = yardsValue * YardsConversion;
                //Writing out the converted value
                Console.WriteLine($"\nThe value of {yardsValue:F} yards in meters is {metersValue:F} m");
            }
            else if(conversionSelected == "3")
            {
                Console.WriteLine($"\nPlease enter the value in Miles");
                Console.Write($"> ");
                //Inputting the values of Miles
                milesValue = double.Parse(Console.ReadLine());
                //Converting Miles into Kilometers
                kilometersValue = milesValue * MilesConversion;
                //Writing out the converted value
                Console.WriteLine($"\nThe value of {milesValue:F} miles in kilometers is {kilometersValue:F} km");
            }
            else if(conversionSelected == "4")
            {
                Console.WriteLine($"\nExiting Program . . . .");
            }
            else
            {
                Console.WriteLine($"\nINVALID Choice, Exiting Program . . . .");
            }

        }
    }
}
