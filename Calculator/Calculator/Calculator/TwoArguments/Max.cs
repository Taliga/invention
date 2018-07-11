using System;

namespace Calculator.TwoArguments
{
    public class Max : ICalculator
    {
        /// <summary>
        /// Calculate function Max
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>
        /// Result max for two arguments
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Max(firstArgument, secondArgument);
        }
    }
}
