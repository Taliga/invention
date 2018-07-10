namespace Calculator.TwoArguments
{
   public class Multiply:ICalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    }
}
