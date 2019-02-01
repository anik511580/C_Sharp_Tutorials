using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample

{
    class Program
    {
        static void Main(string[] args)
        {
            /* Array Example */

            string[] names = new string[3];

            names[0] = "ANIK";
            names[1] = "BARUA";
            names[2] = "MUNNA";

            Console.Write("Your full name using foreach loop:");
            foreach (string name in names)
                Console.Write(" " + name);
            Console.WriteLine();

            Console.Write("\n Your full name using for loop:");
            for (int i = 0; i < names.Length; i++)
                Console.Write(" " + names[i]);
            Console.WriteLine();


            /* Array Sorting Example */

            int[] numbers = { 5,10,8,1,7,4,9,2,6,3};

            Array.Sort(numbers);

            Console.WriteLine("\n \n Sorting numbers:");
            foreach (int i in numbers)
                Console.Write(" " +i);

            /* Reversing the Array */

            Array.Reverse(numbers);

            Console.WriteLine("\n \n Reverse numbers:");
            foreach (int i in numbers)
                Console.Write(" " + i);

            /* Binary Search */

            Console.WriteLine("\n\n Binary Search:");
            int search=  Array.BinarySearch(numbers, 7);

            if (search < 0)
                Console.WriteLine("Yes, we have found the number");
            else
                Console.WriteLine("Oops! The number not found");

            

            Console.ReadKey();


        }
    }
}
