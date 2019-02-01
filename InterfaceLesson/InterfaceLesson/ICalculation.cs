using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLesson
{
    interface ICalculation
    {
        int CalculateSum(int a, int b);
        int CalculateMuliply(int a, int b); //only declaration but no body/defination
    }
}
