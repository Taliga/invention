using Calculator.TwoArguments;
using NUnit.Framework;

namespace CalculatorTest.TwoArgument
{
    public class MaxTests
    {

        public class MaxTest
        {

            [TestCase(2, 0.5, 2)]
            [TestCase(2, 1, 2)]
            [TestCase(-4, 0.5, 0.5)]
            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new Max();
                var actualResult = calculator.Calculate(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult);
            }

        }

    }
}
