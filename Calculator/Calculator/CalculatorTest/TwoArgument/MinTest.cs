using Calculator.OneArgument;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace CalculatorTest.TwoArgument
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

