using System;

namespace Calculator.OneArgument
{
    public class SinH : IOoneCalculator
    {
        /// <summary>
        /// Calculate function SinH (x)
        /// </summary>
        /// <param name="firstArgument"></param>
        /// SinH (x) is calculate
        /// <returns>
        /// Returns result function sinh(x)
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Sinh(firstArgument);
        }
    }
}
