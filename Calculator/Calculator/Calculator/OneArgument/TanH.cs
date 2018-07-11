using System;

namespace Calculator.OneArgument
{
    public class TanH : IOoneCalculator
    {
        /// <summary>
        /// Calculate function TanH(x)
        /// </summary>
        /// <param name="firstArgument"></param>
        /// tanH(x) is calculate
        /// <returns>
        /// Returns result tanH (x)
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Tanh(firstArgument);
        }
    }
}
