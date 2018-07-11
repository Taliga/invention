using System;

namespace Calculator.OneArgument
{
    public static class OneArgumentFactory
    {
        /// <summary>
        /// Create Factory OneArgumentFactory
        /// </summary>
        /// <param name="calculatorName"></param>
        /// <returns></returns>
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
                case "Radical":
                    return new Radical();
                case "Cube":
                    return new Cube();
                case "InverseNumber":
                    return new InverseNumber();
                case "MultiplicationOnFive":
                    return new MultiplicationByFive();
                case "ArcSin":
                    return new ArcSinus();
                case "Stepen":
                    return new Stepen();
                case "LogE":
                    return new LogE();
                case "Log10":
                    return new Log10();
                case "TanH":
                    return new TanH();
                case "SinH":
                    return new SinH();
                case "CosH":
                    return new CosH();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
