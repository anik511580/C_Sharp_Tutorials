using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        private string helloClass = "Hello, class!";

         private void Main(string[] args)
        {
            string helloLocal = "Hello, local!";
            Console.WriteLine(helloLocal);
            Console.WriteLine(helloClass);
            DoStuff();
            Console.ReadLine();
        }
        private void DoStuff()
        {
            Console.WriteLine("A Message from DoStuff: " + helloClass);
            Console.WriteLine("A Message from DoStuff: " + helloClass);


        }
    }
}
