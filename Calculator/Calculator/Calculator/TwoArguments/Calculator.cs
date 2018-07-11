namespace Calculator.TwoArguments
{
    public interface ICalculator
    {
        /// <summary>
        /// Create interface ICalculator
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        double Calculate(double firstArgument, double secondArgument);
    }
}
