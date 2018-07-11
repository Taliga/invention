using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
  
        public class CotangentTest
        {
            [TestCase(0.9, 0.7936)]
            [TestCase(0.6, 1.4617)]
            [TestCase(0.5, 1.8305)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Cotangent();
                var actualResult = calculator.Calculate(firstValue);
                Assert.AreEqual(expected, actualResult, 0.0001);
            }
        }
    }

