using System;

namespace Calculator.OneArgument
{
    public class Stepen : IOoneCalculator
    {
        /// <summary>
        /// Calculate fiunction Stepen
        /// </summary>
        /// <param name="firstArgument"></param>
        /// Stepen is calculate
        /// <returns>
        /// Returns result stepen
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Exp(firstArgument);
        }
    }
}
