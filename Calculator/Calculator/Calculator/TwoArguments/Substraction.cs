namespace Calculator.TwoArguments
{
    public class Substraction: ICalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument-secondArgument;
        }
    }
}
