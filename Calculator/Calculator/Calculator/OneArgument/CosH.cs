using System;

namespace Calculator.OneArgument
{
    public class CosH : IOoneCalculator
    {

        public double Calculate(double firstArgument)
        {

            return Math.Cosh(firstArgument);

        }
    }
}
