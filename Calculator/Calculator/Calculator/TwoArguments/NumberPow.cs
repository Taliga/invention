using System;

namespace Calculator.TwoArguments
{
    public class NumberPow : ICalculator
    {

        public double Calculate(double firstArgument, double secondArgument)
        {

            return Math.Pow(firstArgument,secondArgument);

        }
    }
}
