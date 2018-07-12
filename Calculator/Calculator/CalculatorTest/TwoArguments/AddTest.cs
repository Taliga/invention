using Calculator.TwoArguments;
using NUnit.Framework;

namespace CalculatorTest.TwoArguments
{
    [TestFixture]
    public class AddTest
    {
       public class AddTests
        {
            [TestCase(0, 0, 0)]
            [TestCase(3, 4, 7)]
            [TestCase(-7, -2, -9)]
            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new Add();
                var actualResult = calculator.Calculate(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult);
            }
        }
    }
}