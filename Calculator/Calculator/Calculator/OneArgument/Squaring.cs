using System;

namespace Calculator.OneArgument
{
    public class Squaring : IOoneCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument, 2);

        }
    }
}
