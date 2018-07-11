using System;

namespace Calculator.OneArgument
{
    public class InverseNumber : IOoneCalculator
    {
        /// <summary>
        /// Calculate function InverseNumber
        /// </summary>
        /// <param name="firstArgument"></param>
        /// Check firstArgument 
        /// if firstArgument ==0
        /// then error
        /// <returns>
        /// Returns function InverseNumber
        /// </returns>
        public double Calculate(double firstArgument)
        {
            if (firstArgument == 0)
            {
                throw new Exception("Деление на 0");
            }
            return 1f / firstArgument;
        }
    }
}
