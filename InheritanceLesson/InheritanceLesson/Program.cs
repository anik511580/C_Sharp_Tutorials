using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLesson
{
    public class Animal
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Greet();
            animal.SayBye();
            Dog dog = new Dog();
            dog.Greet();
            dog.KeepBarking();
            
            Console.ReadLine();

        }

        //In C#, you are not allowed to override a member of a class
        //unless it's marked as virtual.
        public virtual void Greet()
        {
            Console.WriteLine("Hello, I'm some sort of animal!");
        }

        public void SayBye()
        {
            Console.WriteLine("Bye bye for today...");
        }
    }
}
