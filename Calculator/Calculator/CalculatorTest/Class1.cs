using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.TwoArguments;
using NUnit.Framework;


namespace CalculatorTest
{
    public class Class1
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

            [Test]
            public void SubstractionTest()
            {
                var calculator = new Substraction();
                Assert.AreEqual(2, calculator.Calculate(3, 1));
            }

            [Test]
            public void MultiplyTest()
            {
                var calculator = new Multiply();
                Assert.AreEqual(2, calculator.Calculate(2, 1));
            }
            [Test]
            public void DivisionTest()
            {
                var calculator = new Division();
                Assert.AreEqual(3, calculator.Calculate(3, 1));
            }

        }


    }
}
