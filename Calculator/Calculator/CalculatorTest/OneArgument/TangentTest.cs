using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest
{
    public class TangentTests
    {
        
        public class TangentTest
        {
            [TestCase(0.9, 1.2602)]
            [TestCase(0.6, 0.6841)]
            [TestCase(0.5, 0.5463)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Tangent();
                var actualResult = calculator.Calculate(firstValue);
                Assert.AreEqual(expected, actualResult,0.0001);
            }
        }

    }
}
