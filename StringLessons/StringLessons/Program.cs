using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLessons
{
    class Program
    {
        static void Main(string[] args)
        {

            //Method 1: by altering the existing string

            string numbers = "";
            for (int i = 0; i < 50; i++)
            {
                numbers = numbers + i.ToString();
                Console.WriteLine(numbers);
            }


            //Method 2: by creating a new string object instead

            StringBuilder objNumbers = new StringBuilder();
            for (int i = 0; i < 30; i++)
                objNumbers.Append(i);
            Console.WriteLine(objNumbers.ToString());

            Console.ReadLine();

        }
    }
}
