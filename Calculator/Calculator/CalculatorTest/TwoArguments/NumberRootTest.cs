using System;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace CalculatorTest.TwoArguments
{
    [TestFixture]
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
        [TestCase(1, 0)]
        [TestCase(-1, 4)]
        public void ExceptionZeroTest(double firstArgument, double secondArgument)
        {
            var calculator = new NumberRoot();
            Assert.Throws<Exception>(() => calculator.Calculate(firstArgument, secondArgument));
        }
    }
}

