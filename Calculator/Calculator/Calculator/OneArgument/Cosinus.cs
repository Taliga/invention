using System;

namespace Calculator.OneArgument
{
    class Cosinus : IOoneCalculator
    {
        public double Calculate(double firstArgument) {
            return Math.Cos(firstArgument);
        }
    }
}
