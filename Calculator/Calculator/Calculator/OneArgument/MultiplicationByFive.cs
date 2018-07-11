namespace Calculator.OneArgument
{
    public class MultiplicationByFive : IOoneCalculator
    {
        /// <summary>
        /// Calculate function MultiplicationByFive
        /// </summary>
        /// <param name="firstArgument"></param>
        /// MultiplicationByFive is calculate
        /// <returns>
        /// Returns result function MultiplicationByFive
        /// </returns>

        public double Calculate(double firstArgument)
        {
            return firstArgument * 5f;
        }
    }
}
