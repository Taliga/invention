using System;

namespace Calculator.OneArgument
{
   public class Radical : IOoneCalculator
    {

        public double Calculate(double firstArgument) {


            if (firstArgument < 0)
            {

                throw new Exception("Не может быть отрицательным");

            }

            return Math.Pow(firstArgument, 1f / 2f);

        }

    }
}
