using System;

namespace Bakery.Models
{
    public class Pastry
    {
    public int Price { get; } = 2;
    public int Deal { get; } = 4; 

        public int CalculateCost(int numPastry)
        {
            int pastryCost = (numPastry / Deal) * (3 * Price) + (numPastry % Deal) * Price;
            return pastryCost;
        }
    }
}
