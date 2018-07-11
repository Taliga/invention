using System;

namespace Calculator.TwoArguments
{
    public class NumberRoot : ICalculator
    {

        public double Calculate(double firstArgument, double secondArgument)
        {

            return Math.Pow(firstArgument, 1f / secondArgument);

        }
    }
}
