using System;

namespace Calculator.OneArgument
{
    class Tangent : IOoneCalculator
    {

        public double Calculate(double firstArgument) {

            return Math.Tan(firstArgument);

        }

    }
}
