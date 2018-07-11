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
        [TestCase("ArcSin", typeof(ArcSinus))]
        [TestCase("Stepen", typeof(Stepen))]
        [TestCase("LogE", typeof(LogE))]
        [TestCase("Log10", typeof(Log10))]
        [TestCase("TanH", typeof(TanH))]
        [TestCase("SinH", typeof(SinH))]
        [TestCase("CosH", typeof(CosH))]
        [TestCase("Radical", typeof(Radical))]
        [TestCase("MultiplicationOnFive", typeof(MultiplicationByFive))]
        [TestCase("Cosine", typeof(Cosinus))]
        [TestCase("InverseNumber", typeof(InverseNumber))]
        [TestCase("Cotangent", typeof(Cotangent))]
        [TestCase("Tangent", typeof(Tangent))]
        [TestCase("Arccosine", typeof(Arccosinus))]
        [TestCase("Arctangent", typeof(Arctangent))]
        [TestCase("Cube", typeof(Cube))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }
    }
}

