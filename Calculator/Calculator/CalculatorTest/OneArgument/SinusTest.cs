using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
    public class SinusTest
    {

       [TestCase(70, 0.7738)]
       [TestCase(45, 0.8509)]
       [TestCase(60, -0.3048)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Sinus();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult,0.0001);
        }
    }
}
