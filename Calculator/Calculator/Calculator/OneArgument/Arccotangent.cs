using System;

namespace Calculator.OneArgument
{
    class Arccotangent : IOoneCalculator
    {

        public double Calculate(double firstArgument) {

            return 1f / Math.Atan(firstArgument);

        }

    }
}
