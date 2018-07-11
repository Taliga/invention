using System;

namespace Calculator.OneArgument
{
    public class Logarithm : IOoneCalculator 
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument < 0)
            {

                throw new Exception("Не может быть отрицательным");

            }

            else if (firstArgument == 0)
            {

                throw new Exception("Бесконечно убывает");

            }

            return Math.Log(firstArgument);
      
        }
    }
}
