using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.OneArgument;

namespace Calculator
{
    class Radical : IOoneCalculator
    {

        public double Calculate(double firstArgument) {

            return Math.Pow(firstArgument, 1f / 2f);

        }

    }
}
