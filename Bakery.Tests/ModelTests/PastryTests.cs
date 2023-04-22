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
        public void CalculateCost_CalculateCostOfPastry_Int()
        {
            // Arrange
            Pastry newPastry = new Pastry();
            int numPastry = 4;
            int expectedCost = 7;

            // Act
            int actualCost = newPastry.CalculateCost(numPastry);

            // Assert
            Assert.AreEqual(expectedCost, actualCost);
        }
    }
}