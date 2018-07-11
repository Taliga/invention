using System;

namespace Calculator.OneArgument
{
    public class Arccosinus : IOoneCalculator
    {

        public double Calculate(double firstArgument) {

            if (firstArgument > 1 || firstArgument < -1)
            {

                throw new Exception("Недопустимое значение");

            }

            return Math.Acos(firstArgument);

        }

    }
}
