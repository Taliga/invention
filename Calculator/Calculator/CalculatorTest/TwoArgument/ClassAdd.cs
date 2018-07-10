using Calculator.TwoArguments;
using NUnit.Framework;


namespace CalculatorTest
{
    public class ClassAdd
    {

        [TestFixture]
        public class AddTests
        {
            [Test]
            
            public void AddTest()
            {
               var calculator = new Add();
                Assert.AreEqual(4, calculator.Calculate(3,1));
            }
        }
    }



}
