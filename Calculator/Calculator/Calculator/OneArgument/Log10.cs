using System;

namespace Calculator.OneArgument
{
    public class Log10 : IOoneCalculator
    {
        /// <summary>
        /// Calculate function Log10
        /// </summary>
        /// <param name="firstArgument"></param>
        /// Check firstArgument less than 0
        /// then error
        /// Check firstArgument==0
        /// then error 
        /// <returns>
        /// returns result  function log10
        /// </returns>
        public double Calculate(double firstArgument)
        {
            if (firstArgument < 0)
            {
                throw new Exception("Не может быть отрицательным");
            }
            if (firstArgument == 0)
            {
                throw new Exception("Бесконечно убывает");
            }
            return Math.Log10(firstArgument);
        }
    }
}
