using System;

namespace Calculator.OneArgument
{
    class Arccosinus : IOoneCalculator
    {

        public double Calculate(double firstArgument) {

            if (firstArgument > 1 || firstArgument < 0)
            {

                throw new Exception("Недопустимое значение");

            }

            return Math.Acos(firstArgument);

        }

    }
}
