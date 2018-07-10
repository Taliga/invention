using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest
{
    public class ClassSinus
    {

       [TestCase(0, 0)]
     //   [TestCase(90, 1)]
      //  [TestCase(180, 0)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Sinus();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
