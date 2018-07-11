using System;

namespace Calculator.OneArgument
{
    public class Cotangent : IOoneCalculator
    {
        /// <summary>
        /// Calculate function ctg(x)
        /// </summary>
        /// <param name="firstArgument"></param>
        /// ctg(x) is calculate
        /// <returns>
        /// Returns resut ctg (x)
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return 1 / Math.Tan(firstArgument);
        }
    }
}
