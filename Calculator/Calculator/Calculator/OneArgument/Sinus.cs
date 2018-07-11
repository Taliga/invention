using System;

namespace Calculator.OneArgument
{
    public class Sinus : IOoneCalculator
    {
        /// <summary>
        /// Calculate function Sinus 
        /// </summary>
        /// <param name="firstArgument"></param>
        /// Sinus is calculate
        /// <returns>
        /// Returns result function Sinus
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}
