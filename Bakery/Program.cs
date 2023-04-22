using System;

namespace Bakery
{
    class Program
    {
        static void Main()
        {
            // Welcome message
            Console.WriteLine("Welcome to Pierre's bakery!");

            // Bread prices and deals
            const int breadPrice = 5;
            const int breadDeal = 3;
            int breadCost;
            Console.WriteLine("Bread costs ${0} each.", breadPrice);

            // Pastry prices and deals
            const int pastryPrice = 2;
            const int pastryDeal = 4;
            int pastryCost;
            Console.WriteLine("Pastry costs ${0} each.", pastryPrice);

            // Ask user for input
            int numBread, numPastry;
            Console.Write("How many loaves of bread do you want to buy? ");
            numBread = int.Parse(Console.ReadLine());
            Console.Write("How many pastries do you want to buy? ");
            numPastry = int.Parse(Console.ReadLine());

            // Calculate bread cost
            breadCost = (numBread / breadDeal) * (2 * breadPrice) + (numBread % breadDeal) * breadPrice;
            Console.WriteLine("Bread cost: ${0}", breadCost);

            // Calculate pastry cost
            pastryCost = (numPastry / pastryDeal) * (3 * pastryPrice) + (numPastry % pastryDeal) * pastryPrice;
            Console.WriteLine("Pastry cost: ${0}", pastryCost);

            // Calculate total cost
            int totalCost = breadCost + pastryCost;
            Console.WriteLine("Total cost: ${0}", totalCost);

            Console.ReadLine(); // To keep the console window open
        }
    }
}
