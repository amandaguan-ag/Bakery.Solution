using System;

namespace Bakery.Models
{
  public class Bread
  {
    private int price_;
    private int deal_;
    public Bread()
    {
      price_ = 5;
      deal_ = 3;
    }
   
    public int CalculateCost(int numBread)
    {
      int breadCost = (numBread / deal_) * (2 * price_) + (numBread % deal_) * price_;
      return breadCost;
    }
  }
}
