using System;

namespace Calculator.TwoArguments
{
    class Max : ICalculator
    {

        public double Calculate(double firstArgument, double secondArgument)
        {

            return Math.Max(firstArgument, secondArgument);

        }
    }
}
