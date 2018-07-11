using System;

namespace Calculator.TwoArguments
{
    public class Division : ICalculator
    {
        /// <summary>
        /// Calculate function division
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// Check secondArgument 
        /// if secondArgument is 0
        /// then error
        /// <returns>
        /// returns result division of two argument
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Деление на 0");
            }
            return firstArgument / secondArgument;
        }
    }
}
