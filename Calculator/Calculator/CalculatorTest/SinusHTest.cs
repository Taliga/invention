using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest
{
    public class SinusHTests
    {

        public class SinusTest
        {

            [TestCase(-0.3, -0.3045)]
            [TestCase(-1.3, -1.6984)]
            [TestCase(0.01, 0.0100)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new SinH();
                var actualResult = calculator.Calculate(firstValue);
                Assert.AreEqual(expected, actualResult, 0.0001);

            }

        }

    }
}
