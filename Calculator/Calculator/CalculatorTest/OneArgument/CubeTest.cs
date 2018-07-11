using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest
{
    public class CubeTests
    {
        
        public class CubeTest
        {
            [TestCase(2, 8)]
            [TestCase(3, 27)]
            [TestCase(5, 125)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Cube();
                var actualResult = calculator.Calculate(firstValue);
                Assert.AreEqual(expected, actualResult);
            }
        }
    }
}
