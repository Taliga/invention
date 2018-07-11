using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace CalculatorTest
{
    public class NumberRootTests
    {

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

        }

    }
}
