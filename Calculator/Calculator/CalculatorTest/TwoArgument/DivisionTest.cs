﻿using Calculator.TwoArguments;
using NUnit.Framework;

namespace CalculatorTest.TwoArgument
{
    public class DivisionTest
    {

        [TestFixture]
        public class DivisionTests
        {
            [TestCase(6, 2, 3)]
            [TestCase(4, 4, 1)]
            [TestCase(-18, -2, 9)]
            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new Division();
                var actualResult = calculator.Calculate(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult);
            }
        }
    }

}