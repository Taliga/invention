using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest
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
    }
}
