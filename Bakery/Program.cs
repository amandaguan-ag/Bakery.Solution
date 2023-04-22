using System;
using Bakery.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Bakery!");
        
        Bread bread = new Bread();
        Pastry pastry = new Pastry();

        Console.WriteLine("Bread: $5 each. Every 3rd loaf of bread is free.");
        Console.WriteLine("Pastry: $2 each. Every 4th pastry is free.");

        Console.Write("How many bread would you like? ");
        int numBread = int.Parse(Console.ReadLine());

        Console.Write("How many pastry would you like? ");
        int numPastry = int.Parse(Console.ReadLine());

        int breadCost = bread.CalculateCost(numBread);
        int pastryCost = pastry.CalculateCost(numPastry);

        Console.WriteLine($"Your total cost is ${breadCost + pastryCost}");
    }
}
