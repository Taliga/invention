using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
    public class LogETests
    {
        public class LogETest
        {
                [TestCase(3.33, 1.20)]
                [TestCase(7, 1.95)]
                [TestCase(2, 0.69)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new LogE();
                var actualResult = calculator.Calculate(firstValue);
                Assert.AreEqual(expected, actualResult, 0.01);
            }
    }
        
    }
}
