using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class PastryTests
    {
        [TestMethod]
        public void PastryConstructor_DCreatesInstanceOfPastry_Pastry()
        {
          Pastry newPastry = new Pastry();
          Assert.AreEqual(typeof(Pastry), newPastry.GetType());
        }
        [TestMethod]
        public void GetPrice_ReturnsPrice_Int()
        {
            // Arrange
            Pastry newPastry = new Pastry();
            int expectedPrice = 2;
            int actualPrice = newPastry.Price;
            // Assert
            Assert.AreEqual(expectedPrice, actualPrice);
        }

        [TestMethod]
        public void GetDeal_ReturnsDeal_Int()
        {
            // Arrange
            Pastry newPastry = new Pastry();
            int expectedDeal = 4;

            // Act
            int actualDeal = newPastry.Deal;

            // Assert
            Assert.AreEqual(expectedDeal, actualDeal);
        }

        [TestMethod]
        public void CalculateCost_CalculateCostOfPastry_ReturnsCost()
        {
            // Arrange
            Pastry newPastry = new Pastry();
            int numPastry = 4;
            int expectedCost = 6;

            // Act
            int actualCost = newPastry.CalculateCost(numPastry);

            // Assert
            Assert.AreEqual(expectedCost, actualCost);
        }
    }
}