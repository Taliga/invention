using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest
{
    public class TanHTests
    {

        public class TanHTest
        {

            [TestCase(0.5, 0.4621)]
            [TestCase(0, 0)]
            [TestCase(-0.9, -0.7163)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new TanH();
                var actualResult = calculator.Calculate(firstValue);
                Assert.AreEqual(expected, actualResult, 0.0001);

            }

        }
    }
}
