using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice.Common;

namespace Practice1Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Caluclate_ReturnsTheDifference_GivenInputGreaterThan0AndLessThan10()
        {
            CalculationStrategy calculationStrategy = new CalculationStrategy(10);
            var answer = calculationStrategy.Calculate(5);
            Assert.AreEqual(5, answer);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void Caluclate_ThrowsException_GivenInputIsLessThan0()
        {
            CalculationStrategy calculationStrategy = new CalculationStrategy(10);
            var answer = calculationStrategy.Calculate(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void Caluclate_ThrowsException_GivenInputIsGreaterThanTarget()
        {
            CalculationStrategy calculationStrategy = new CalculationStrategy(10);
            var answer = calculationStrategy.Calculate(21);
        }
    }
}
