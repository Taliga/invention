namespace Calculator.TwoArguments
{
    public class Substraction : ICalculator
    {
        /// <summary>
        /// Calculate function substraction
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// Substraction is performed
        /// <returns>
        /// Returns substraction from the first argument of the second argument
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    }
}
