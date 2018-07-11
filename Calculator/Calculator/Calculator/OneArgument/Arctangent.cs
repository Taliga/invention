using System;

namespace Calculator.OneArgument
{
   public class Arctangent : IOoneCalculator
    {

        public double Calculate(double firstArgument) {

            return Math.Atan(firstArgument);

        }

    }
}
