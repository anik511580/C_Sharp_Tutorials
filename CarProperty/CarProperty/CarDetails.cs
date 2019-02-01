using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProperty
{
    class CarDetails
    {

        public void PrintCarDetails(List<Properties> lstProperties)

        {
            foreach(Properties objProperties in lstProperties)
            {
                Console.WriteLine("Car Location: " + objProperties.CarLocation);
                Console.WriteLine("Model: " + objProperties.CarModelNumber);
                Console.WriteLine("Year: " + objProperties.CarYearNumber);
                Console.WriteLine("Engine Size: " + objProperties.EngineSize);
                Console.WriteLine("Milage: " + objProperties.Milage);
                Console.WriteLine("Price: " + objProperties.Price);
                Console.WriteLine("");
            }

 
        }






    }
}
