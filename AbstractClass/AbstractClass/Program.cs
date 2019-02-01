using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine(dog.Describe());
            
            // The following line will not work becauase
            // you cannot create instance/object for abstract class
            // therefore we created another subclass/inheritance 
            //FourLeggedAnimal objFourLeggedAnimal = new FourLeggedAnimal();

            Console.ReadKey();
        }

        abstract class FourLeggedAnimal
        {
            public virtual string Describe()
            {
                return "Not much is known about this four legged animal!";
            }
        }

        class Dog : FourLeggedAnimal
        {

        }


    }
}
