using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write your name:");
            string name = Console.ReadLine();
            bool isValid = true;
            for (int i = 0; i < name.Length; i++)
            {
                char ch = name[i];
                if ((i == 0) && ((!Char.IsLetter(ch)) || (!Char.IsUpper(ch))))
                {
                    Console.WriteLine("The first character has to be an uppercase letter!");
                    isValid = false;
                    break;
                }
                if (Char.IsDigit(ch))
                {
                    Console.WriteLine("No digits allowed!");
                    isValid = false;
                    break;
                }
            }
            if (isValid)
                Console.WriteLine("Hello, " + name);

            Console.ReadLine();

        }
    }
}
