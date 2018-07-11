using System;

namespace Calculator.OneArgument
{
    public class Module : IOoneCalculator
    {
        /// <summary>
        /// Calculate function Module
        /// </summary>
        /// <param name="firstArgument"></param>
        /// module is calculate
        /// <returns>
        /// Returns result function module
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Abs(firstArgument);
        }
    }
}
