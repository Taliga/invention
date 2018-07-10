using System;

namespace Calculator.OneArgument
{
    public class TanH : IOoneCalculator
    {

        public double Calculate(double firstArgument)
        {

            return Math.Tanh(firstArgument);

        }
    }
}
