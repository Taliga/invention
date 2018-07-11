using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
   

        public class SinusHTest
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

