using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime();
            Console.WriteLine(dt.ToString());

            DateTime dtNow = DateTime.Now;
            Console.WriteLine(dtNow.ToString());

            DateTime dtFuture = new DateTime(2025,12,20);
            Console.WriteLine(dtFuture.ToString());

            DateTime dtFutureTime = new DateTime(2025, 12, 20, 18, 30,0);
            Console.WriteLine(dtFutureTime.ToString());

            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongDateString());

            var usCulture = new System.Globalization.CultureInfo("en-US");
            Console.WriteLine(DateTime.Now.ToString(usCulture.DateTimeFormat));

            DateTime dtPattern = new DateTime(2042, 12, 24, 18, 42, 0);

            Console.WriteLine("Short date pattern (d): " + dtPattern.ToString("d"));
            Console.WriteLine("Long date pattern (D): " + dtPattern.ToString("D"));
            Console.WriteLine("Full date/time pattern (F): " + dtPattern.ToString("F"));
            Console.WriteLine("Year/month pattern (y): " + dtPattern.ToString("y"));


            DateTime dtFormat = new DateTime(2042, 12, 24, 18, 42, 0);

            Console.WriteLine(dtFormat.ToString("MM'/'dd yyyy"));
            Console.WriteLine(dtFormat.ToString("dd.MM.yyyy"));
            Console.WriteLine(dtFormat.ToString("MM.dd.yyyy HH:mm"));
            Console.WriteLine(dtFormat.ToString("dddd, MMMM (yyyy): HH:mm:ss"));
            Console.WriteLine(dtFormat.ToString("dddd @ hh:mm tt", System.Globalization.CultureInfo.InvariantCulture));
            

            Console.ReadLine();

        }
    }
}
