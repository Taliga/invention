using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest
{
  public  class ArctangentTests
    {
        
        public class ArctangentTest
        {
            [TestCase(0.9, 0.7328)]
            [TestCase(0.6, 0.5404)]
            [TestCase(0.5, 0.4636)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Arctangent();
                var actualResult = calculator.Calculate(firstValue);
                Assert.AreEqual(expected, actualResult, 0.0001);
            }
        }

    }
}

