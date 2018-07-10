using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.OneArgument;
using Calculator.TwoArguments;
using CalculatorTest.OneArgument;
using CalculatorTest.TwoArgument;
using NUnit.Framework;

namespace CalculatorTest
{
    public class OneArgumentFactoryTest
    {

        [TestCase("Logarithm", typeof(Logarithm))]
        [TestCase("Sinus", typeof(Sinus))]
        [TestCase("Module", typeof(Module))]
        [TestCase("Squaring", typeof(Squaring))]

        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }
    }
}

