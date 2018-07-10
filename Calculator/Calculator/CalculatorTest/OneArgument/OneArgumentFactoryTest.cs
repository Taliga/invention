using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
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

