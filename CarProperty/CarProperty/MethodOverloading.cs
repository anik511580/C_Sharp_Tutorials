using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProperty
{
     class MethodOverloading
    {

        public MethodOverloading() //constructor - if we create a method with the same name of the class 
        {

        }


        public MethodOverloading(string name) //constructor overloading 
        {

        }

        public void Plus()
        {
            
        }

        public  int Plus(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Plus(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }


    }
}
