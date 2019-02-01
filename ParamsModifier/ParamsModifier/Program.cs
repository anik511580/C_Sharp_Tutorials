using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            GuestLists(0);
            //TODO: Need to understand the task of the used integer
            GuestLists(5, "Turku","Finland","Vittu","Satana","Perkele");
            //HACK: Use read to keep the console waiting for input
            //UNDONE: Make more interesting string arrays
            Console.Read();
        }


        /// <summary>
        /// Method to print strings using params.
        /// </summary>
        /// <param name="someUnusedParameter"></param>
        /// <param name="names"></param>
        static void GuestLists(int someUnusedParameter, params string[] names)
        {

            /**
             *This is a multi line XML Documentation system.
             *This will take the string input.
             * Then will print all the name using loop. 
            */
            foreach (string name in names)
                Console.WriteLine("Hello... " + name);

        }

      

    }
}
