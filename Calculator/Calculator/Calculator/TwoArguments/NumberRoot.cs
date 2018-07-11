using System;

namespace Calculator.TwoArguments
{
    public class NumberRoot : ICalculator
    {
        /// <summary>
        /// Calculate function NumberRoot
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// Check secondArgument
        /// if secondArgument==0
        /// then error
        /// check firstArgument
        /// if firstArgument less than 0
        /// then error
        /// <returns>
        /// Result function NumberRoot
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Второй аргумент не может быть равен 0");
            }
            else if (firstArgument < 0)
            {
                throw new Exception("Не может быть отрицательным");
            }
            return Math.Pow(firstArgument, 1f / secondArgument);
        }
    }
}
