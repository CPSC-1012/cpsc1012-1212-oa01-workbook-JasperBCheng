using System;

namespace CPSC1012_Lab01_JasperCheng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter the retail price of an item, and the quantity being purchased
            // Calculate the provincial and federal sales tax (provincial tax rate is 6% and the federal tax rate is 5%)

            // Display the following
                    //Sub Total of the purchase
                    //Provincial sales tax
                    //Federal sales tax
                    //Total sales tax
                    //Total of the sale (sum of the amount of purchase plus the total sales tax)

            // Input
                    //itemPrice
                    //itemQuantity

            // Output
                    //subTotal
                    //provincialTax
                    //federalTax
                    //taxTotal
                    //priceTotal

            // Written by: Jasper B. Cheng
            // Written for: Sam Wu
            // CPSC1012 - Programming Fundamentals Section OA01


            // Declaring all of the variables being used in this program
            double itemPrice, subTotal, provincialTax, federalTax, taxTotal, priceTotal;
            int itemQuantity;
            Console.WriteLine($"----------Hi! Welcome to the convenience store!----------");

            // Asking the user to input the price of the item
            Console.Write($"Please enter the price of the item: ");
            itemPrice = double.Parse(Console.ReadLine());

            // Asking the user to input the quantity of the item
            Console.Write($"Please enter the quantity of the item being purchased: ");
            itemQuantity = int.Parse(Console.ReadLine());

            // Calculating the subTotal
            subTotal = itemPrice * itemQuantity;

            // Calculating the provicial tax of the priceItem + quantity
            provincialTax = subTotal * 0.06;

            // Calculating the federal tax of the priceItem + quantity
            federalTax = subTotal * 0.05;

            // Adding up the total tax from both provincial and federal
            taxTotal = provincialTax + federalTax;

            // Adding up the total price from the subtotal and taxtotal
            priceTotal = subTotal + taxTotal;

            // Writing out the receipt of the item
            Console.WriteLine($"\n        Invoice Summary");
            Console.WriteLine($"<------------------------------>");
            Console.WriteLine($" Sub Total: {subTotal, 19:C}");
            Console.WriteLine($"\n\n Provicial Tax: {provincialTax, 15:C}");
            Console.WriteLine($" Federal Tax: {federalTax, 17:C}");
            Console.WriteLine($" Total Tax: {taxTotal, 19:C}");
            Console.WriteLine($"\n\n Total Price: {priceTotal,17:C}");
            Console.WriteLine($"<------------------------------>");
            Console.WriteLine($"\nThank you for your purchase!");
            Console.Write($"Please press enter to exit: ");
            Console.ReadLine();
        }
    }
}
