using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionParameters
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = 20;
            AddFive(number);
            Console.WriteLine("The sum of the by value function AddFive is : " + number);

            AddFifty(ref number);
            Console.WriteLine("The sum of by ref function AddFifty is: "+ number);
            Console.Read();
           
        }

        /// <summary>
        /// Method to add 5 with the given value. This is a "by value" parameter
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
       public static int AddFive(int number)
        {

            number = number + 5;
            Console.WriteLine("Value inside the function AddFive: "+number);
            return number;

        }


        /// <summary>
        /// Method to add 50 with the given value, this is a "by reference" parameter. 
        /// A value passed to a ref modifier has to be initialized before calling the method
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int AddFifty(ref int number)
        {

            //TODO: do somethiwejr 
            number = number + 50;
            Console.WriteLine("Value insude the function AddFifty: "+number);
            return number;

        }






    }
}
