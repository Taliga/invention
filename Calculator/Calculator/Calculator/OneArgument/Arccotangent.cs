using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.OneArgument;

namespace Calculator
{
    class Arccotangent : IOoneCalculator
    {

        public double Calculate(double firstArgument) {

            return 1f / Math.Atan(firstArgument);

        }

    }
}
