﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPrivateAssembly
{
    public class BasicComputation
    {
        public float Addition(float num1, float num2)
        {
            float result = num1 + num2;
            return result;
        }
        public float Substraction(float num1, float num2)
        {
            float result = num1 - num2;
            return result;
        }
        public float Multiplication(float num1, float num2)
        {
            float result = num1 * num2;
            return result;
        }
        public float Division(float num1, float num2)
        {
            float result = num1 / num2;
            return result;
        }
    }
}
