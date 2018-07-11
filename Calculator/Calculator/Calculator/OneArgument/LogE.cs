using System;

namespace Calculator.OneArgument
{
    public class LogE : IOoneCalculator
    {
        /// <summary>
        /// Calculate function LogE
        /// </summary>
        /// <param name="firstArgument"></param>
        /// Check firstArgument less than 0
        /// then error
        /// Check firstArgument==0
        /// then error 
        /// <returns>
        ///  Returns result function LogE
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
