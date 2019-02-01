using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hey man, do you love C#? (yes/no/maybe)");

            string input;
            input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "yes":
                    Console.WriteLine("Woow, that's great");
                    Console.Read();
                    break;

                case "no":
                    Console.WriteLine("It's okay, no worries :)");
                    Console.Read();
                    break;

                case "maybe":
                    Console.WriteLine("You can take time and think again");
                    Console.Read();
                    break;

                default:
                    Console.WriteLine("Hey, I think you are drunk!!!");
                    Console.Read();
                    break;

                    





            }
        }
    }
}
