using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {

            int number;

            Console.WriteLine("Please enter a number between 1 and 10");
            number = int.Parse(Console.ReadLine()); //Converting string to integer


            Console.WriteLine("\nStatement using only one condition: ");

            if (number > 10)
                Console.WriteLine("Hey, the number is bigger then 10!");
            else if(number < 0)
                Console.WriteLine("Hey, the number is less then 0!");
            else
                Console.WriteLine("Good job... you have listened what I have said ");

            //OR condition

            Console.WriteLine("\nStatement using OR condition:");

            if ((number>10) || (number<0))
                Console.WriteLine("Hey, the number was suppossed to be between 1 to 10");
            else
                Console.WriteLine("Good guy, the number is between 1 to 10");

            //AND Condition

            Console.WriteLine("\nStatement using AND condition:");

            if ((number <= 10) && (number >= 0))
                Console.WriteLine("Awesome, the number is between 1 to 10");
            else
                Console.WriteLine("Hey, I told you to write between 1 to 10");

            Console.ReadLine();







        }
    }
}
