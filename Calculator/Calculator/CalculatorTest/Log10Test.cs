using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest
{
    public class Log10Tests
    {
        public class LogETest
        {
            [TestCase(45, 1.6532)]
            [TestCase(13, 1.1139)]
            [TestCase(1376, 3.1386)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Log10();
                var actualResult = calculator.Calculate(firstValue);
                Assert.AreEqual(expected, actualResult, 0.0001);
            }
        }
    }
}
