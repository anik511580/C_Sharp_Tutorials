using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassExperiment
{
    /// <summary>
    /// This is a Non-Static class with two methods called Sum and Multiplication
    /// </summary>
     class MathematicalCalculation
    {

        /// <summary>
        /// Method to sum two values, it is a Static method.
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public static int Sum(int value1, int value2)
        {
            return (value1 + value2);
        }

        /// <summary>
        /// Method to multiply two values, it is a Non-static method.
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public int Multiplication(int value1, int value2)
        {
            return (value1 * value2);
        }




    }





}
