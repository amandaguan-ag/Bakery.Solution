namespace Bakery.Models
{
    public class Pastry
    {
        private int price_;
        private int deal_;

        public Pastry()
        {
            price_ = 2;
            deal_ = 4;
        }

        public int CalculateCost(int numPastry)
        {
            int pastryCost = (numPastry / deal_) * (3 * price_) + (numPastry % deal_) * price_;
            return pastryCost;
        }
    }
}
