using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest
{
    public class ArcSinusTests
    {

        public class ArcSinusTest
        {

           [TestCase(0.7, 0.7754)]
           [TestCase(0.45, 0.4668)]
           [TestCase(1, 1.5708)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new ArcSinus();
                var actualResult = calculator.Calculate(firstValue);
                Assert.AreEqual(expected, actualResult, 0.0001);
            }
        }

    }
}
