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

        [TestCase(0, 0, 0)]
        [TestCase(3, 4, -1)]
        [TestCase(-7, -2, -5)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Substraction();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
        }

    }

