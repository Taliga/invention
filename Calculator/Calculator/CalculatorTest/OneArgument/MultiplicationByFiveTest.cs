using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
    class MultiplicationByFiveTests
    {
        public class MultiplicationByFiveTest
        {
            [TestCase(2, 10)]
            [TestCase(3, 15)]
            [TestCase(5, 25)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new MultiplicationByFive();
                var actualResult = calculator.Calculate(firstValue);
                Assert.AreEqual(expected, actualResult);
            }
        }

    }
}
