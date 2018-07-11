using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
    public class Log10Tests
    {
        public class LogETest
        {
            [TestCase(45, 1.6532)]
            [TestCase(13, 1.1139)]
            [TestCase(1376, 3.1386)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Log10();
                var actualResult = calculator.Calculate(firstValue);
                Assert.AreEqual(expected, actualResult, 0.0001);
            }
        }

        [TestCase(-1)]
       
        public void ExceptionLessThanZeroTest(double firstArgument)
        {
            var calculator = new Log10();
            Assert.Throws<Exception>(() => calculator.Calculate(firstArgument));

        }


        [TestCase(0)]
        public void ExceptionZeroTest(double firstArgument)
        {
            var calculator = new Log10();
            Assert.Throws<Exception>(() => calculator.Calculate(firstArgument));

        }

    }
}
