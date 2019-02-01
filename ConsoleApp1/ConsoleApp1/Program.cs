using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Print a simple line

            Console.WriteLine("Hello TURKU");
            
            //Variable declaration and print name

            string firstName = "ANIK";
            string lastName = "BARUA";

            Console.WriteLine("Your name is: " + firstName + " " + lastName);

            Console.WriteLine("Time to change the name! Please enter a new first name...");
            firstName = Console.ReadLine();

            Console.WriteLine("Congrats, your new name is: " + firstName + " " + lastName);
            //Console.ReadLine();

            //Simple mathematical program

            int number1, number2;

            Console.WriteLine("Please enter the first number");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("One more number please");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The sum of the numbers is:" + (number1 + number2));
            Console.WriteLine("The sub of the numbers is:" + (number1 - number2));
            Console.WriteLine("The mul of the numbers is:" + (number1 * number2));
            Console.WriteLine("The div of the numbers is:" + (number1 / number2));
        
            Console.ReadLine();

        }
    }
}
