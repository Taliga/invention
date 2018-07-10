using Calculator.TwoArguments;
using NUnit.Framework;

namespace CalculatorTest
{
    public class ClassDivision
    {

        [TestFixture]
        public class DivisionTests
        {
            [Test]

            public void DivisionTest()
            {
                var calculator = new Division();
                Assert.AreEqual(3, calculator.Calculate(3, 1));
            }
        }
    }

}
