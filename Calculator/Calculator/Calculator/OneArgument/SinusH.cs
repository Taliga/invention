using System;

namespace Calculator.OneArgument
{
    public class SinH : IOoneCalculator
    {

        public double Calculate(double firstArgument)
        {

            return Math.Sinh(firstArgument);

        }
    }
}
