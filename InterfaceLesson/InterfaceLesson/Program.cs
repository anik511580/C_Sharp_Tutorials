using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation objCalculation = new Calculation();
            int sum=  objCalculation.CalculateSum(1, 2);
            int mul= objCalculation.CalculateMuliply(3, 4);

            Console.WriteLine("SUM: " + sum );
            Console.WriteLine("MUL: " + mul);
            Console.ReadKey();

        }
    }
}
