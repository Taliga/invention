using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.OneArgument;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace CalculatorTest
{
    public class TwoArgumentFactoryTest
    {

        [TestCase("Add", typeof(Add))]
        [TestCase("Substraction", typeof(Substraction))]
        [TestCase("Division", typeof(Division))]
        [TestCase("Multiply", typeof(Multiply))]

        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}
