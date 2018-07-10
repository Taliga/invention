using System;

namespace Calculator.OneArgument
{
    public class OneArgumentFactory
    {
        public static IOoneCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Module":
                    return new Module();
                case "Squaring":
                    return new Squaring();
                case "Logarithm":
                    return new Logarithm();
                case "Sinus":
                    return new Sinus();
                case "Cosine":
                    return new Cosinus();
                case "Tangent":
                    return new Tangent();
                case "Cotangent":
                    return new Cotangent();
                case "Arccosine":
                    return new Arccosinus();
                case "Arctangent":
                    return new Arctangent();
                case "Arccotangent":
                    return new Arccotangent();
                case "Radical":
                    return new Radical();
                case "Cube":
                    return new Cube();
                case "InverseNumber":
                    return new InverseNumber();
                case "MultiplicationOnFive":
                    return new MultiplicationByFive();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
