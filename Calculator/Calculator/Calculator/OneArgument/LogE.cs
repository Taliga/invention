using System;

namespace Calculator.OneArgument
{
    class LogE : IOoneCalculator
    {

        public double Calculate(double firstArgument)
        {

            return Math.Log(firstArgument);

        }
    }
}
