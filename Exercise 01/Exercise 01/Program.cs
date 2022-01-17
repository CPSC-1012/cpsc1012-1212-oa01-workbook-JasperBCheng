using System;

namespace Exercise_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Welcome to Sequence Structure Exercises!");
            Console.Write($"Please press enter to continue: ");
            Console.ReadLine();
            Console.Clear();
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
            //test();
        }

        static void Ex1()
        {
            string Name;
            int Age;
            double AnnualPay;
            Console.Clear();
            Console.WriteLine($"Hi! What is your name?");
            Console.Write($"Name: ");
            Name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"How about your age?");
            Console.Write($"Age: ");
            Age = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Now what is your annual pay?");
            Console.Write($"Annual Pay: ");
            AnnualPay = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Your name is {Name}, a person of {Age} years old with an annual salary of {AnnualPay:C}.");
            Console.WriteLine($"Please press enter to continue . . . .");
            Console.Write($"> ");
            Console.ReadLine();
            Console.Clear();
        }

        static void Ex2()
        {
            double Length;
            double Radius;
            double Area;
            double Volume;
            Console.WriteLine($"Hi! Please input the length and radius of a cylinder");
            Console.Write($"Length: ");
            Length = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write($"Radius: ");
            Radius = double.Parse(Console.ReadLine());
            Console.Clear();
            ////////////////////////////////////////
            Area = Radius * Radius * Math.PI;
            Volume = Area * Length;
            ////////////////////////////////////////
            Console.WriteLine($"The area of the cylinder is {Area} while the volume is {Volume}");
            Console.WriteLine($"Please press enter to continue . . . .");
            Console.Write($"> ");
            Console.ReadLine();
            Console.Clear();
        }

        static void Ex3()
        {
            double SideLength;
            double Area;
            Console.WriteLine($"Please enter the side length of the hexagon");
            Console.Write($"Side Length: ");
            SideLength = double.Parse(Console.ReadLine());
            Console.Clear();
            ////////////////////////////////////////
            double part01 = 3 * Math.Sqrt(3);
            double part02 = part01 / 2;
            Area = part02 * Math.Pow(SideLength, 2);
            ////////////////////////////////////////
            Console.WriteLine($"The area of the hexagon is {Area}");
            Console.WriteLine($"Please press enter to continue . . . .");
            Console.Write($"> ");
            Console.ReadLine();
            Console.Clear();
        }

        static void Ex4()
        {
            int integer, integertest, digit1, digit2, digit3, digit4, totalsum;
            Console.WriteLine($"Please enter a number between 0 and 1000");
            Console.Write($"> ");
            integer = int.Parse(Console.ReadLine());
            Console.Clear();
            integertest = integer;    
            digit1 = integertest % 10;
            integertest = integertest / 10;
            digit2 = integertest % 10;
            integertest = integertest / 10;
            digit3 = integertest % 10;
            integertest = integertest / 10;
            digit4 = integertest % 10;
            totalsum = digit1 + digit2 + digit3 + digit4;
            Console.WriteLine($"The total sum of all digits is {totalsum}");
        }

        static void Ex5()
        {
            double InvestAmount;
            double AnnualInterest; 
            int NumberofYears;
            Console.WriteLine($"Please enter investment amount");
            Console.Write($"> ");
            InvestAmount = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Please enter annual interest rate in percentage");
            Console.Write($"> ");
            AnnualInterest = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Please enter number of years");
            Console.Write($"> ");
            NumberofYears = int.Parse(Console.ReadLine());
            Console.Clear();
            ////////////////////////////////
            double MonthlyInterest = AnnualInterest / 12 / 100;
            double part01 = Math.Pow(1 + MonthlyInterest, NumberofYears * 12);
            double FutureValue = part01 * InvestAmount;
            ////////////////////////////////
            Console.WriteLine($"The Future values is {FutureValue:C}");
            Console.WriteLine($"Please press enter to continue . . . .");
            Console.Write($"> ");
            Console.ReadLine();
            Console.Clear();
        }

        static void test()
        {
            double number1;
            double number2;
            double number3;
            Console.WriteLine($"This program will ask the user to give out three numbers \nThe program will then give out the sum and average of all three numbers");
            Console.Write($"Please press enter to continue: ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Please input the first number");
            Console.Write($"> ");
            number1 = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Please input the second number");
            Console.Write($"> ");
            number2 = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Please input the third number");
            Console.Write($"> ");
            number3 = double.Parse(Console.ReadLine());
            Console.Clear();
            ///////////////////////////////////////////////
            double sum = number1 + number2 + number3; //This basically finds the sum of all three numbers the user has given
            double average = sum / 3; //Meanwhile this code allows us to find the average of all three numbers that was given by the user
            ///////////////////////////////////////////////
            Console.WriteLine($"The sum of the three numbers is {sum} while the average is {average}");
            Console.Write($"Please press enter to continue: ");
            Console.Read();
            Console.Clear();
        }
    }
}
