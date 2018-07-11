﻿using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
    public class ArccosinusTests
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
        }

    }
}
