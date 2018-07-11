namespace Calculator.TwoArguments
{
    public class Add:ICalculator
    {
        /// <summary>
        /// Calculate function addiction
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// addiction is performed
        /// <returns>
        /// Returns addiction from the first argument of the second argument
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}
