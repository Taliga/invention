using System;

namespace Calculator.OneArgument
{
   public class ArcSinus : IOoneCalculator
    {

        public double Calculate(double firstArgument)
        {
            if (firstArgument < -1 || firstArgument > 1)
            {
                throw new Exception("Недопустимое значение");
            }
            return Math.Asin(firstArgument);

        }
    }
}
