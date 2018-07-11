using System;

namespace Calculator.TwoArguments
{
    public class Min : ICalculator
    {
        /// <summary>
        /// Calculate function Min
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>
        /// Result min for two arguments
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Min(firstArgument, secondArgument);
        }
    }
}
