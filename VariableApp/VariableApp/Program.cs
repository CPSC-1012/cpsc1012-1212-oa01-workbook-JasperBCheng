using System;

/*namespace VariableApp
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
            Console.WriteLine($"About {days} days ago Columbus stood on this spot\n\n");

///////////////////////////////////////////////////////////////////////////


            double price, tax, total;  //You can declare multible variables at the same time
            Console.Write($"What is the price?: ");
            string pricestring = Console.ReadLine();  //Double.Parse(); is used to convert string values into double values
            price = double.Parse(pricestring);
            tax = price * 0.05;
            total = price + tax;
            Console.WriteLine($"\nThe price of the item is {price:C} \nThe tax is {tax:C} \nThe total is {total:C}");  //The :C converts the int value into currency format

///////////////////////////////////////////////////////////////////////////


        }
    }
}*/

namespace SaleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Purpose: Compute the total of a sales item using the price and tax.
            //Inputs: Price in dollars and cents
            //Outputs: Sale Total
            //Algorithm: 
                    //Step 1: Prompt and read in the sale price
                    //Step 2: Calculate the sale total using the formula
                            //saleTotal = salePrice + saleTax
                            //Where saleTax == salePrice * 0.05
                            //Step 3: Display the computed sale total

            //Declare variables for inputs and outputs
            double salePrice;
            const double saleTaxRate = 0.05;
            double saleTax;
            double saleTotal;
            string userInput;

            // Step 1.) Prompt and read in the sale price
            Console.Write($"Enter the sale price: ");
            userInput = Console.ReadLine();
            // Convert userInput from a string type to a double type
            salePrice = double.Parse(userInput); //or  salePrice = Convert.ToDouble(userInput); or salePrice = double.Parse(Console.ReadLine());

            // Step 2.) Calculate the sale total and saleTax
            saleTax = salePrice * saleTaxRate;
            saleTotal = salePrice + saleTax;

            // Step 3.) Display the computed sale tax and total
            //Price:  $29.76
            //Tax:    $1.76
            //Total:  $31.51
            Console.WriteLine($"{"Price:",-10} {salePrice, 8:C}");
            Console.WriteLine($"{"Tax:",-10} {saleTax,8:C}");
            Console.WriteLine($"{"Total:",-10} {saleTotal, 8:C}");
        }
    }
}
