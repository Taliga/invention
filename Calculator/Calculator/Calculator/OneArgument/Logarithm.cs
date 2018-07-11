using System;

namespace Calculator.OneArgument
{
    public class Logarithm : IOoneCalculator
    {
        /// <summary>
        /// Calculate function Logarithm
        /// </summary>
        /// <param name="firstArgument"></param>
        /// Check firstArgument less than 0
        /// then error
        /// Check firstArgument==0
        /// then error 
        /// <returns>
        /// Returns result function logarithm
        /// </returns>
        public double Calculate(double firstArgument)
        {
            if (firstArgument < 0)
            {
                throw new Exception("Не может быть отрицательным");
            }
            else if (firstArgument == 0)
            {
                throw new Exception("Бесконечно убывает");
            }
            return Math.Log(firstArgument);
        }
    }
}
