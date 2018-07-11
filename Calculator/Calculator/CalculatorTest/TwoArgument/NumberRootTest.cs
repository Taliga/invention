using Calculator.TwoArguments;
using NUnit.Framework;

namespace CalculatorTest.TwoArgument
{
    public class NumberRootTests
    {

        public class NumberRootTest
        {

            [TestCase(2, 0.5, 4)]
            [TestCase(2, 1, 2)]
            [TestCase(-4, 0.5, 16)]
            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new NumberRoot();
                var actualResult = calculator.Calculate(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult);
            }

        }

    }
}
