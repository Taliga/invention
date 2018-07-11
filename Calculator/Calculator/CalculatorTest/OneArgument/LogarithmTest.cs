using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
    public class LogarithmTest
    {
        [TestCase(2, 0.6931)]
        [TestCase(10, 2.3025)]
        [TestCase(1, 0)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Logarithm();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }

        [TestCase(-1)]

        public void ExceptionLessThanZeroTest(double firstArgument)
        {
            var calculator = new Logarithm();
            Assert.Throws<Exception>(() => calculator.Calculate(firstArgument));

        }


        [TestCase(0)]
        public void ExceptionZeroTest(double firstArgument)
        {
            var calculator = new Logarithm();
            Assert.Throws<Exception>(() => calculator.Calculate(firstArgument));

        }

    }
}
