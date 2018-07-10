using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
    public class ClassSquaring
    {

        [TestCase(12, 144)]
        [TestCase(30, 900)]
        [TestCase(11, 121)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Squaring();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
