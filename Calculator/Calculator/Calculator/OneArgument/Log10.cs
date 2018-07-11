using System;

namespace Calculator.OneArgument
{
    public class Log10 : IOoneCalculator
    {

        public double Calculate(double firstArgument)
        {


            if (firstArgument < 0)
            {

                throw  new Exception("Не может быть отрицательным");

            }

            if (firstArgument == 0)
            {

                throw new Exception("Бесконечно убывает");

            }



            return Math.Log10(firstArgument);

        }
    }
}
