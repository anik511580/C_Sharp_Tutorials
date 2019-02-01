using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProperty
{
    class Program
    {
        static void Main(string[] args)
        {

           // MethodOverloading objMethodOverloading = new MethodOverloading("anik");


            List<Properties> lstProperties = new List<Properties>();

            CarValues objCarValues = new CarValues();
            lstProperties =  objCarValues.PutCarDetails();

            CarDetails objCarDetails = new CarDetails();
            objCarDetails.PrintCarDetails(lstProperties);

            Console.Read();

        }
    }
}
