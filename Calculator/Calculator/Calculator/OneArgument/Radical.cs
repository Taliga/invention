using System;

namespace Calculator.OneArgument
{
    public class Radical : IOoneCalculator
    {
        /// <summary>
        /// Calculate function Radical
        /// </summary>
        /// <param name="firstArgument"></param>
        /// Check firstArgument 
        /// if firstArgument less than 0
        /// then error
        /// <returns>
        /// Returns result function Radical
        /// </returns>
        public double Calculate(double firstArgument)
        {
            if (firstArgument < 0)
            {
                throw new Exception("Не может быть отрицательным");
            }
            return Math.Pow(firstArgument, 1f / 2f);
        }
    }
}
