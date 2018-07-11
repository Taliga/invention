namespace Calculator.TwoArguments
{
   public class Multiply:ICalculator
    {
        /// <summary>
        /// Calculate function Multiply
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// Check two arguments
        /// <returns>
        ///  Result Multiply of two argument
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    }
}
