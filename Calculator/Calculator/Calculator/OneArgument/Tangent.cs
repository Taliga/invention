using System;

namespace Calculator.OneArgument
{
    public class Tangent : IOoneCalculator
    {
        /// <summary>
        /// Calculate function Tg(x)
        /// </summary>
        /// <param name="firstArgument"></param>
        /// tg(x) is calculate
        /// <returns>
        /// Returns result function tg(x)
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Tan(firstArgument);
        }
    }
}
