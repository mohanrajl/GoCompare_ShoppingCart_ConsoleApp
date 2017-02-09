using Cart.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cart.Console.UnitTest
{
    [TestClass]
    public class PriceCalculationUnitTest
    {
        [TestMethod]
        public void TotalPriceForUserInputsUnitTest()
        {
            // Given test cases
            Assert.AreEqual(0, PriceCalculation.CalculateTotalPrice(""));
            Assert.AreEqual(50, PriceCalculation.CalculateTotalPrice("A"));
            Assert.AreEqual(80, PriceCalculation.CalculateTotalPrice("AB"));
            Assert.AreEqual(115, PriceCalculation.CalculateTotalPrice("CDBA"));
            Assert.AreEqual(100, PriceCalculation.CalculateTotalPrice("AA"));
            Assert.AreEqual(130, PriceCalculation.CalculateTotalPrice("AAA"));
            Assert.AreEqual(175, PriceCalculation.CalculateTotalPrice("AAABB"));
        }

        [TestMethod]
        public void UnitTestToTestNotEqualPrices()
        {
            // Added negative test cases
            Assert.AreNotEqual(175, PriceCalculation.CalculateTotalPrice("AAA"));
            Assert.AreNotEqual(50, PriceCalculation.CalculateTotalPrice(""));
        }

        [TestMethod]
        public void UnitTestToTestInvalidItem()
        {
            // Added invalid item test cases
            Assert.AreEqual(130, PriceCalculation.CalculateTotalPrice("AAAE"));
            Assert.AreEqual(0, PriceCalculation.CalculateTotalPrice("EFG"));
            Assert.AreNotEqual(100, PriceCalculation.CalculateTotalPrice("ABEFG"));
        }
    }
}
