using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Car objCar = new Car();
            objCar.Color = "RED"; //Set the property value -Color 
            objCar.Price = 10000;
            objCar.Model = "Mazda 6 THE BEST";

            CarDetails objCarDetails = new CarDetails(); //instance 
            objCarDetails.PrintCarDetails(objCar);

            Console.Read();
        }
    }
}
