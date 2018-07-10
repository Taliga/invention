using System;

namespace Calculator.TwoArguments
{
    public class TwoArgumentsFactory
    {
        public static ICalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Multiply":
                    return  new Multiply();
                case "Division":
                    return  new Division();
                case "Add":
                    return  new Add();
                case "Substraction":
                    return  new Substraction();
                case "Max":
                    return new Max();
                case "NumberPow":
                    return new NumberPow();
                case "NumberRoot":
                    return new NumberRoot();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
