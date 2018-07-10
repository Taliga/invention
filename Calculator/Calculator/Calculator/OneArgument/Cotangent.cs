using System;

namespace Calculator.OneArgument
{
    class Cotangent : IOoneCalculator
    {
        public double Calculate(double firstArgument) {

            return 1f / Math.Tan(firstArgument);

        }
    }
}
