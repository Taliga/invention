using System;

namespace Calculator.TwoArguments
{
    public class NumberRoot : ICalculator
    {

        public double Calculate(double firstArgument, double secondArgument)
        {

            return Math.Sqrt( firstArgument);

        }
    }
}
