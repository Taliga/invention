using System;
using Calculator.TwoArguments;

namespace Calculator.OneArgument
{
  public  class Min : ICalculator
    {

        public double Calculate(double firstArgument, double secondArgument)
        {

            return  Math.Min(firstArgument,secondArgument);

        }

    }
}
