using System;

namespace Calculator.OneArgument
{
    class Arccosinus : IOoneCalculator
    {

        public double Calculate(double firstArgument) {

            return Math.Acos(firstArgument);

        }

    }
}
