using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
    [TestFixture]
    public class CosHTest
    {
        [TestCase(0.6, 1.1855)]
        [TestCase(1.5, 2.3524)]
        [TestCase(0, 1)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new CosH();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}
