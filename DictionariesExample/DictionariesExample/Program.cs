using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> users = new Dictionary<string, int>();

            users.Add("ANIK", 25);
            users.Add("TILA", 22);
            users.Add("NIJHUM",24);
            users.Add("PAPRI", 23);

            Console.WriteLine("TILA is " + users["TILA"] + " years old");

            /* Dictionary with cheaking the key first Example */

            string key = "PAPRI";
                if (users.ContainsKey(key))
                Console.WriteLine("We have found PAPRI is " + users[key] + " years old" );

            Dictionary<string, int> usersPair = new Dictionary<string, int>()
{
    { "John Doe", 42 },
    { "Jane Doe", 38 },
    { "Joe Doe", 12 },
    { "Jenna Doe", 12 }
};
            foreach (KeyValuePair<string, int> user in usersPair)
            {
                Console.WriteLine(user.Key + " is " + user.Value + " years old");
            }

            /* Ordered Dictionary Example */
            Dictionary<string, int> usersOrder = new Dictionary<string, int>()
{
    { "John Doe", 42 },
    { "Jane Doe", 38 },
    { "Joe Doe", 12 },
    { "Jenna Doe", 12 }
};
            foreach (KeyValuePair<string, int> user in usersOrder.OrderBy(user => user.Value))
            {
                Console.WriteLine(user.Key + " is " + user.Value + " years old");
            }

            Console.ReadKey();
            


        }
    }
}
