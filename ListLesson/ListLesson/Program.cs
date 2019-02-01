using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Creating list using a Class */

            List<User> listOfUser = new List<User>()
            {
                new User() { Name = "Anik", Age = 25 },
                new User() { Name = "Rafik", Age = 27 },
                new User() { Name = "Rashed", Age = 29 },
                new User() { Name = "Nobab", Age = 24 }
          
        };


            for (int i = 0; i < listOfUser.Count; i++)
            {
                Console.WriteLine(listOfUser[i].Name + " is " + listOfUser[i].Age + " years old");
            }


            /* Experimenting with a string type list */

            List<string> listOfNames = new List<string>()
            {
                "Sakib","Tamim","Musfik","Riad","Mortuza","Gayle"
            };

            Console.WriteLine("\n\nBD Players: ");
            foreach (string name in listOfNames)
                Console.WriteLine(name);

            listOfNames.Add("Taskin");
            listOfNames.Add("Nasir");
            listOfNames.Remove("Gayle");

            Console.WriteLine("\n\nUpdated BD Players: ");
            foreach (string name in listOfNames)
                Console.WriteLine(name);

            listOfNames.Sort();
            Console.WriteLine("\n\nSorted BD Players: ");
            foreach (string name in listOfNames)
                Console.WriteLine(name);

            listOfNames.Reverse();
            Console.WriteLine("\n\nReversed BD Players: ");
            foreach (string name in listOfNames)
                Console.WriteLine(name);


            Console.ReadKey();

        }

    }

    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

   
}
