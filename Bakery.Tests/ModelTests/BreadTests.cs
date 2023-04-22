using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class BreadTests
    {
        [TestMethod]
        public void BreadConstructor_CreatesInstanceOfBread_Bread()
        {
            // Arrange
            Bread newBread = new Bread();

            // Assert
            Assert.IsNotNull(newBread);
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }

        [TestMethod]
        public void GetPrice_ReturnsPrice_Int()
        {
            // Arrange
            Bread newBread = new Bread();
            int expectedPrice = 5;

            // Act
            int actualPrice = newBread.Price;

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice);
        }

        [TestMethod]
        public void GetDeal_ReturnsDeal_Int()
        {
            // Arrange
            Bread newBread = new Bread();
            int expectedDeal = 3;

            // Act
            int actualDeal = newBread.Deal;

            // Assert
            Assert.AreEqual(expectedDeal, actualDeal);
        }

        [TestMethod]
        public void CalculateCost_CalculateCostOfBread_ReturnsCost()
        {
            // Arrange
            Bread newBread = new Bread();
            int numBread = 5;
            int expectedCost = 20;

            // Act
            int actualCost = newBread.CalculateCost(numBread);

            // Assert
            Assert.AreEqual(expectedCost, actualCost);
        }
    }
}