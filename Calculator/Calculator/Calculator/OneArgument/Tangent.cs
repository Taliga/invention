using System;

namespace Calculator.OneArgument
{
   public class Tangent : IOoneCalculator
    {

        public double Calculate(double firstArgument) {

            return Math.Tan(firstArgument);

        }

    }
}
