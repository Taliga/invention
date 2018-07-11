using System;

namespace Calculator.OneArgument
{
    public class Cube : IOoneCalculator
    {
        /// <summary>
        /// Calculate function Cube
        /// </summary>
        /// <param name="firstArgument"></param>
        /// firstArgument is calculate
        /// <returns>
        /// Returns result cube
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument, 3);
        }
    }
}
