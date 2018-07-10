using System;

namespace Calculator.OneArgument
{
    public class Module : IOoneCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Abs(firstArgument);

        }
    }
}
