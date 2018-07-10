using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.OneArgument;

namespace Calculator
{
    class Cube : IOoneCalculator
    {

        public double Calculate(double firstArgument)
        {

            return Math.Pow(firstArgument, 3);

        }

    }
}
