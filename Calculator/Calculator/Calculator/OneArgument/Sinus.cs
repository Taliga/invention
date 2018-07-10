using System;

namespace Calculator.OneArgument
{
    public class Sinus : IOoneCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);

        }
    }
}
