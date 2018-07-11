using System;
using System.Runtime.Serialization;
using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
   public class ArccosinusTest
        {
            [TestCase(0.9, 0.4510)]
            [TestCase(0.6, 0.9272)]
            [TestCase(0.5, 1.0471)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Arccosinus();
                var actualResult = calculator.Calculate(firstValue);
                Assert.AreEqual(expected, actualResult, 0.1);
            }

        [TestCase(-2)]
        [TestCase(2)]
        public void ExceptionTest(double firstArgument)
        {
            var calculator = new Arccosinus();
            Assert.Throws<Exception>(() => calculator.Calculate(firstArgument));
        }

        }

    
}

