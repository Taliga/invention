using System;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace CalculatorTest.TwoArgument
{
    public class TwoArgumentFactoryTest
    {

        [TestCase("Add", typeof(Add))]
        [TestCase("Substraction", typeof(Substraction))]
        [TestCase("Division", typeof(Division))]
        [TestCase("Multiply", typeof(Multiply))]
        [TestCase("Max", typeof(Max))]
        [TestCase("NumberPow", typeof(NumberPow))]
        [TestCase("NumberRoot", typeof(NumberRoot))]
        [TestCase("Min", typeof(Min))]

        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}
