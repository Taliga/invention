using System;

namespace Calculator.OneArgument
{
    class CosH : IOoneCalculator
    {

        public double Calculate(double firstArgument)
        {

            return Math.Cosh(firstArgument);

        }
    }
}
