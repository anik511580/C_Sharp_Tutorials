using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLesson
{
    class Calculation : ICalculation
    {
        public int CalculateMuliply(int a, int b)
        {
            return a * b;
        }

        public int CalculateSum(int a, int b)
        {
            return a + b;
        }
    }
}
