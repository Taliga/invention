using System;

namespace Calculator.OneArgument
{
    class Log10 : IOoneCalculator
    {

        public double Calculate(double firstArgument)
        {

            return Math.Log10(firstArgument);

        }
    }
}
