using Calculator.TwoArguments;
using NUnit.Framework;

namespace CalculatorTest.TwoArgument
{
    public class NumberPowTests
    {

        public class NumberPowTest
        {

            [TestCase(0, 0, 1)]
            [TestCase(2, 2, 4)]
            [TestCase(-2, 3, -8)]
            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new NumberPow();
                var actualResult = calculator.Calculate(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult);
            }

        }

    }
}
