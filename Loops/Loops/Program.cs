using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //While Loop

            int number = 0;

            while (number < 5)
            {
                Console.WriteLine("While Loop no: " + number);
                number = number + 1;
            }


            //Do loop

            int value = 0;
            do
            {
                Console.WriteLine("Do Loop no: " + value);
                value = value + 1;
            }
            while (value < 10);


            //For Loop

            int loopNumber = 10;
            for (int i = 0; i < loopNumber; i++)
                Console.WriteLine("For loop value: " + i);

            //Foreach Loop

            ArrayList list = new ArrayList(); //Remember to add: using System.Collections;
            list.Add("Bus");
            list.Add("Car");
            list.Add("Plane");
            list.Add("Boat");
            list.Add("Rocket");

            foreach (string name in list)
                Console.WriteLine(name);


            Console.ReadLine();

        }
    }
}
