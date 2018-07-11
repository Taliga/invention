using System;

namespace Calculator.OneArgument
{
    public class Cosinus : IOoneCalculator
    {
        /// <summary>
        /// Calculate function cos(x)
        /// </summary>
        /// <param name="firstArgument"></param>
        /// cos(x) is calculate
        /// <returns>
        /// Returns result cos(x)
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}
