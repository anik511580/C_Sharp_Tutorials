using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t Lessone 1: \n\n");

            Calculation objCalculayion = new Calculation();

            // objCalculayion.Sum(3,5); // when sum is not a static method
            //Console.WriteLine(Calculation.Sum(3, 2)); when sum is a static method


            Console.WriteLine(objCalculayion.Sum(3, 2)); // accessed by creating object 

            
            Console.WriteLine(Calculation.Multiply(30, 50)); // accessed by not creating object but declaring as static 




            Console.Read();
        }
    }
}
