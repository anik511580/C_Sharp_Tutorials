using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLesson
{
    public class Dog : Animal
    {
        public override void Greet() // we are overriding the virtual method
        {
            base.Greet(); // we can still access without base keyword 
            Console.WriteLine("Well, I'm a dog!");
        }

        public void KeepBarking()
        {
            Console.WriteLine("Gheu... Gheu... Gheu...");
        }
    }
}
