using System;

namespace Calculator.OneArgument
{
   public class Cotangent : IOoneCalculator
    {
        public double Calculate(double firstArgument) {

            return 1f / Math.Tan(firstArgument);

        }
    }
}
