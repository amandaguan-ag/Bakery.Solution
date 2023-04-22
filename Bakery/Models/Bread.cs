using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int Price { get; } = 5;
    public int Deal { get; } = 3; 

    public int CalculateCost(int numBread)
    {
      int breadCost = (numBread / Deal) * (2 * Price) + (numBread % Deal) * Price;
      return breadCost;
    }
  }
}
