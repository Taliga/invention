using System;

namespace Calculator.OneArgument
{
    public class Squaring : IOoneCalculator
    {
        /// <summary>
        /// Calculate function Squaring
        /// </summary>
        /// <param name="firstArgument"></param>
        /// Squaring is calculate
        /// <returns>
        /// Returns result function Squaring
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument, 2);
        }
    }
}
