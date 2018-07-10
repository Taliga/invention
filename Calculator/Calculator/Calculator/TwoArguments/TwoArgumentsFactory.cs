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
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
