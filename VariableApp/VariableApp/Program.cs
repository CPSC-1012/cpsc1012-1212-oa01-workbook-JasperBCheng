using System;

namespace VariableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intValue = 5;  //You can assign the value of the data type at the same time you declare it
            Console.WriteLine($"The value is {intValue}");

///////////////////////////////////////////////////////////////////////////

            int checking = -20;   //We use the "int" datatype to use number values
            long days = 189000;

            Console.WriteLine($"\nOur account balance is {checking}");
            Console.WriteLine($"About {days} days ago Columbus stood on this spot");

///////////////////////////////////////////////////////////////////////////

            double price, tax, total;  //You can declare multible variables at the same time
            price = 29.75;
            tax = 1.76;
            total = 31.51;

            Console.WriteLine($"\nThe price of the item is {price:C} \nThe tax is {tax:C} \nThe total is {total:C}");  //The :C converts the int value into currency format

///////////////////////////////////////////////////////////////////////////


        }
    }
}
