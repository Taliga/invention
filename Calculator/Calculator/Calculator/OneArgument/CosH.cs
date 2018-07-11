using System;

namespace Calculator.OneArgument
{
    public class CosH : IOoneCalculator
    {
        /// <summary>
        /// Calculate function CosH(x)
        /// </summary>
        /// <param name="firstArgument"></param>
        /// cosh(x) is calculate
        /// <returns>
        /// Returns result cosh(x)
        /// </returns>

        public double Calculate(double firstArgument)
        {
            return Math.Cosh(firstArgument);
        }
    }
}
