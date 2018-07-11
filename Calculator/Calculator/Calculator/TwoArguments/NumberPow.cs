using System;

namespace Calculator.TwoArguments
{
    public class NumberPow : ICalculator
    {
        /// <summary>
        /// Calculate functionNumberPow
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// Check two arguments
        /// <returns>
        /// Result NumberPow of two argument
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument);
        }
    }
}
