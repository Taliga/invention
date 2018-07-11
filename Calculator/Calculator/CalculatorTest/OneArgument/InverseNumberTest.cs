using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
    public class InverseNumberTests
    {
        public class InverseNumberTest
        {
            [TestCase(2, 0.5)]
            [TestCase(4, 0.25)]
            [TestCase(5, 0.2)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new InverseNumber();
                var actualResult = calculator.Calculate(firstValue);
                Assert.AreEqual(expected, actualResult,0.01);
            }
        }

        [TestCase(0)]
        public void ExceptionTest(double firstArgument)
        {
            var calculator = new InverseNumber();
            Assert.Throws<Exception>(() => calculator.Calculate(firstArgument));

        }

    }
}
