﻿using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
    class RadicalTests
    {
        public class RadicalTest
        {
            [TestCase(4, 2)]
            [TestCase(25, 5)]
            [TestCase(100, 10)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Radical();
                var actualResult = calculator.Calculate(firstValue);
                Assert.AreEqual(expected, actualResult);
            }
        }

    }
}
