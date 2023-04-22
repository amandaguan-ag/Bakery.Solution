using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class BreadTests
    {
        [TestMethod]
        public void BreadConstructor_CreatesInstanceOfBread()
        {
            // Arrange
            Bread newBread;

            // Act
            newBread = new Bread();

            // Assert
            Assert.IsNotNull(newBread);
        }

        [TestMethod]
        public void CalculateCost_CalculatesCostOfBread()
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
