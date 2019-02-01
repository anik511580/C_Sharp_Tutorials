using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession1
{
    public  class Calculation
    {
        /// <summary>
        /// Method to sum two values.
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public int Sum(int value1, int value2)
        {
            int result = value1 + value2;
            return result;
        }

        /// <summary>
        /// Method to multiply two values.
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public static double Multiply(int value1, int value2)
        {
            return value1 * value2;
        }



    }
}

