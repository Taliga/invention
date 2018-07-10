using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace CalculatorTest
{
   
        public class ClassSubstraction
        {

            [TestFixture]
            public class SubstractionTests
            {
                [Test]

                public void SubstractionTest()
                {
                    var calculator = new Substraction();
                    Assert.AreEqual(2, calculator.Calculate(3, 1));
                }
            }
        }

    }

