using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* The aim of this program is to know and experiment more about static class and static method.
  Static class cannot be instantiated, means we cannot create objects or variables.
  If we want to use a method from a static class, we have to access be declaring the 
  class name itself and with the method name we want to call.
     */


namespace StaticClassExperiment
{
    class Program
    {
        static void Main(string[] args)
        {

            //At first, we experiment on the non-static class called - MathematicalCalculation

            //This sum is a static method, so we can access directly but we cannot access it by creating new object.
            //So, we directly called the class name and then the method name    
            Console.WriteLine( "The sum of two numbers: " + MathematicalCalculation.Sum(10,20));

         
            //This Multiplication is a non-static method, so cannot access directly and so we have to create a object.
            //So, we create a onject of that class, and then access by object name and method name
            MathematicalCalculation objMathematicalCalculation = new MathematicalCalculation();
            Console.WriteLine("The multiplication of two numbers: "+ objMathematicalCalculation.Multiplication(30,40));


            //In this part, we experiemt the static class called - StaticCalculation
            //The class is static, so the methods under it also needs to be static

            Console.WriteLine("\nCalculation when the class is static: ");

            Console.WriteLine("The sum is: " + StaticCalculation.Sum(1,2));
            Console.WriteLine("The multiplication is: "+StaticCalculation.Multiplication(3,4));

            Console.ReadLine();
        }
    }
}
