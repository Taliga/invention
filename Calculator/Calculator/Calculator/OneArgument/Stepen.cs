using System;

namespace Calculator.OneArgument
{
    public class Stepen : IOoneCalculator
    {

        public double Calculate(double firstArgument)
        {

            return Math.Exp(firstArgument);

        }
    }
}
