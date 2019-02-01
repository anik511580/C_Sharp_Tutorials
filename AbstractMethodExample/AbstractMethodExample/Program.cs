using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Collections.ArrayList animalList = new System.Collections.ArrayList();
            animalList.Add(new Dog()); //create an object of the class and then added to the list
            animalList.Add(new Cat());

            foreach (FourLeggedAnimal animal in animalList) //animal - is just a variable
                Console.WriteLine(animal.Describe());

                Console.ReadKey();

        }
    }


    abstract class FourLeggedAnimal
    {
        public abstract string Describe();
    }


    class Dog : FourLeggedAnimal
    {

        public override string Describe()
        {
            return "I'm a dog!";
        }
    }

    class Cat : FourLeggedAnimal
    {
        public override string Describe()
        {
            return "I'm a cat!";
        }
    }
}
