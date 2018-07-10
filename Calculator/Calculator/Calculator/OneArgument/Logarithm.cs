using System;

namespace Calculator.OneArgument
{
    public class Logarithm : IOoneCalculator 
    {
        public double Calculate(double firstArgument)
        {
            return Math.Log(firstArgument);
      
        }
    }
}
