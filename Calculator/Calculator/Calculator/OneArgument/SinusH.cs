using System;

namespace Calculator.OneArgument
{
    class SinH : IOoneCalculator
    {

        public double Calculate(double firstArgument)
        {

            return Math.Sinh(firstArgument);

        }
    }
}
