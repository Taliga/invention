using System;

namespace Calculator.OneArgument
{
    class Cube : IOoneCalculator
    {

        public double Calculate(double firstArgument)
        {

            return Math.Pow(firstArgument, 3);

        }

    }
}
