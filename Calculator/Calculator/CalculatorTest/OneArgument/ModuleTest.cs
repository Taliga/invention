using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
    public class ModuleTest
    {

        [TestCase(-12, 12)]
        [TestCase(3, 3)]
        [TestCase(-11, 11)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Module();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
