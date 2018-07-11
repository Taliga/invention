﻿using System;

namespace Calculator.TwoArguments
{
    public class NumberRoot : ICalculator
    {

        public double Calculate(double firstArgument, double secondArgument)
        {

            if (secondArgument == 0)
            {

                throw new Exception("Второй аргумент не может быть равен 0");

            }

            return Math.Pow(firstArgument, 1f / secondArgument);

        }
    }
}
