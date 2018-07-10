namespace Calculator.TwoArguments
{
   public class Division: ICalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument / secondArgument;
        }
    }
}
