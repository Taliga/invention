using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest
{
    public class ClassLogarithm
    {
        [TestCase(1, 0)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Logarithm();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
