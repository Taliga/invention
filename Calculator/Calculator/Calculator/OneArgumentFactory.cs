using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class OneArgumentFactory
    {
        public static OoneCalculator CreateCalculator(string calculatorName)
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
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
