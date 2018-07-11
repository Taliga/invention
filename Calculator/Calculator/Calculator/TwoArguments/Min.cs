using System;

namespace Calculator.TwoArguments
{
  public  class Min : ICalculator
    {

        public double Calculate(double firstArgument, double secondArgument)
        {

            return  Math.Min(firstArgument,secondArgument);

        }

    }
}
