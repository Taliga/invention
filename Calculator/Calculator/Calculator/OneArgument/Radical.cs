using System;

namespace Calculator.OneArgument
{
    class Radical : IOoneCalculator
    {

        public double Calculate(double firstArgument) {

            return Math.Pow(firstArgument, 1f / 2f);

        }

    }
}
