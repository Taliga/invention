using System;

namespace Calculator.OneArgument
{
   public class InverseNumber : IOoneCalculator
    {

        public double Calculate(double firstArgument)
        {

            if (firstArgument == 0)
            {

                throw new Exception("Деление на 0");

            }

            return 1f / firstArgument;
          
        }

    }
}
