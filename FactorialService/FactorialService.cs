using System;
using System.Collections.Generic;
using System.Text;

namespace FactorialService
{
    public class FactorialService
    {
        public int CalculateFactorial(int value)
        {
            if (value < 0 || value > 12)
                throw new ArgumentOutOfRangeException();

            int result = 1;
            for (int i = value; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
