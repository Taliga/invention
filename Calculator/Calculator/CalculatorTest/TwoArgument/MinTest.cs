using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest
{
    public class MinTests
    {
        
        public class MinTest
        {
            [TestCase(12,22, 12)]
            [TestCase(14,10, 10)]
            [TestCase(-3, -1,-3)]
            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new Min();
                var actualResult = calculator.Calculate(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult, 0.0001);
            }
        }

    }
}
