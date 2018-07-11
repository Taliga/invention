using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
    public class CosinusTests
    {
        public class CosinusTest
        {
            [TestCase(0.9, 0.6216)]
            [TestCase(0.6, 0.8253)]
            [TestCase(0.5, 0.8775)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Cosinus();
                var actualResult = calculator.Calculate(firstValue);
                Assert.AreEqual(expected, actualResult, 0.0001);
            }
        }

    }
}
