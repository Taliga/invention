﻿using System;

namespace Calculator.TwoArguments
{
   public class Division: ICalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {

            if (secondArgument == 0)
            {
                throw new Exception("Деление на 0");
            }


            return firstArgument / secondArgument;
        }
    }
}
